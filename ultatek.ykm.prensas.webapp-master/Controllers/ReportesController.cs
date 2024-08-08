using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using OfficeOpenXml;
using SkiaSharp;
using WebApplication.Repository;
using WebApplication.Data;
using DocumentFormat.OpenXml.InkML;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Controllers
{
    public class ReportesController : Controller
    {
        private readonly IConfiguration Configuration;

        public ReportesController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult TRF1500_1()
        {
            return View();
        }
        /*Meters*/
        public async Task<JsonResult> GetTodosLosDatos(DateTimeOffset fechaInicial, DateTimeOffset fechaFinal)
        {
            Console.WriteLine($"Fecha Inicial: {fechaInicial}, Fecha Final: {fechaFinal}");
            var datos = new List<DatosModel2>();
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT Id, MeterId, ScheduleId, Unit, Value, Measured 
                             FROM Hamadden.dbo.Consumptions 
                             WHERE Measured BETWEEN @FechaInicial AND @FechaFinal";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FechaInicial", fechaInicial);
                        cmd.Parameters.AddWithValue("@FechaFinal", fechaFinal);

                        conn.Open();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                var dato = new DatosModel2
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    MeterId = reader.GetInt32(reader.GetOrdinal("MeterId")),
                                    ScheduleId = reader.GetInt32(reader.GetOrdinal("ScheduleId")),
                                    Unit = reader.GetString(reader.GetOrdinal("Unit")),
                                    Value = reader.GetInt32(reader.GetOrdinal("Value")), // Uso de GetInt32 porque el tipo es int
                                    Consumo = reader.GetInt32(reader.GetOrdinal("Value")) * 0.527m, // Conversión de int a decimal para multiplicación
                                    Measured = reader.GetFieldValue<DateTimeOffset>(reader.GetOrdinal("Measured"))
                                };
                                Console.WriteLine($"Dato leído: {dato.Id}, MeterId: {dato.MeterId}, Measured: {dato.Measured}");
                                datos.Add(dato);
                            }
                        }
                    }
                    Console.WriteLine("Datos obtenidos: " + datos.Count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la API: " + ex.Message);
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return Json(new { error = ex.Message });
            }

            return Json(datos);
        }


        /*CONSUMPTION PER DAY*/
        public IActionResult TRF2500() { return View(); }
        [HttpGet]
        [HttpGet]
        public async Task<JsonResult> ObtenerDatosPorDiaYMeterId(DateTimeOffset fecha, int meterId)
        {
            Console.WriteLine($"Obteniendo datos para Fecha: {fecha}, MeterId: {meterId}");

            var datos = new List<DatosModel2>();
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Definir el rango de fechas
                    DateTimeOffset fechaInicio = new DateTimeOffset(fecha.Date, fecha.Offset);
                    DateTimeOffset fechaFin = fechaInicio.AddDays(1).AddTicks(-1); // Fin del día
                    Console.WriteLine($"Rango de fechas: Inicio: {fechaInicio}, Fin: {fechaFin}");

                    // Llamada al procedimiento almacenado
                    string query = @"EXEC sp_ObtenerValorYFechaPorDiaYMeterId @FechaInicio, @FechaFin, @MeterId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                        cmd.Parameters.AddWithValue("@MeterId", meterId);

                        conn.Open();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                datos.Add(new DatosModel2
                                {
                                    Value = reader.GetInt32(reader.GetOrdinal("Value")),
                                    Measured = reader.GetFieldValue<DateTimeOffset>(reader.GetOrdinal("Measured"))
                                });
                            }
                        }
                    }
                    Console.WriteLine("Datos obtenidos: " + datos.Count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la API: " + ex.Message);
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return Json(new { error = ex.Message });
            }

            return Json(datos);
        }






        // Otros métodos de acción y definición de DatosModel2
        public IActionResult TRF1500_2() { return View(); }

        public IActionResult Stamping() { return View(); }
        public IActionResult StampingYakasaki() { return View(); }
        public IActionResult TRF1500_1_Historico() { return View(); }
        public IActionResult TRF1500_2_Historico() { return View(); }
        public IActionResult TRF2500_Historico() { return View(); }
        public IActionResult Stamping_Historico() { return View(); }
        public IActionResult StampingYakasaki_Historico() { return View(); }

        [HttpGet]
        public JsonResult reporte_get_stamping_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_stamping(fechaInicial, fechaFinal);
            return Json(output);
        }

        [HttpGet]
        public JsonResult reporte_get_stamping_kayasaki_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_stamping_kayasaki(fechaInicial, fechaFinal);
            return Json(output);
        }

        [HttpGet]
        public JsonResult reporte_get_trf1500_1_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_trf1500_1(fechaInicial, fechaFinal);
            return Json(output);
        }

        [HttpGet]
        public JsonResult reporte_get_trf1500_2_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_trf1500_2(fechaInicial, fechaFinal);
            return Json(output);
        }

        [HttpGet]
        public JsonResult reporte_get_trf2500_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_trf2500(fechaInicial, fechaFinal);
            return Json(output);
        }

        [HttpGet]
        public JsonResult reporte_get_stamping_historico_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_stamping_historico(fechaInicial, fechaFinal);
            return Json(output);
        }

        [HttpGet]
        public JsonResult reporte_get_stamping_kayasaki_historico_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_stamping_kayasaki_historico(fechaInicial, fechaFinal);
            return Json(output);
        }

        [HttpGet]
        public JsonResult reporte_get_trf1500_1_historico_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_trf1500_1_historico(fechaInicial, fechaFinal);
            return Json(output);
        }

        [HttpGet]
        public JsonResult reporte_get_trf1500_2_historico_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_trf1500_2_historico(fechaInicial, fechaFinal);
            return Json(output);
        }

        [HttpGet]
        public JsonResult reporte_get_trf2500_historico_Json(string fechaInicial, string fechaFinal)
        {
            reportesRepo EmpRepo = new reportesRepo(Configuration);
            var output = EmpRepo.reporte_get_trf2500_historico(fechaInicial, fechaFinal);
            return Json(output);
        }
    }

    public class DatosModel2
    {
        public int Id { get; set; }
        public int MeterId { get; set; }
        public int ScheduleId { get; set; }
        public string Unit { get; set; }
        public int Value { get; set; } // Este es un int según la base de datos
        public decimal Consumo { get; set; } // Este valor lo calculas, así que puede seguir siendo decimal
        public DateTimeOffset Measured { get; set; }
    }


}