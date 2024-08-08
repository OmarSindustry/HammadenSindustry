using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.Repository;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration;
        public HomeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

    

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Estacion2500T()
        {
            return View();
        }
        public IActionResult Estacion1500T1()
        {
            return View();
        }
        public IActionResult Estacion1500T2()
        {
            return View();
        }
        public IActionResult EstacionHS1()
        {
            return View();
        }
        public IActionResult EstacionHS2()
        {
            return View();
        }






        /// <summary>
        /// trf 1500 1 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult Get_last_trf1500_1_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_last_trf1500_1();
            return Json(output);
        }
        [HttpGet]
        public JsonResult Get_actual_trf1500_1_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_actual_trf1500_1();
            return Json(output);
        }
        [HttpGet]
        public JsonResult Get_proyectado_trf1500_1_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_proyectado_trf1500_1();
            return Json(output);
        }
        [HttpGet]
        public JsonResult Get_jph_trf1500_1_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_jph_trf1500_1();
            return Json(output);
        }




        /// <summary>
        /// trf 1500 2
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult Get_last_trf1500_2_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_last_trf1500_2();
            return Json(output);
        }
        [HttpGet]
        public JsonResult Get_actual_trf1500_2_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_actual_trf1500_2();
            return Json(output);
        }
        [HttpGet]
        public JsonResult Get_jph_trf1500_2_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_jph_trf1500_2();
            return Json(output);
        }

        [HttpGet]
        public JsonResult Get_proyectado_trf1500_2_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_proyectado_trf1500_2();
            return Json(output);
        }


        /// <summary>
        /// tref 2500 
        /// </summary>
        /// <returns></returns>

        public JsonResult Get_last_trf2500_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_last_trf2500();
            return Json(output);
        }

        [HttpGet]
        public JsonResult Get_actual_trf2500_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_actual_trf2500();
            return Json(output);
        }
        [HttpGet]
        public JsonResult Get_jph_trf2500_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_jph_trf2500();
            return Json(output);
        }


        [HttpGet]
        public JsonResult Get_proyectado_trf2500_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_proyectado_trf2500();
            return Json(output);
        }


        /// <summary>
        /// stamping  
        /// </summary>
        /// <returns></returns>


        [HttpGet]
        public JsonResult Get_last_Stamping_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_last_stamping();
            return Json(output);
        }

        [HttpGet]
        public JsonResult Get_actual_stamping_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_actual_stamping();
            return Json(output);
        }
        [HttpGet]
        public JsonResult Get_jph_stamping_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_jph_stamping();
            return Json(output);
        }


        [HttpGet]
        public JsonResult Get_proyectado_stamping_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_proyectado_stamping();
            return Json(output);
        }





        /// <summary>
        /// kayasaki
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public JsonResult Get_last_StampingKayasaki_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_last_StampingKayasaki();
            return Json(output);
        }

        [HttpGet]
        public JsonResult Get_actual_stamping_kayasaki_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_actual_stampingKayasaki();
            return Json(output);
        }
        [HttpGet]
        public JsonResult Get_jph_stamping_kayasaki_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_jph_stamping_kayasaki();
            return Json(output);
        }

        [HttpGet]
        public JsonResult Get_proyectado_stamping_kayasaki_Json()
        {
            homeRepo EmpRepo = new homeRepo(Configuration);
            var output = EmpRepo.Get_proyectado_stamping_kayasaki();
            return Json(output);
        }



    }
}
