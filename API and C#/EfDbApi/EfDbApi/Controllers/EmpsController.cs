using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EfDbApi.Models;

namespace Relation1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
        private readonly CompanyContext _context;

        public EmpsController(CompanyContext context)
        {
            _context = context;
        }

        // GET: api/Emps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emp>>> GetEmps()
        {
          if (_context.Emps == null)
          {
              return NotFound();
          }
            return await _context.Emps.ToListAsync();
        }

        // GET: api/Emps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emp>> GetEmp(int id)
        {
          if (_context.Emps == null)
          {
              return NotFound();
          }
            var emp = await _context.Emps.FindAsync(id);

            if (emp == null)
            {
                return NotFound();
            }

            return emp;
        }

        // PUT: api/Emps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmp(int id, Emp emp)
        {
            if (id != emp.Empno)
            {
                return BadRequest();
            }

            _context.Entry(emp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpExists(id))
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

        // POST: api/Emps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Emp>> PostEmp(Emp emp)
        {
          if (_context.Emps == null)
          {
              return Problem("Entity set 'CompanyContext.Emps'  is null.");
          }
            _context.Emps.Add(emp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmpExists(emp.Empno))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmp", new { id = emp.Empno }, emp);
        }

        // DELETE: api/Emps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmp(int id)
        {
            if (_context.Emps == null)
            {
                return NotFound();
            }
            var emp = await _context.Emps.FindAsync(id);
            if (emp == null)
            {
                return NotFound();
            }

            _context.Emps.Remove(emp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpExists(int id)
        {
            return (_context.Emps?.Any(e => e.Empno == id)).GetValueOrDefault();
        }
    }
}
