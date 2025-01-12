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
    public class EvaluacionesController : ControllerBase
    {
        private readonly DataContext _context;

        public EvaluacionesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Evaluaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Evaluaciones>>> GetEvaluaciones()
        {
            return await _context.Evaluaciones.ToListAsync();
        }

        // GET: api/Evaluaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Evaluaciones>> GetEvaluaciones(int id)
        {
            var evaluaciones = await _context.Evaluaciones.FindAsync(id);

            if (evaluaciones == null)
            {
                return NotFound();
            }

            return evaluaciones;
        }

        // PUT: api/Evaluaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvaluaciones(int id, Evaluaciones evaluaciones)
        {
            if (id != evaluaciones.EvaluacionID)
            {
                return BadRequest();
            }

            _context.Entry(evaluaciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvaluacionesExists(id))
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

        // POST: api/Evaluaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Evaluaciones>> PostEvaluaciones(Evaluaciones evaluaciones)
        {
            _context.Evaluaciones.Add(evaluaciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvaluaciones", new { id = evaluaciones.EvaluacionID }, evaluaciones);
        }

        // DELETE: api/Evaluaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvaluaciones(int id)
        {
            var evaluaciones = await _context.Evaluaciones.FindAsync(id);
            if (evaluaciones == null)
            {
                return NotFound();
            }

            _context.Evaluaciones.Remove(evaluaciones);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EvaluacionesExists(int id)
        {
            return _context.Evaluaciones.Any(e => e.EvaluacionID == id);
        }
    }
}
