using Microsoft.AspNetCore.Mvc;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.Customer_details
{
    public interface Icustomers
    {
        public Task<List<CustomerDetail>> GetCustomerDetails();
        public Task<CustomerDetail> GetCustomerDetail(int id);
        public Task<List<CustomerDetail>> PostCustomerDetail(CustomerDetail customerDetail);
    }
}
