using Microsoft.AspNetCore.Mvc;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.Hotel_Details
{
    public interface IHotel
    {
        public Task<IEnumerable<Hotel>> GetHotels();
        public Task<Hotel> GetHotel(int id);
        public Task<List<Hotel>> PutHotel(int id, Hotel hotel);
        public Task<List<Hotel>> PostHotel(Hotel hotel);
        public Task<List<Hotel>> DeleteHotel(int id);
       
    }
}
