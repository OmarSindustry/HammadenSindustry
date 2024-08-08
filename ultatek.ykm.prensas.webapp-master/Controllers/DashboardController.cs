using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using WebApplication.Repository;

namespace WebApplication.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IConfiguration _configuration;

        public DashboardController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<JsonResult> GetDatos()
        {
            var datos = new List<DatosModel>();
            Console.WriteLine("Starting GetDatos..."); // Mensaje de depuración

            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            Console.WriteLine($"Using connection string: {connectionString}"); // Mensaje de depuración

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Datos";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    Console.WriteLine("Connection opened successfully."); // Mensaje de depuración
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    Console.WriteLine("Query executed successfully."); // Mensaje de depuración

                    while (reader.Read())
                    {
                        try
                        {
                            var dato = new DatosModel
                            {
                                NumeroNodo = reader.GetInt32(reader.GetOrdinal("numeroNodo")),
                                ConsumoKWH = SafeGetDecimal(reader, reader.GetOrdinal("Consumo_KWH")),
                                VoltajeV = SafeGetDecimal(reader, reader.GetOrdinal("Voltaje_V")),
                                CorrienteA = SafeGetDecimal(reader, reader.GetOrdinal("Corriente_A")),
                                FactorPotencia = SafeGetDecimal(reader, reader.GetOrdinal("Factor_Potencia")),
                                DioxidoCarbonoCO2 = SafeGetDecimal(reader, reader.GetOrdinal("Dioxido_Carbono_CO2")),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")).ToString("o"), // Formato ISO 8601
                                Carga = reader.GetString(reader.GetOrdinal("carga")),
                                TipoVoltaje = reader.GetString(reader.GetOrdinal("tipoVoltaje"))
                            };

                            datos.Add(dato);
                            Console.WriteLine($"Added record: {dato.NumeroNodo}, {dato.Fecha}"); // Mensaje de depuración
                        }
                        catch (Exception ex)
                        {
                            // Log or handle the exception as needed
                            Console.WriteLine($"Error converting data: {ex.Message}");
                        }
                    }

                    Console.WriteLine($"Total records fetched: {datos.Count}"); // Mensaje de depuración
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing query: {ex.Message}"); // Mensaje de depuración
                }
            }

            return Json(datos);
        }


        [HttpGet]
        public async Task<JsonResult> GetConsumoByFecha(string fechaInicial, string fechaFinal)
        {
            var datos = new List<DatosModel>();  // Use your relevant model

            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT Measured, Value 
            FROM Consumptions 
            WHERE Measured BETWEEN @FechaInicial AND @FechaFinal";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FechaInicial", DateTimeOffset.Parse(fechaInicial));
                command.Parameters.AddWithValue("@FechaFinal", DateTimeOffset.Parse(fechaFinal));

                try
                {
                    connection.Open();
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        datos.Add(new DatosModel
                        {
                            Fecha = reader.GetDateTimeOffset(reader.GetOrdinal("Measured")).ToString("o"),
                            ConsumoKWH = reader.GetDecimal(reader.GetOrdinal("Value"))
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing query: {ex.Message}");
                }
            }

            return Json(datos);
        }



        private decimal SafeGetDecimal(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
            {
                return reader.GetDecimal(colIndex);
            }
            return 0; // valor por defecto si no se puede convertir
        }

        [HttpGet]
        public JsonResult Dashboard_Grafica_TRF1500_1_Json()
        {
            DashboardRepo EmpRepo = new DashboardRepo(_configuration);
            var output = EmpRepo.Dashboard_Grafica_TRF1500_1();
            return Json(output);
        }

        [HttpGet]
        public JsonResult Dashboard_Grafica_TRF1500_2_Json()
        {
            DashboardRepo EmpRepo = new DashboardRepo(_configuration);
            var output = EmpRepo.Dashboard_Grafica_TRF1500_2();
            return Json(output);
        }

        [HttpGet]
        public JsonResult Dashboard_Grafica_TRF2500_Json()
        {
            DashboardRepo EmpRepo = new DashboardRepo(_configuration);
            var output = EmpRepo.Dashboard_Grafica_TRF2500();
            return Json(output);
        }

        [HttpGet]
        public JsonResult Dashboard_Grafica_stamping_Json()
        {
            DashboardRepo EmpRepo = new DashboardRepo(_configuration);
            var output = EmpRepo.Dashboard_Grafica_stamping();
            return Json(output);
        }

        [HttpGet]
        public JsonResult Dashboard_Grafica_stampingKayasaki_Json()
        {
            DashboardRepo EmpRepo = new DashboardRepo(_configuration);
            var output = EmpRepo.Dashboard_Grafica_stampingKayasaki();
            return Json(output);
        }
    }

    public class DatosModel
    {
        public int NumeroNodo { get; set; }
        public decimal ConsumoKWH { get; set; }
        public decimal VoltajeV { get; set; }
        public decimal CorrienteA { get; set; }
        public decimal FactorPotencia { get; set; }
        public decimal DioxidoCarbonoCO2 { get; set; }
        public string Fecha { get; set; } // Cambiado a string para enviar formato ISO 8601
        public string Carga { get; set; }
        public string TipoVoltaje { get; set; }
    }
}
