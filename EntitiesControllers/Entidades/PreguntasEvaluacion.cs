using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesControllers.Entidades
{
    public class PreguntasEvaluacion
    {
        [Key]
        public int PreguntaID { get; set; }
        public int IDEvaluacion { get; set; }
        public string? Pregunta { get; set; }
        public string? TipoPregunta { get; set; }
    }
}
