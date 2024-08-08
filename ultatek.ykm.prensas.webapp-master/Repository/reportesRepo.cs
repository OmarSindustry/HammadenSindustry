using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System;
using WebApplication.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace WebApplication.Repository
{
    public class reportesRepo
    {

        private IConfiguration Configuration;

        public reportesRepo(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [HttpGet]
        public List<reporteModel> reporte_get_stamping(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_stamping", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString() ,
                                fecha_fin = dr["fecha_fin"].ToString()  ,
                                fecha_inicio = dr["fecha_inicio"].ToString() ,
                                minutos_producidos = dr["minutos_producidos"].ToString()   ,
                                numero_parte = dr["numero_parte"].ToString() ,
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),

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
        public List<reporteModel> reporte_get_stamping_kayasaki(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_stamping_kayasaki", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString(),
                                fecha_fin = dr["fecha_fin"].ToString(),
                                fecha_inicio = dr["fecha_inicio"].ToString(),
                                minutos_producidos = dr["minutos_producidos"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),

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
        public List<reporteModel> reporte_get_trf1500_1(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_trf1500_1", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString(),
                                fecha_fin = dr["fecha_fin"].ToString(),
                                fecha_inicio = dr["fecha_inicio"].ToString(),
                                minutos_producidos = dr["minutos_producidos"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),

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
        public List<reporteModel> reporte_get_trf1500_2(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_trf1500_2", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString(),
                                fecha_fin = dr["fecha_fin"].ToString(),
                                fecha_inicio = dr["fecha_inicio"].ToString(),
                                minutos_producidos = dr["minutos_producidos"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),

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
        public List<reporteModel> reporte_get_trf2500(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_trf2500", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString(),
                                fecha_fin = dr["fecha_fin"].ToString(),
                                fecha_inicio = dr["fecha_inicio"].ToString(),
                                minutos_producidos = dr["minutos_producidos"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),
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
        public List<reporteModel> reporte_get_stamping_historico(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_stamping_historico", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),

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
        public List<reporteModel> reporte_get_stamping_kayasaki_historico(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_stamping_kayasaki_historico", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),

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
        public List<reporteModel> reporte_get_trf1500_1_historico(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_trf1500_1_historico", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),

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
        public List<reporteModel> reporte_get_trf1500_2_historico(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_trf1500_2_historico", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),

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
        public List<reporteModel> reporte_get_trf2500_historico(string fechaInicial, string fechaFinal)
        {
            List<reporteModel> dataList = new List<reporteModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_reportes_get_eventos_trf2500_historico", con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@fecha_inicial", fechaInicialISO));
                    com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new reporteModel
                            {
                                modelo = dr["modelo"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                total_golpes = dr["total_golpes"].ToString(),
                                spm = dr["spm"].ToString(),
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
