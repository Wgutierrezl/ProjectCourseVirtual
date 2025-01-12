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
    public class PreguntasEvaluacionsController : ControllerBase
    {
        private readonly DataContext _context;

        public PreguntasEvaluacionsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PreguntasEvaluacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PreguntasEvaluacion>>> GetpreguntasEvaluacion()
        {
            return await _context.preguntasEvaluacion.ToListAsync();
        }

        // GET: api/PreguntasEvaluacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PreguntasEvaluacion>> GetPreguntasEvaluacion(int id)
        {
            var preguntasEvaluacion = await _context.preguntasEvaluacion.FindAsync(id);

            if (preguntasEvaluacion == null)
            {
                return NotFound();
            }

            return preguntasEvaluacion;
        }

        // PUT: api/PreguntasEvaluacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPreguntasEvaluacion(int id, PreguntasEvaluacion preguntasEvaluacion)
        {
            if (id != preguntasEvaluacion.PreguntaID)
            {
                return BadRequest();
            }

            _context.Entry(preguntasEvaluacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PreguntasEvaluacionExists(id))
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

        // POST: api/PreguntasEvaluacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PreguntasEvaluacion>> PostPreguntasEvaluacion(PreguntasEvaluacion preguntasEvaluacion)
        {
            _context.preguntasEvaluacion.Add(preguntasEvaluacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPreguntasEvaluacion", new { id = preguntasEvaluacion.PreguntaID }, preguntasEvaluacion);
        }

        // DELETE: api/PreguntasEvaluacions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreguntasEvaluacion(int id)
        {
            var preguntasEvaluacion = await _context.preguntasEvaluacion.FindAsync(id);
            if (preguntasEvaluacion == null)
            {
                return NotFound();
            }

            _context.preguntasEvaluacion.Remove(preguntasEvaluacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PreguntasEvaluacionExists(int id)
        {
            return _context.preguntasEvaluacion.Any(e => e.PreguntaID == id);
        }
    }
}
