using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesControllers.Entidades
{
    public class EstudianteCursos
    {
        public string? EstudianteID { get; set; }
        public string? CodigoCurso { get; set; }
        public DateOnly FechaInscripcion { get; set; }
    }
}
