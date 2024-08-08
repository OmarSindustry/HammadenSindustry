using Microsoft.JSInterop;

namespace WebApplication.Models
{
    public class DispositivoModel
    {
        public int dispositivo_id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string direccion_ip { get; set; }
        public int puerto { get; set; }
        public string linea { get; set; }
        public string maquina { get; set; }
        public string conexion { get; set; }

    }
}
