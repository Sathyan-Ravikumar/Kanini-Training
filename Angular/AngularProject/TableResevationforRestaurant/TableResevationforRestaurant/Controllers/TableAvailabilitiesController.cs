using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;
using TableResevationforRestaurant.Repository.Table_availability;

namespace TableResevationforRestaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableAvailabilitiesController : ControllerBase
    {
        private readonly Iavailability _context;

        public TableAvailabilitiesController(Iavailability context)
        {
            _context = context;
        }

        // GET: api/TableAvailabilities
        [HttpGet]
        public async Task<ActionResult<List<TableAvailability>>> GetTableAvailabilities()
        {
            return await _context.GetTableAvailabilities();
        }

        // GET: api/TableAvailabilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TableAvailability>> GetTableAvailability(int id)
        {
            return await _context.GetTableAvailability(id);
        }
/*
        // PUT: api/TableAvailabilities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTableAvailability(int id, TableAvailability tableAvailability)
        {
            if (id != tableAvailability.AvailabilityId)
            {
                return BadRequest();
            }

            _context.Entry(tableAvailability).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableAvailabilityExists(id))
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

        // POST: api/TableAvailabilities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TableAvailability>> PostTableAvailability(TableAvailability tableAvailability)
        {
          if (_context.TableAvailabilities == null)
          {
              return Problem("Entity set 'TableReseravtionContext.TableAvailabilities'  is null.");
          }
            _context.TableAvailabilities.Add(tableAvailability);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTableAvailability", new { id = tableAvailability.AvailabilityId }, tableAvailability);
        }

        // DELETE: api/TableAvailabilities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTableAvailability(int id)
        {
            if (_context.TableAvailabilities == null)
            {
                return NotFound();
            }
            var tableAvailability = await _context.TableAvailabilities.FindAsync(id);
            if (tableAvailability == null)
            {
                return NotFound();
            }

            _context.TableAvailabilities.Remove(tableAvailability);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
*/
    }
}
