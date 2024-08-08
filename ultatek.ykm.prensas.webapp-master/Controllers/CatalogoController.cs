using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication.Repository;

namespace WebApplication.Controllers
{
    public class CatalogoController : Controller
    {

        private IConfiguration Configuration;

        public CatalogoController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        public IActionResult Lineas()
        {
            return View();
        }
        
        public IActionResult Dispositivos()
        {
            return View();
        }
        
        public IActionResult Maquinas()
        {
            return View();
        }
        public IActionResult Conexiones()
        {
            return View();
        }

        public IActionResult Modelos()
        {
            return View();
        }

        public IActionResult Horarios()
        {
            return View();
        }
        public IActionResult Proyectado()
        {
            return View();
        }


        [HttpGet]
        public JsonResult get_lineas_Json()
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_lineas();
            return Json(output);
        }

        [HttpGet]
        public JsonResult edit_proyectado_trf1500_1_Json(
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
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.edit_proyectado_trf1500_1( num_parte_1,  proyectado_1,
             num_parte_2,  proyectado_2,
             num_parte_3,  proyectado_3,
             num_parte_4,  proyectado_4,
             num_parte_5,  proyectado_5,
             num_parte_6,  proyectado_6,
             num_parte_7,  proyectado_7,
             num_parte_8,  proyectado_8,
             num_parte_9,  proyectado_9,
             num_parte_10,  proyectado_10,
             num_parte_11,  proyectado_11,
             num_parte_12,  proyectado_12);
            return Json(output);
        }


        [HttpGet]
        public JsonResult edit_proyectado_trf1500_2_Json(
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
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.edit_proyectado_trf1500_2(num_parte_1, proyectado_1,
             num_parte_2, proyectado_2,
             num_parte_3, proyectado_3,
             num_parte_4, proyectado_4,
             num_parte_5, proyectado_5,
             num_parte_6, proyectado_6,
             num_parte_7, proyectado_7,
             num_parte_8, proyectado_8,
             num_parte_9, proyectado_9,
             num_parte_10, proyectado_10,
             num_parte_11, proyectado_11,
             num_parte_12, proyectado_12);
            return Json(output);
        }


        [HttpGet]
        public JsonResult edit_proyectado_trf2500_Json(
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
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.edit_proyectado_trf2500(num_parte_1, proyectado_1,
             num_parte_2, proyectado_2,
             num_parte_3, proyectado_3,
             num_parte_4, proyectado_4,
             num_parte_5, proyectado_5,
             num_parte_6, proyectado_6,
             num_parte_7, proyectado_7,
             num_parte_8, proyectado_8,
             num_parte_9, proyectado_9,
             num_parte_10, proyectado_10,
             num_parte_11, proyectado_11,
             num_parte_12, proyectado_12);
            return Json(output);
        }


        [HttpGet]
        public JsonResult edit_proyectado_stamping_Json(
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
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.edit_proyectado_stamping(num_parte_1, proyectado_1,
             num_parte_2, proyectado_2,
             num_parte_3, proyectado_3,
             num_parte_4, proyectado_4,
             num_parte_5, proyectado_5,
             num_parte_6, proyectado_6,
             num_parte_7, proyectado_7,
             num_parte_8, proyectado_8,
             num_parte_9, proyectado_9,
             num_parte_10, proyectado_10,
             num_parte_11, proyectado_11,
             num_parte_12, proyectado_12);
            return Json(output);
        }


        [HttpGet]
        public JsonResult edit_proyectado_stamping_kayasaki_Json(
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
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.edit_proyectado_stamping_kayasaki(num_parte_1, proyectado_1,
             num_parte_2, proyectado_2,
             num_parte_3, proyectado_3,
             num_parte_4, proyectado_4,
             num_parte_5, proyectado_5,
             num_parte_6, proyectado_6,
             num_parte_7, proyectado_7,
             num_parte_8, proyectado_8,
             num_parte_9, proyectado_9,
             num_parte_10, proyectado_10,
             num_parte_11, proyectado_11,
             num_parte_12, proyectado_12);
            return Json(output);
        }


        [HttpGet]
        public JsonResult get_proyectado_Json()
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_proyectado();
            return Json(output);
        } 

        [HttpGet]
        public JsonResult add_linea_Json( string nombre)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.add_linea(   nombre);
            return Json(output);
        }            
        
        [HttpGet]
        public JsonResult edit_linea_Json(int id, string nombre)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.edit_linea( id,  nombre);
            return Json(output);
        }


        [HttpGet]
        public JsonResult get_maquinas_Json()
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_maquinas();
            return Json(output);
        }

        [HttpGet]
        public JsonResult add_maquina_Json(string nombre)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.add_maquina(nombre);
            return Json(output);
        }

        [HttpGet]
        public JsonResult edit_maquina_Json(int id, string nombre)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.edit_maquina(id, nombre);
            return Json(output);
        }

        [HttpGet]
        public JsonResult get_conexiones_Json()
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_conexiones();
            return Json(output);
        }

        [HttpGet]
        public JsonResult add_conexion_Json(string nombre)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.add_conexion(nombre);
            return Json(output);
        }

        [HttpGet]
        public JsonResult edit_conexion_Json(int id, string nombre)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.edit_conexion(id, nombre);
            return Json(output);
        }

        [HttpGet]
        public JsonResult get_dispositivos_Json(int id, string nombre)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_dispositivos();
            return Json(output);
        }

        [HttpGet]
        public JsonResult add_dispositivo_Json( string nombre, string descripcion, string direccion, int puerto, int linea_id, int maquina_id, int conexion_id )
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.add_dispositivo( nombre,  descripcion,  direccion,  puerto,  linea_id,  maquina_id,  conexion_id );
            return Json(output);
        }
        [HttpGet]
        public JsonResult edit_dispositivo_Json(int id, string nombre, string descripcion, string direccion, int puerto, int linea_id, int maquina_id, int conexion_id )
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
                var output = EmpRepo.edit_dispositivo(id, nombre,  descripcion,  direccion,  puerto,  linea_id,  maquina_id,  conexion_id );
            return Json(output);
        }






        [HttpGet]
        public JsonResult get_modelos_Json(int id)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_modelos(id);
            return Json(output);
        }

        [HttpGet]
        public JsonResult edit_modelo_Json(int id, string part_number, int piezas_golpe, int spm)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.edit_modelo(id, part_number, piezas_golpe, spm);
            return Json(output);
        }


        [HttpGet]
        public JsonResult get_conexiones_dropdown_Json()
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_conexiones_dropdown();
            return Json(output);
        }

        [HttpGet]
        public JsonResult get_lineas_dropdown_Json()
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_lineas_dropdown();
            return Json(output);
        }
        [HttpGet]
        public JsonResult get_maquinas_dropdown_Json()
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_maquinas_dropdown();
            return Json(output);
        }


        [HttpGet]
        public JsonResult get_modelos_dropdown_Json()
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_modelos_dropdown();
            return Json(output);
        }



        [HttpGet]
        public JsonResult get_horarios_json()
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.get_horarios();
            return Json(output);
        }

        [HttpGet]
        public JsonResult edit_horarios_json(int horario_id, string nombre, string horario_inicio, string horario_fin)
        {
            catalogoRepo EmpRepo = new catalogoRepo(Configuration);
            var output = EmpRepo.Edit_Horario(horario_id, nombre, horario_inicio, horario_fin);
            return Json(output);
        }
    }
}
