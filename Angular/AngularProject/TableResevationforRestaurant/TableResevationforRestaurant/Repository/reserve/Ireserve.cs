using Microsoft.AspNetCore.Mvc;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.reserve
{
    public interface Ireserve
    {
        public Task<List<ReservationDetail>> GetReservationDetails();
        public Task<ReservationDetail> GetReservationDetail(int id);
        public Task<List<ReservationDetail>> PostReservationDetail(ReservationDetail reservationDetail);
    }
}
