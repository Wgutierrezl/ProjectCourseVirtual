using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesControllers.Entidades
{
    public class Cursos
    {
        [Key]
        public string? CursoID { get; set; }
        public string? InstructorID { get; set; }
        public string? NombreCurso { get; set; }
        public string? Descripcion { get; set; }
        public int Duracion { get; set; }
    }
}
