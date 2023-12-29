using Microsoft.AspNetCore.Mvc;
using TableResevationforRestaurant.Models;

namespace TableResevationforRestaurant.Repository.Table_details
{
    public interface Itable
    {
        public Task<List<Table>> GetTables();
        public  Task<Table> GetTable(int id);
        public  Task<List<Table>> PutTable(int id, Table table);
        public  Task<List<Table>> PostTable(Table table);
        public Task<List<Table>> DeleteTable(int id);
    }
}
