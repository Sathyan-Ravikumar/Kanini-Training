using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.Table_details
{
    public class TableServices : Itable
    {
        private readonly TableReseravtionContext _dbcontext;

        public TableServices(TableReseravtionContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Table>> GetTables()
        {
            return await _dbcontext.Tables.ToListAsync();
        }
        public async Task<Table> GetTable(int id)
        {
            var obj = await _dbcontext.Tables.FindAsync(id);
            if (obj == null)
            {
                throw new ArithmeticException("No Data available");
            }
            return obj;
        }
        public async Task<List<Table>> PutTable(int id, Table table)
        {
            var obj = await _dbcontext.Tables.FindAsync(id);
            obj.TableNumber = table.TableNumber;
            obj.SeatingCapacity = table.SeatingCapacity;

            if (obj == null)
            {
                throw new ArithmeticException("No Data Updated");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Tables.ToListAsync();
        }
        public async Task<List<Table>> PostTable(Table table)
        {
            var obj = await _dbcontext.Tables.AddAsync(table);
            if (obj == null)
            {
                throw new ArithmeticException("No Data Posted");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Tables.ToListAsync();
        }
        public async Task<List<Table>> DeleteTable(int id)
        {
            var obj = await _dbcontext.Tables.FindAsync(id);
            _dbcontext.Tables.Remove(obj);
            if (obj == null)
            {
                throw new ArithmeticException("No Data has been deleted");
            }
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Tables.ToListAsync();
        }
    }
}
