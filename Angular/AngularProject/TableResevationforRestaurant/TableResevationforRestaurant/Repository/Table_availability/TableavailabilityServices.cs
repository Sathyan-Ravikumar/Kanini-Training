using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.Table_availability
{
    public class TableavailabilityServices : Iavailability
    {
        private readonly TableReseravtionContext _dbcontext;

        public TableavailabilityServices(TableReseravtionContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<TableAvailability>> GetTableAvailabilities()
        {
            return await _dbcontext.TableAvailabilities.ToListAsync();
        }
        public async Task<TableAvailability> GetTableAvailability(int id)
        {
            var obj = await _dbcontext.TableAvailabilities.FindAsync(id);
            if (obj == null)
            {
                throw new ArithmeticException("No Data available");
            }
            return obj;
        }
    }
}
