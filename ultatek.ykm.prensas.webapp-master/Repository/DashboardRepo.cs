using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public class DashboardRepo
    {
        private IConfiguration Configuration;

        public DashboardRepo(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [HttpGet]
        public List<eventoModel> Dashboard_Grafica_TRF1500_1()
        {
            List<eventoModel> dataList = new List<eventoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    //DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    //DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_dashboard_grafica_trf1500_1", con);
                    com.CommandType = CommandType.StoredProcedure;

                    //com.Parameters.Add(new SqlParameter("@id", PLCProcessesId));
                    //com.Parameters.Add(new SqlParameter("@fecha_inicio", fechaInicialISO));
                    //com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new eventoModel
                            {
                                resultado = dr["resultado"].ToString(),
                                fecha_evento = dr["fecha_evento"].ToString(),

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
        public List<eventoModel> Dashboard_Grafica_TRF2500()
        {
            List<eventoModel> dataList = new List<eventoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    //DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    //DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_dashboard_grafica_trf2500", con);
                    com.CommandType = CommandType.StoredProcedure;

                    //com.Parameters.Add(new SqlParameter("@id", PLCProcessesId));
                    //com.Parameters.Add(new SqlParameter("@fecha_inicio", fechaInicialISO));
                    //com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new eventoModel
                            {
                                resultado = dr["resultado"].ToString(),
                                fecha_evento = dr["fecha_evento"].ToString(),

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
        public List<eventoModel> Dashboard_Grafica_TRF1500_2()
        {
            List<eventoModel> dataList = new List<eventoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    //DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    //DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_dashboard_grafica_trf1500_2", con);
                    com.CommandType = CommandType.StoredProcedure;

                    //com.Parameters.Add(new SqlParameter("@id", PLCProcessesId));
                    //com.Parameters.Add(new SqlParameter("@fecha_inicio", fechaInicialISO));
                    //com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new eventoModel
                            {
                                resultado = dr["resultado"].ToString(),
                                fecha_evento = dr["fecha_evento"].ToString(),

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
        public List<eventoModel> Dashboard_Grafica_stamping()
        {
            List<eventoModel> dataList = new List<eventoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    //DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    //DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_dashboard_grafica_stamping", con);
                    com.CommandType = CommandType.StoredProcedure;

                    //com.Parameters.Add(new SqlParameter("@id", PLCProcessesId));
                    //com.Parameters.Add(new SqlParameter("@fecha_inicio", fechaInicialISO));
                    //com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new eventoModel
                            {
                                resultado = dr["resultado"].ToString(),
                                fecha_evento = dr["fecha_evento"].ToString(),

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
        public List<eventoModel> Dashboard_Grafica_stampingKayasaki()
        {
            List<eventoModel> dataList = new List<eventoModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {

                    //DateTimeOffset fechaInicialISO = DateTime.ParseExact(fechaInicial, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    //DateTimeOffset fechaFinalISO = DateTime.ParseExact(fechaFinal, "yyyy-MM-dd HH:mm",
                    //                   System.Globalization.CultureInfo.InvariantCulture);
                    // DateTime myDate = DateTime.Parse(fechaInicial);

                    SqlCommand com = new SqlCommand("web_dashboard_grafica_stampingKayasaki", con);
                    com.CommandType = CommandType.StoredProcedure;

                    //com.Parameters.Add(new SqlParameter("@id", PLCProcessesId));
                    //com.Parameters.Add(new SqlParameter("@fecha_inicio", fechaInicialISO));
                    //com.Parameters.Add(new SqlParameter("@fecha_final", fechaFinalISO));


                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    con.Open();
                    da.Fill(dt);
                    con.Close();

                    //Bind EmpModel generic list using dataRow     
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataList.Add(
                            new eventoModel
                            {
                                resultado = dr["resultado"].ToString(),
                                fecha_evento = dr["fecha_evento"].ToString(),

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
