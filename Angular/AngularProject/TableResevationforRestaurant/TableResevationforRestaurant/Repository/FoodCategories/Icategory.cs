using Microsoft.AspNetCore.Mvc;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.FoodCategories
{
    public interface Icategory
    {
        public  Task<List<FoodCategory>> GetFoodCategories();
        public Task<FoodCategory> GetFoodCategory(int id);
    }
}
