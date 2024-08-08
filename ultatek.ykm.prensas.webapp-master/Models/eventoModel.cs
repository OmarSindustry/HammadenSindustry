using Microsoft.AspNetCore.Mvc.Formatters;

namespace WebApplication.Models
{
    public class eventoModel
    {
        public int id { get; set; }
        public string maquina { get; set; }
        public int tiempo_produccion { get; set; }
        public int tiempo_falla { get; set; }
        public int tiempo_detenido { get; set; }
        public int contador_ok { get; set; }
        public int contador_ng { get; set; }
        public int totales { get; set; }
        public string fecha_evento { get; set; }
        public string resultado { get; set; }
    }
}
