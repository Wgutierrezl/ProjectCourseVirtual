using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesControllers.Entidades
{
    public class Usuario
    {
        [Key]
        public string? UsuarioID { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Email { get; set; }
        public string? Contraseña { get; set; }
        public string? Rol { get; set; }
    }
}
