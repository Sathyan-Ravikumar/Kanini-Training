using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;
using TableResevationforRestaurant.Repository.Table_details;

namespace TableResevationforRestaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly Itable _context;

        public TablesController(Itable context)
        {
            _context = context;
        }

        // GET: api/Tables
        [HttpGet]
        public async Task<ActionResult<List<Table>>> GetTables()
        {
            return await _context.GetTables();
        }
        // GET: api/Tables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Table>> GetTable(int id)
        {
            return await _context.GetTable(id);
        }

        // PUT: api/Tables/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<List<Table>> PutTable(int id, Table table)
        {
            return await _context.PutTable(id,table);
        }

        // POST: api/Tables
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List<Table>>> PostTable(Table table)
        {
            return await _context.PostTable(table);
        }

        // DELETE: api/Tables/5
        [HttpDelete("{id}")]
        public async Task<List<Table>> DeleteTable(int id)
        {
            return await _context.DeleteTable(id);
        }

        
    }
}
