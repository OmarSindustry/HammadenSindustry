    using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System;
using WebApplication.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Globalization;

namespace WebApplication.Repository
{
    public class catalogoRepo
    {

        private IConfiguration Configuration;

        public catalogoRepo(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [HttpGet]
        public List<CatalogoModel> get_lineas()
        {
            List<CatalogoModel> dataList = new List<CatalogoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_catalogo_get_lineas", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrad

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new CatalogoModel
                            {
                                id = Convert.ToInt32(dr["linea_id"]),
                                nombre = dr["nombre"].ToString(),

                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }
        [HttpGet]
        public List<CatalogoModel> get_proyectado()
        {
            List<CatalogoModel> dataList = new List<CatalogoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_catalogos_get_proyectado", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrad

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new CatalogoModel
                            {
                                proyectado = dr["proyectado"].ToString(),
                                model_code = dr["model_code"].ToString(),
                                
                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }


        [HttpGet]
        public resultadoModel edit_proyectado_trf1500_1(
            int num_parte_1, int proyectado_1,
            int num_parte_2, int proyectado_2,
            int num_parte_3, int proyectado_3,
            int num_parte_4, int proyectado_4,
            int num_parte_5, int proyectado_5,
            int num_parte_6, int proyectado_6,
            int num_parte_7, int proyectado_7,
            int num_parte_8, int proyectado_8,
            int num_parte_9, int proyectado_9,
            int num_parte_10, int proyectado_10,
            int num_parte_11, int proyectado_11,
            int num_parte_12, int proyectado_12 )
        {

            resultadoModel resultado = new resultadoModel();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_proyectado_trf1500_1", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@num_parte_1", num_parte_1);
                    com.Parameters.AddWithValue("@proyectado_1", proyectado_1);

                    com.Parameters.AddWithValue("@num_parte_2", num_parte_2);
                    com.Parameters.AddWithValue("@proyectado_2", proyectado_2);

                    com.Parameters.AddWithValue("@num_parte_3", num_parte_3);
                    com.Parameters.AddWithValue("@proyectado_3", proyectado_3);

                    com.Parameters.AddWithValue("@num_parte_4", num_parte_4);
                    com.Parameters.AddWithValue("@proyectado_4", proyectado_4);

                    com.Parameters.AddWithValue("@num_parte_5", num_parte_5);
                    com.Parameters.AddWithValue("@proyectado_5", proyectado_5);

                    com.Parameters.AddWithValue("@num_parte_6", num_parte_6);
                    com.Parameters.AddWithValue("@proyectado_6", proyectado_6);

                    com.Parameters.AddWithValue("@num_parte_7", num_parte_7);
                    com.Parameters.AddWithValue("@proyectado_7", proyectado_7);

                    com.Parameters.AddWithValue("@num_parte_8", num_parte_8);
                    com.Parameters.AddWithValue("@proyectado_8", proyectado_8);

                    com.Parameters.AddWithValue("@num_parte_9", num_parte_9);
                    com.Parameters.AddWithValue("@proyectado_9", proyectado_9);

                    com.Parameters.AddWithValue("@num_parte_10", num_parte_10);
                    com.Parameters.AddWithValue("@proyectado_10", proyectado_10);

                    com.Parameters.AddWithValue("@num_parte_11", num_parte_11);
                    com.Parameters.AddWithValue("@proyectado_11", proyectado_11);

                    com.Parameters.AddWithValue("@num_parte_12", num_parte_12);
                    com.Parameters.AddWithValue("@proyectado_12", proyectado_12);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }



        [HttpGet]
        public resultadoModel edit_proyectado_trf1500_2(
            int num_parte_1, int proyectado_1,
            int num_parte_2, int proyectado_2,
            int num_parte_3, int proyectado_3,
            int num_parte_4, int proyectado_4,
            int num_parte_5, int proyectado_5,
            int num_parte_6, int proyectado_6,
            int num_parte_7, int proyectado_7,
            int num_parte_8, int proyectado_8,
            int num_parte_9, int proyectado_9,
            int num_parte_10, int proyectado_10,
            int num_parte_11, int proyectado_11,
            int num_parte_12, int proyectado_12)
        {

            resultadoModel resultado = new resultadoModel();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_proyectado_trf1500_2", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@num_parte_1", num_parte_1);
                    com.Parameters.AddWithValue("@proyectado_1", proyectado_1);

                    com.Parameters.AddWithValue("@num_parte_2", num_parte_2);
                    com.Parameters.AddWithValue("@proyectado_2", proyectado_2);

                    com.Parameters.AddWithValue("@num_parte_3", num_parte_3);
                    com.Parameters.AddWithValue("@proyectado_3", proyectado_3);

                    com.Parameters.AddWithValue("@num_parte_4", num_parte_4);
                    com.Parameters.AddWithValue("@proyectado_4", proyectado_4);

                    com.Parameters.AddWithValue("@num_parte_5", num_parte_5);
                    com.Parameters.AddWithValue("@proyectado_5", proyectado_5);

                    com.Parameters.AddWithValue("@num_parte_6", num_parte_6);
                    com.Parameters.AddWithValue("@proyectado_6", proyectado_6);

                    com.Parameters.AddWithValue("@num_parte_7", num_parte_7);
                    com.Parameters.AddWithValue("@proyectado_7", proyectado_7);

                    com.Parameters.AddWithValue("@num_parte_8", num_parte_8);
                    com.Parameters.AddWithValue("@proyectado_8", proyectado_8);

                    com.Parameters.AddWithValue("@num_parte_9", num_parte_9);
                    com.Parameters.AddWithValue("@proyectado_9", proyectado_9);

                    com.Parameters.AddWithValue("@num_parte_10", num_parte_10);
                    com.Parameters.AddWithValue("@proyectado_10", proyectado_10);

                    com.Parameters.AddWithValue("@num_parte_11", num_parte_11);
                    com.Parameters.AddWithValue("@proyectado_11", proyectado_11);

                    com.Parameters.AddWithValue("@num_parte_12", num_parte_12);
                    com.Parameters.AddWithValue("@proyectado_12", proyectado_12);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }


        [HttpGet]
        public resultadoModel edit_proyectado_trf2500(
            int num_parte_1, int proyectado_1,
            int num_parte_2, int proyectado_2,
            int num_parte_3, int proyectado_3,
            int num_parte_4, int proyectado_4,
            int num_parte_5, int proyectado_5,
            int num_parte_6, int proyectado_6,
            int num_parte_7, int proyectado_7,
            int num_parte_8, int proyectado_8,
            int num_parte_9, int proyectado_9,
            int num_parte_10, int proyectado_10,
            int num_parte_11, int proyectado_11,
            int num_parte_12, int proyectado_12)
        {

            resultadoModel resultado = new resultadoModel();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_proyectado_trf2500", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@num_parte_1", num_parte_1);
                    com.Parameters.AddWithValue("@proyectado_1", proyectado_1);

                    com.Parameters.AddWithValue("@num_parte_2", num_parte_2);
                    com.Parameters.AddWithValue("@proyectado_2", proyectado_2);

                    com.Parameters.AddWithValue("@num_parte_3", num_parte_3);
                    com.Parameters.AddWithValue("@proyectado_3", proyectado_3);

                    com.Parameters.AddWithValue("@num_parte_4", num_parte_4);
                    com.Parameters.AddWithValue("@proyectado_4", proyectado_4);

                    com.Parameters.AddWithValue("@num_parte_5", num_parte_5);
                    com.Parameters.AddWithValue("@proyectado_5", proyectado_5);

                    com.Parameters.AddWithValue("@num_parte_6", num_parte_6);
                    com.Parameters.AddWithValue("@proyectado_6", proyectado_6);

                    com.Parameters.AddWithValue("@num_parte_7", num_parte_7);
                    com.Parameters.AddWithValue("@proyectado_7", proyectado_7);

                    com.Parameters.AddWithValue("@num_parte_8", num_parte_8);
                    com.Parameters.AddWithValue("@proyectado_8", proyectado_8);

                    com.Parameters.AddWithValue("@num_parte_9", num_parte_9);
                    com.Parameters.AddWithValue("@proyectado_9", proyectado_9);

                    com.Parameters.AddWithValue("@num_parte_10", num_parte_10);
                    com.Parameters.AddWithValue("@proyectado_10", proyectado_10);

                    com.Parameters.AddWithValue("@num_parte_11", num_parte_11);
                    com.Parameters.AddWithValue("@proyectado_11", proyectado_11);

                    com.Parameters.AddWithValue("@num_parte_12", num_parte_12);
                    com.Parameters.AddWithValue("@proyectado_12", proyectado_12);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }


        [HttpGet]
        public resultadoModel edit_proyectado_stamping(
            int num_parte_1, int proyectado_1,
            int num_parte_2, int proyectado_2,
            int num_parte_3, int proyectado_3,
            int num_parte_4, int proyectado_4,
            int num_parte_5, int proyectado_5,
            int num_parte_6, int proyectado_6,
            int num_parte_7, int proyectado_7,
            int num_parte_8, int proyectado_8,
            int num_parte_9, int proyectado_9,
            int num_parte_10, int proyectado_10,
            int num_parte_11, int proyectado_11,
            int num_parte_12, int proyectado_12)
        {

            resultadoModel resultado = new resultadoModel();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_proyectado_stamping", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@num_parte_1", num_parte_1);
                    com.Parameters.AddWithValue("@proyectado_1", proyectado_1);

                    com.Parameters.AddWithValue("@num_parte_2", num_parte_2);
                    com.Parameters.AddWithValue("@proyectado_2", proyectado_2);

                    com.Parameters.AddWithValue("@num_parte_3", num_parte_3);
                    com.Parameters.AddWithValue("@proyectado_3", proyectado_3);

                    com.Parameters.AddWithValue("@num_parte_4", num_parte_4);
                    com.Parameters.AddWithValue("@proyectado_4", proyectado_4);

                    com.Parameters.AddWithValue("@num_parte_5", num_parte_5);
                    com.Parameters.AddWithValue("@proyectado_5", proyectado_5);

                    com.Parameters.AddWithValue("@num_parte_6", num_parte_6);
                    com.Parameters.AddWithValue("@proyectado_6", proyectado_6);

                    com.Parameters.AddWithValue("@num_parte_7", num_parte_7);
                    com.Parameters.AddWithValue("@proyectado_7", proyectado_7);

                    com.Parameters.AddWithValue("@num_parte_8", num_parte_8);
                    com.Parameters.AddWithValue("@proyectado_8", proyectado_8);

                    com.Parameters.AddWithValue("@num_parte_9", num_parte_9);
                    com.Parameters.AddWithValue("@proyectado_9", proyectado_9);

                    com.Parameters.AddWithValue("@num_parte_10", num_parte_10);
                    com.Parameters.AddWithValue("@proyectado_10", proyectado_10);

                    com.Parameters.AddWithValue("@num_parte_11", num_parte_11);
                    com.Parameters.AddWithValue("@proyectado_11", proyectado_11);

                    com.Parameters.AddWithValue("@num_parte_12", num_parte_12);
                    com.Parameters.AddWithValue("@proyectado_12", proyectado_12);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }


        [HttpGet]
        public resultadoModel edit_proyectado_stamping_kayasaki(
            int num_parte_1, int proyectado_1,
            int num_parte_2, int proyectado_2,
            int num_parte_3, int proyectado_3,
            int num_parte_4, int proyectado_4,
            int num_parte_5, int proyectado_5,
            int num_parte_6, int proyectado_6,
            int num_parte_7, int proyectado_7,
            int num_parte_8, int proyectado_8,
            int num_parte_9, int proyectado_9,
            int num_parte_10, int proyectado_10,
            int num_parte_11, int proyectado_11,
            int num_parte_12, int proyectado_12)
        {

            resultadoModel resultado = new resultadoModel();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_proyectado_stamping_kayasaki", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@num_parte_1", num_parte_1);
                    com.Parameters.AddWithValue("@proyectado_1", proyectado_1);

                    com.Parameters.AddWithValue("@num_parte_2", num_parte_2);
                    com.Parameters.AddWithValue("@proyectado_2", proyectado_2);

                    com.Parameters.AddWithValue("@num_parte_3", num_parte_3);
                    com.Parameters.AddWithValue("@proyectado_3", proyectado_3);

                    com.Parameters.AddWithValue("@num_parte_4", num_parte_4);
                    com.Parameters.AddWithValue("@proyectado_4", proyectado_4);

                    com.Parameters.AddWithValue("@num_parte_5", num_parte_5);
                    com.Parameters.AddWithValue("@proyectado_5", proyectado_5);

                    com.Parameters.AddWithValue("@num_parte_6", num_parte_6);
                    com.Parameters.AddWithValue("@proyectado_6", proyectado_6);

                    com.Parameters.AddWithValue("@num_parte_7", num_parte_7);
                    com.Parameters.AddWithValue("@proyectado_7", proyectado_7);

                    com.Parameters.AddWithValue("@num_parte_8", num_parte_8);
                    com.Parameters.AddWithValue("@proyectado_8", proyectado_8);

                    com.Parameters.AddWithValue("@num_parte_9", num_parte_9);
                    com.Parameters.AddWithValue("@proyectado_9", proyectado_9);

                    com.Parameters.AddWithValue("@num_parte_10", num_parte_10);
                    com.Parameters.AddWithValue("@proyectado_10", proyectado_10);

                    com.Parameters.AddWithValue("@num_parte_11", num_parte_11);
                    com.Parameters.AddWithValue("@proyectado_11", proyectado_11);

                    com.Parameters.AddWithValue("@num_parte_12", num_parte_12);
                    com.Parameters.AddWithValue("@proyectado_12", proyectado_12);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }

        [HttpGet]
        public resultadoModel add_linea(string nombre)
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {                  

                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_add_linea", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@nombre", nombre);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }
        
        [HttpGet]
        public resultadoModel edit_linea(int id, string nombre)
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_linea", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@id", id);
                    com.Parameters.AddWithValue("@nombre", nombre);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }


        [HttpGet]
        public List<CatalogoModel> get_conexiones()
        {
            List<CatalogoModel> dataList = new List<CatalogoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_catalogo_get_conexiones", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrad

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new CatalogoModel
                            {
                                id = Convert.ToInt32(dr["id"]),
                                nombre = dr["nombre"].ToString(),
                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }

        [HttpGet]
        public resultadoModel add_conexion(string nombre)
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_add_conexion", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@nombre", nombre);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }

        [HttpGet]
        public resultadoModel edit_conexion(int id, string nombre)
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_conexion", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@id", id);
                    com.Parameters.AddWithValue("@nombre", nombre);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }
        
        [HttpGet]
        public List<CatalogoModel> get_maquinas()
        {
            List<CatalogoModel> dataList = new List<CatalogoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_catalogo_get_maquinas", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrad

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new CatalogoModel
                            {
                                id = Convert.ToInt32(dr["id"]),
                                nombre = dr["nombre"].ToString(),
                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }

        [HttpGet]
        public resultadoModel add_maquina(string nombre)
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_add_maquina", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@nombre", nombre);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }

        [HttpGet]
        public resultadoModel edit_maquina(int id, string nombre)
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_maquina", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@id", id);
                    com.Parameters.AddWithValue("@nombre", nombre);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }




        [HttpGet]
        public List<DispositivoModel> get_dispositivos()
        {
            List<DispositivoModel> dataList = new List<DispositivoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_catalogo_get_dispositivos", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrad

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new DispositivoModel
                            {
                                dispositivo_id = Convert.ToInt32(dr["id"]),
                                nombre = dr["nombre"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                maquina = dr["maquina"].ToString(),
                                linea = dr["linea"].ToString(),
                                conexion = dr["conexion"].ToString(),
                                direccion_ip = dr["direccion_ip"].ToString(),
                                puerto = Convert.ToInt32(dr["puerto"]),


                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }

        [HttpGet]
        public resultadoModel add_dispositivo(string nombre, string descripcion, string direccion, int puerto, int linea_id, int maquina_id, int conexion_id )
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_add_dispositivo", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@nombre", nombre);
                    com.Parameters.AddWithValue("@descripcion", descripcion);
                    com.Parameters.AddWithValue("@direccion", direccion);
                    com.Parameters.AddWithValue("@puerto", puerto);
                    com.Parameters.AddWithValue("@linea_id", linea_id);
                    com.Parameters.AddWithValue("@maquina_id", maquina_id);
                    com.Parameters.AddWithValue("@conexion_id", conexion_id);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }

        [HttpGet]
        public resultadoModel edit_dispositivo(int id, string nombre, string descripcion, string direccion, int puerto, int linea_id, int maquina_id, int conexion_id)
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_dispositivo", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@id", id);
                    com.Parameters.AddWithValue("@nombre", nombre);
                    com.Parameters.AddWithValue("@descripcion", descripcion);
                    com.Parameters.AddWithValue("@direccion_ip", direccion );
                    com.Parameters.AddWithValue("@puerto", puerto );
                    com.Parameters.AddWithValue("@linea_id", linea_id);
                    com.Parameters.AddWithValue("@maquina_id", maquina_id);
                    com.Parameters.AddWithValue("@conexion_id", conexion_id);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }




        [HttpGet]
        public List<modeloModel> get_modelos(int id)
        {
            List<modeloModel> dataList = new List<modeloModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_catalogo_get_modelos", con);
                    com.CommandType = CommandType.StoredProcedure;


                    com.Parameters.AddWithValue("@estacion_id", id);
                    // variable de entrad

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new modeloModel
                            {
                                id = Convert.ToInt32(dr["id"]),
                                model_code = Convert.ToInt32(dr["model_code"]),
                                part_number = dr["part_number"].ToString(),
                                piezas_golpe = Convert.ToInt32(dr["piezas_golpe"]),
                                spm = Convert.ToInt32(dr["spm"]),

                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }

     
        [HttpGet]
        public resultadoModel edit_modelo(int id, string part_number, int piezas_golpe, int spm)
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_modelo", con);
                    com.CommandType = CommandType.StoredProcedure;

                    // variable de entrada 
                    com.Parameters.AddWithValue("@id", id);
                    com.Parameters.AddWithValue("@part_number", part_number);
                    com.Parameters.AddWithValue("@piezas_golpe", piezas_golpe);
                    com.Parameters.AddWithValue("@spm", spm);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }





        [HttpGet]
        public List<HorarioModel> get_horarios()
        {
            List<HorarioModel> dataList = new List<HorarioModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_catalogos_get_horarios", con);
                    com.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new HorarioModel
                            {
                                horario_id = Convert.ToInt32(dr["horario_id"]),
                                nombre = dr["nombre"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                horario_inicio = dr["horario_inicio"].ToString(),
                                horario_fin = dr["horario_fin"].ToString(),

                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }


        [HttpGet]
        public resultadoModel Edit_Horario(int horario_id, string nombre, string horario_inicio, string horario_fin)
        {

            resultadoModel resultado = new resultadoModel();

            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    // abre la conexion 
                    con.Open();

                    SqlCommand com = new SqlCommand("web_catalogos_edit_horario", con);
                    com.CommandType = CommandType.StoredProcedure;

                    DateTime dateTime_Inicio = DateTime.ParseExact(horario_inicio, "HH:mm",
                                        CultureInfo.InvariantCulture);
                    DateTime dateTime_Fin = DateTime.ParseExact(horario_fin, "HH:mm",
                                        CultureInfo.InvariantCulture);
                    // variable de entrada 
                    com.Parameters.AddWithValue("@horario_id", horario_id);
                    com.Parameters.AddWithValue("@descripcion", "");
                    com.Parameters.AddWithValue("@nombre", nombre);
                    com.Parameters.AddWithValue("@horario_inicio", dateTime_Inicio);
                    com.Parameters.AddWithValue("@horario_fin", dateTime_Fin);

                    // variables de salida 
                    com.Parameters.Add("@resultadoSta_Out", SqlDbType.Int);
                    com.Parameters["@resultadoSta_Out"].Direction = ParameterDirection.Output;
                    com.Parameters.Add("@resultMsg_Out", SqlDbType.VarChar, 50);
                    com.Parameters["@resultMsg_Out"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    resultado.resultado = (int)com.Parameters["@resultadoSta_Out"].Value;
                    resultado.mensaje = (string)com.Parameters["@resultMsg_Out"].Value;

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                    resultado.mensaje = ex.Message;
                    resultado.resultado = 100;
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return resultado;
            }
        }








        [HttpGet]
        public List<DropdownModel> get_conexiones_dropdown()
        {
            List<DropdownModel> dataList = new List<DropdownModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dropdown_get_conexiones", con);
                    com.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new DropdownModel
                            {
                                id = Convert.ToInt32(dr["id"]),
                                nombre = dr["nombre"].ToString(),

                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }
        [HttpGet]
        public List<DropdownModel> get_lineas_dropdown()
        {
            List<DropdownModel> dataList = new List<DropdownModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dropdown_get_lineas", con);
                    com.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new DropdownModel
                            {
                                id = Convert.ToInt32(dr["id"]),
                                nombre = dr["nombre"].ToString(),

                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }

        [HttpGet]
        public List<DropdownModel> get_maquinas_dropdown()
        {
            List<DropdownModel> dataList = new List<DropdownModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dropdown_get_maquinas", con);
                    com.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new DropdownModel
                            {
                                id = Convert.ToInt32(dr["id"]),
                                nombre = dr["nombre"].ToString(),

                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }


        [HttpGet]
        public List<DropdownModel> get_modelos_dropdown()
        {
            List<DropdownModel> dataList = new List<DropdownModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dropdown_get_estaciones", con);
                    com.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new DropdownModel
                            {
                                id = Convert.ToInt32(dr["id"]),
                                nombre = dr["nombre"].ToString(),

                            });
                    }

                    return dataList;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Insert failed with: " + ex.Message);
                }
                finally
                {
                    if (con != null)
                        con.Close();
                }

                return dataList;
            }
        }







    }
}
