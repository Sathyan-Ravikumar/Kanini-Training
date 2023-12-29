using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.FoodCategories
{
    public class CategorySevices : Icategory
    {
        private readonly TableReseravtionContext _dbcontext;

        public CategorySevices(TableReseravtionContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<FoodCategory>> GetFoodCategories()
        {
            return await _dbcontext.FoodCategories.ToListAsync();
        }
        public async Task<FoodCategory> GetFoodCategory(int id)
        {
            var obj = await _dbcontext.FoodCategories.FindAsync(id);
            if (obj == null)
            {
                throw new ArithmeticException("No Data available");
            }
            return obj;
        }
    }
}
