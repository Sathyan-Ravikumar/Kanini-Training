using Microsoft.AspNetCore.Mvc;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.product_details
{
    public interface Iproduct
    {
        public Task<List<Product>> GetProducts();
        public Task<Product> GetProduct(int id);
        public  Task<List<Product>> PutProduct(int id, Product product);
        public Task<List<Product>> PostProduct(Product product);
        public Task<List<Product>> DeleteProduct(int id);
        public  Task<List<Product>> GetStarters(int id);
    }
}
