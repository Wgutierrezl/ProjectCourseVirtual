using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CourseBack.Data;
using EntitiesControllers.Entidades;

namespace CourseBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteCursosController : ControllerBase
    {
        private readonly DataContext _context;

        public EstudianteCursosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/EstudianteCursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstudianteCursos>>> GetEstudianteCursos()
        {
            return await _context.EstudianteCursos.ToListAsync();
        }

        // GET: api/EstudianteCursos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstudianteCursos>> GetEstudianteCursos(string id,string id2)
        {
            var estudianteCursos = await _context.EstudianteCursos.FindAsync(id,id2);

            if (estudianteCursos == null)
            {
                return NotFound();
            }

            return estudianteCursos;
        }

        // PUT: api/EstudianteCursos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstudianteCursos(string id, string id2,EstudianteCursos estudianteCursos)
        {
            if (id != estudianteCursos.EstudianteID || id2!=estudianteCursos.CodigoCurso)
            {
                return BadRequest();
            }

            _context.Entry(estudianteCursos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudianteCursosExists(id,id2))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EstudianteCursos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstudianteCursos>> PostEstudianteCursos(EstudianteCursos estudianteCursos)
        {
            _context.EstudianteCursos.Add(estudianteCursos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EstudianteCursosExists(estudianteCursos.EstudianteID,estudianteCursos.CodigoCurso))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEstudianteCursos", new { id = estudianteCursos.EstudianteID }, estudianteCursos);
        }

        // DELETE: api/EstudianteCursos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudianteCursos(string id,string id2)
        {
            var estudianteCursos = await _context.EstudianteCursos.FindAsync(id,id2);
            if (estudianteCursos == null)
            {
                return NotFound();
            }

            _context.EstudianteCursos.Remove(estudianteCursos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstudianteCursosExists(string id,string id2)
        {
            return _context.EstudianteCursos.Any(e => e.EstudianteID == id && e.CodigoCurso==id2);
        }
    }
}
