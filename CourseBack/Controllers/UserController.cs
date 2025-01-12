using CourseBack.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EntitiesControllers.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace CourseBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            SesionDTO sesionDTO = new SesionDTO();
            Usuario? response = await _context.Usuario.Where(u => u.Email == loginDTO.Correo && u.Contraseña == loginDTO.Clave).FirstOrDefaultAsync();
            if (response != null)
            {
                sesionDTO.UserID = response.UsuarioID;
                sesionDTO.Nombre=response.NombreUsuario;
                sesionDTO.Correo = response.Email;
                sesionDTO.Rol=response.Rol;
                return Ok(sesionDTO);

            }
            else
            {
                return NotFound();
            }
        }
    }
}
