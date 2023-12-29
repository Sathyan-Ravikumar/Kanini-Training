using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.product_details
{
    public class productServices :Iproduct
    {
        private readonly TableReseravtionContext _dbcontext;

        public productServices(TableReseravtionContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Product>> GetProducts()
        {
            return await _dbcontext.Products.ToListAsync();
        }
        public async Task<Product> GetProduct(int id)
        {
            var obj = await _dbcontext.Products.FindAsync(id);
            if (obj == null)
            {
                throw new ArithmeticException("No Data available");
            }
            return obj;
        }
        public async Task<List<Product>> PutProduct(int id, Product product)
        {
            var obj = await _dbcontext.Products.FindAsync(id);
            obj.Categoryid = product.Categoryid;
            obj.Dishname = product.Dishname;
            obj.Cost = product.Cost;
            obj.Images = product.Images;
            if (obj == null)
            {
                throw new ArithmeticException("No Data Updated");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Products.ToListAsync();
        }
        public async Task<List<Product>> PostProduct(Product product)
        {
            var obj = await _dbcontext.Products.AddAsync(product);
            if (obj == null)
            {
                throw new ArithmeticException("No Data Posted");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Products.ToListAsync();
        }
        public async Task<List<Product>> DeleteProduct(int id)
        {
            var obj = await _dbcontext.Products.FindAsync(id);
            _dbcontext.Products.Remove(obj);
            if (obj == null)
            {
                throw new ArithmeticException("No Data has been deleted");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Products.ToListAsync();
        }
        public async Task<List<Product>> GetStarters(int id)
        {
            var obj = await  _dbcontext.Products.Where(x => x.Categoryid == id).ToListAsync();
            if (obj.Count < 1)
            {
                throw new ArithmeticException("No Data Found");
            }
            return obj;
        }
    }
}
