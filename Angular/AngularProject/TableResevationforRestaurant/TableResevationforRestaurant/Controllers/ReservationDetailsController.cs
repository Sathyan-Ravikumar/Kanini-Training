using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;
using TableResevationforRestaurant.Repository.reserve;

namespace TableResevationforRestaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationDetailsController : ControllerBase
    {
        private readonly Ireserve _context;

        public ReservationDetailsController(Ireserve context)
        {
            _context = context;
        }

        // GET: api/ReservationDetails
        [HttpGet]
        public async Task<ActionResult<List<ReservationDetail>>> GetReservationDetails()
        {
            return await _context.GetReservationDetails();
        }

        // GET: api/ReservationDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationDetail>> GetReservationDetail(int id)
        {
            return await _context.GetReservationDetail(id);
        }

        // PUT: api/ReservationDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /*[HttpPut("{id}")]
        public async Task<IActionResult> PutReservationDetail(int id, ReservationDetail reservationDetail)
        {
            return await _context.PutReservationDetail(id, reservationDetail);
        }*/

        // POST: api/ReservationDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<List<ReservationDetail>> PostReservationDetail(ReservationDetail reservationDetail)
        {
            return await _context.PostReservationDetail(reservationDetail);
        }

        // DELETE: api/ReservationDetails/5
     /*   [HttpDel/*e("{id}")]
        public async Task<IActionResult> DeleteReservationDetail(int id)
        {
            return await _context.DeleteReservationDetail(id);
        }*/

          }
}
