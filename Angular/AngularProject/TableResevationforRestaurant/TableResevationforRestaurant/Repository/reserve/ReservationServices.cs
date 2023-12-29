using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.reserve
{
    public class ReservationServices:Ireserve
    {
        private readonly TableReseravtionContext? _dbcontext;

        public ReservationServices(TableReseravtionContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<ReservationDetail>> GetReservationDetails()
        {
            return await _dbcontext.ReservationDetails.ToListAsync();
        }
        public async Task<ReservationDetail> GetReservationDetail(int id)
        {

            var obj = await _dbcontext.ReservationDetails.FindAsync(id);
            if (obj == null)
            {
                throw new ArithmeticException("No Data available");
            }
            return obj;
        }
        public async Task<List<ReservationDetail>> PostReservationDetail(ReservationDetail reservationDetail)
        {
            var obj = await _dbcontext.ReservationDetails.AddAsync(reservationDetail);
            if (obj == null)
            {
                throw new ArithmeticException("No Data Posted");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.ReservationDetails.ToListAsync();
        }
    }
}
