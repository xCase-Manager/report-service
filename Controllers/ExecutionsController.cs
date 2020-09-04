using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XCaseManager.Messenger.Models;

namespace Messenger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExecutionsController : ControllerBase
    {
        private readonly ExecutionDBContext _context;

        public ExecutionsController(ExecutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Executions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Execution>>> GetExecutions()
        {
            return await _context.Executions.ToListAsync();
        }

        // GET: api/Executions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Execution>> GetExecution(long id)
        {
            var execution = await _context.Executions.FindAsync(id);

            if (execution == null)
            {
                return NotFound();
            }

            return execution;
        }

        // PUT: api/Executions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExecution(long id, Execution execution)
        {
            if (id != execution.Id)
            {
                return BadRequest();
            }

            _context.Entry(execution).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExecutionExists(id))
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

        // POST: api/Executions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Execution>> PostExecution(Execution execution)
        {
            _context.Executions.Add(execution);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetExecution), new { id = execution.Id }, execution);
        }

        // DELETE: api/Executions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Execution>> DeleteExecution(long id)
        {
            var execution = await _context.Executions.FindAsync(id);
            if (execution == null)
            {
                return NotFound();
            }

            _context.Executions.Remove(execution);
            await _context.SaveChangesAsync();

            return execution;
        }

        private bool ExecutionExists(long id)
        {
            return _context.Executions.Any(e => e.Id == id);
        }
    }
}
