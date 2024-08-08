using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System;
using WebApplication.Models;
using Microsoft.Extensions.Configuration;

namespace WebApplication.Repository
{
    public class homeRepo
    {

        private IConfiguration Configuration;

        public homeRepo(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }





        /// <summary>
        /// trf 1500 1
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public List<actualModel> Get_last_trf1500_1()
        {
            List<actualModel> dataList = new List<actualModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_last_trf1500_1", con);
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
                            new actualModel
                            {
                                contador = dr["contador"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                modelo = dr["modelo"].ToString(),
                                spm = dr["spm"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                proyectado = dr["proyectado"].ToString(),

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
        public List<graficaModel> Get_proyectado_trf1500_1()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_proyectado_trf1500_1", con);
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
                            new graficaModel
                            {
                                proyectado_pasado = dr["proyectado_pasado"].ToString(),
                                proyectado_actual = dr["proyectado_actual"].ToString(),

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
        public List<graficaModel> Get_actual_trf1500_1()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dash_test", con);
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
                            new graficaModel
                            {
                                fecha = dr["fecha"].ToString(),
                                produccion = dr["produccion"].ToString(),
                                part_number = dr["part_number"].ToString(),
                                
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
        public List<jphModel> Get_jph_trf1500_1()
        {
            List<jphModel> dataList = new List<jphModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_jph_trf1500_1", con);
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
                            new jphModel
                            {
                                piezas_modelo_actual = dr["piezas_modelo_actual"].ToString(),
                                modelo_actual = dr["modelo_actual"].ToString(),
                                proyectado = dr["proyectado"].ToString(),
                                golpes_totales = dr["golpes_totales"].ToString(),
                                diferencia = dr["diferencia"].ToString(),
                                sph_promedio = dr["sph_promedio"].ToString(),
                                
                                

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


        /// <summary>
        /// trf 1500 2 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<actualModel> Get_last_trf1500_2()
        {
            List<actualModel> dataList = new List<actualModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_last_trf1500_2", con);
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
                            new actualModel
                            {
                                contador = dr["contador"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                modelo = dr["modelo"].ToString(),
                                spm = dr["spm"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                proyectado = dr["proyectado"].ToString(),
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
        public List<graficaModel> Get_actual_trf1500_2()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_actual_trf1500_2", con);
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
                            new graficaModel
                            {
                                fecha = dr["fecha"].ToString(),
                                produccion = dr["produccion"].ToString(),
                                part_number = dr["part_number"].ToString(),

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
        public List<jphModel> Get_jph_trf1500_2()
        {
            List<jphModel> dataList = new List<jphModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_jph_trf1500_2", con);
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
                            new jphModel
                            {
                                piezas_modelo_actual = dr["piezas_modelo_actual"].ToString(),
                                modelo_actual = dr["modelo_actual"].ToString(),
                                proyectado = dr["proyectado"].ToString(),
                                golpes_totales = dr["golpes_totales"].ToString(),
                                diferencia = dr["diferencia"].ToString(),
                                sph_promedio = dr["sph_promedio"].ToString(),
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
        public List<graficaModel> Get_proyectado_trf1500_2()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_proyectado_trf1500_2", con);
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
                            new graficaModel
                            {
                                proyectado_pasado = dr["proyectado_pasado"].ToString(),
                                proyectado_actual = dr["proyectado_actual"].ToString(),

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
        /// <summary>
        /// trf 2500
        /// </summary>
        /// <returns></returns>



        [HttpGet]
        public List<actualModel> Get_last_trf2500()
        {
            List<actualModel> dataList = new List<actualModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_last_trf2500", con);
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
                            new actualModel
                            {
                                contador = dr["contador"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                modelo = dr["modelo"].ToString(),
                                spm = dr["spm"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                proyectado = dr["proyectado"].ToString(),
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
        public List<graficaModel> Get_actual_trf2500()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_actual_trf2500", con);
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
                            new graficaModel
                            {
                                fecha = dr["fecha"].ToString(),
                                produccion = dr["produccion"].ToString(),
                                part_number = dr["part_number"].ToString(),

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
        public List<jphModel> Get_jph_trf2500()
        {
            List<jphModel> dataList = new List<jphModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_jph_trf2500", con);
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
                            new jphModel
                            {
                                piezas_modelo_actual = dr["piezas_modelo_actual"].ToString(),
                                modelo_actual = dr["modelo_actual"].ToString(),
                                proyectado = dr["proyectado"].ToString(),
                                golpes_totales = dr["golpes_totales"].ToString(),
                                diferencia = dr["diferencia"].ToString(),
                                sph_promedio = dr["sph_promedio"].ToString(),
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
        public List<graficaModel> Get_proyectado_trf2500()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_proyectado_trf2500", con);
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
                            new graficaModel
                            {
                                proyectado_pasado = dr["proyectado_pasado"].ToString(),
                                proyectado_actual = dr["proyectado_actual"].ToString(),

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
        /// <summary>
        /// stamping
        /// </summary>
        /// <returns></returns>


        [HttpGet]
        public List<actualModel> Get_last_stamping()
        {
            List<actualModel> dataList = new List<actualModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_last_stamping", con);
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
                            new actualModel
                            {
                                //maquina = dr["maquina"].ToString(),
                                contador = dr["contador"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                modelo = dr["modelo"].ToString(),
                                spm = dr["spm"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                proyectado = dr["proyectado"].ToString(),
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
        public List<graficaModel> Get_actual_stamping()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_actual_stamping", con);
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
                            new graficaModel
                            {
                                fecha = dr["fecha"].ToString(),
                                produccion = dr["produccion"].ToString(),
                                part_number = dr["part_number"].ToString(),

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
        public List<jphModel> Get_jph_stamping()
        {
            List<jphModel> dataList = new List<jphModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_jph_stamping", con);
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
                            new jphModel
                            {
                                piezas_modelo_actual = dr["piezas_modelo_actual"].ToString(),
                                modelo_actual = dr["modelo_actual"].ToString(),
                                proyectado = dr["proyectado"].ToString(),
                                golpes_totales = dr["golpes_totales"].ToString(),
                                diferencia = dr["diferencia"].ToString(),
                                sph_promedio = dr["sph_promedio"].ToString(),
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
        public List<graficaModel> Get_proyectado_stamping()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_proyectado_stamping", con);
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
                            new graficaModel
                            {
                                proyectado_pasado = dr["proyectado_pasado"].ToString(),
                                proyectado_actual = dr["proyectado_actual"].ToString(),
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
        /// <summary>
        /// kayasaki 
        /// </summary>
        /// <returns></returns>



        [HttpGet]
        public List<actualModel> Get_last_StampingKayasaki()
        {
            List<actualModel> dataList = new List<actualModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_last_stamping_kayasaki", con);
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
                            new actualModel
                            {
                                contador = dr["contador"].ToString(),
                                numero_parte = dr["numero_parte"].ToString(),
                                modelo = dr["modelo"].ToString(),
                                spm = dr["spm"].ToString(),
                                fecha = dr["fecha"].ToString(),
                                proyectado = dr["proyectado"].ToString(),

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
        public List<graficaModel> Get_actual_stampingKayasaki()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_actual_stamping_kayasaki", con);
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
                            new graficaModel
                            {
                                fecha = dr["fecha"].ToString(),
                                produccion = dr["produccion"].ToString(),
                                part_number = dr["part_number"].ToString(),

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
        public List<jphModel> Get_jph_stamping_kayasaki()
        {
            List<jphModel> dataList = new List<jphModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_jph_stamping_kayasaki", con);
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
                            new jphModel
                            {
                                piezas_modelo_actual = dr["piezas_modelo_actual"].ToString(),
                                modelo_actual = dr["modelo_actual"].ToString(),
                                proyectado = dr["proyectado"].ToString(),
                                golpes_totales = dr["golpes_totales"].ToString(),
                                diferencia = dr["diferencia"].ToString(),
                                sph_promedio = dr["sph_promedio"].ToString(),
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
        public List<graficaModel> Get_proyectado_stamping_kayasaki()
        {
            List<graficaModel> dataList = new List<graficaModel>();
            string connString = this.Configuration.GetConnectionString("YKM");
            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("web_dashboard_proyectado_stamping_kayasaki", con);
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
                            new graficaModel
                            {
                                proyectado_pasado = dr["proyectado_pasado"].ToString(),
                                proyectado_actual = dr["proyectado_actual"].ToString(),

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
        public List<DropdownModel> Get_Modelos_Dropdown()
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
                                nombre = dr["nombre"].ToString()
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
