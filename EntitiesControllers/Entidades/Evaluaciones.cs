using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesControllers.Entidades
{
    public class Evaluaciones
    {
        [Key]
        public int EvaluacionID { get; set; }
        public string? CursoCodigo { get; set; }
        public string? Titulo { get; set; }
        public DateOnly FechaPublicacion { get; set; }
    }
}
