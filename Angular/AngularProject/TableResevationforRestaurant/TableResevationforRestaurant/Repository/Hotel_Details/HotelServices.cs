using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.Hotel_Details
{
    public class HotelServices :IHotel
    {
        private readonly TableReseravtionContext? _dbcontext;

        public HotelServices(TableReseravtionContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<IEnumerable<Hotel>> GetHotels()
        {
            return await _dbcontext.Hotels.ToListAsync();
        }
        public async Task<Hotel> GetHotel(int id)
        {
            var obj = await _dbcontext.Hotels.FindAsync(id);
            if (obj == null)
            {
                throw new ArithmeticException("No Data available");
            }
            return obj;
        }
        public async Task<List<Hotel>> PutHotel(int id, Hotel hotel)
        {
            var obj = await _dbcontext.Hotels.FindAsync(id);
            obj.HotelName = hotel.HotelName;
            obj.Address = hotel.Address;
            obj.Hotelnumber = hotel.Hotelnumber;
            obj.Instalink = hotel.Instalink;
            obj.Facebook = hotel.Facebook;
            obj.Youtube = hotel.Youtube;
            if (obj == null)
            {
                throw new ArithmeticException("No Data Updated");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Hotels.ToListAsync();
        }
        public async Task<List<Hotel>> PostHotel(Hotel hotel)
        {
            var obj = await _dbcontext.Hotels.AddAsync(hotel);
            if (obj == null)
            {
                throw new ArithmeticException("No Data Posted");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Hotels.ToListAsync();
        }
        public async Task<List<Hotel>> DeleteHotel(int id)
        {
            var obj = await _dbcontext.Hotels.FindAsync(id);
            _dbcontext.Hotels.Remove(obj);
            if (obj == null)
            {
                throw new ArithmeticException("No Data has been deleted");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Hotels.ToListAsync();
        }
    }
}
