using Microsoft.EntityFrameworkCore;


namespace Relation2.Models
{
    public class CompanyContextCF : DbContext
    {
        public CompanyContextCF(DbContextOptions<CompanyContextCF> options) : base(options)
        {
            
        }
        public DbSet<Dept> Dept { get; set; }

        public DbSet<Emp> Emp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
    
}
