using Microsoft.AspNetCore.Mvc;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.Table_availability
{
    public interface Iavailability
    {
        public Task<List<TableAvailability>> GetTableAvailabilities();
        public Task<TableAvailability> GetTableAvailability(int id);
    }
}
