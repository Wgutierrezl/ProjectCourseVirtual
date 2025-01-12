using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesControllers.Entidades
{
    public class Respuestas
    {

        [Key]
        public int RespuestaID { get; set; }
        public int IDPregunta { get; set; }
        public string? IDEstudiante { get; set; }
        public string? RespuestaEstudiante { get; set; }
        public int Calificacion { get; set; }
    }
}
