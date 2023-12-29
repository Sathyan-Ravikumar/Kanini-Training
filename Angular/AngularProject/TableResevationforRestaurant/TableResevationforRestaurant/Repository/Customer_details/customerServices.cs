using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.Customer_details
{
    public class customerServices : Icustomers
    {
        private readonly TableReseravtionContext _dbcontext;

        public customerServices(TableReseravtionContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<CustomerDetail>> GetCustomerDetails()
        {
            return await _dbcontext.CustomerDetails.ToListAsync();
        }
        public async Task<CustomerDetail> GetCustomerDetail(int id)
        {
            var obj = await _dbcontext.CustomerDetails.FindAsync(id);
            if (obj == null)
            {
                throw new ArithmeticException("No Data available");
            }
            return obj;
        }
        public async Task<List<CustomerDetail>> PostCustomerDetail(CustomerDetail customerDetail)
        {
            var obj =(from c in _dbcontext.CustomerDetails
                             join r in _dbcontext.ReservationDetails
                             on c.CustomerId equals r.CustomerId
                             where r.Customer == customerDetail
                             select new BufferTable
                             {
                                 CustomerName = c.CustomerName,
                                 MobileNumber=c.MobileNumber,
                                 NumberOfPeople=r.NumberOfPeople,
                                 Slot=r.Slot,
                                 ReserveDate=r.ReserveDate
                             });
            
            if (obj == null)
            {
                throw new ArithmeticException("No Data Posted");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.CustomerDetails.ToListAsync();
        }
    }
}
