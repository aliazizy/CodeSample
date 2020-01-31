using Microsoft.EntityFrameworkCore;
using MoneyTransfer.Models;

namespace MoneyTransfer.DataAccess
{
    public class MoneyTransferDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public MoneyTransferDbContext(DbContextOptions<MoneyTransferDbContext> options) : base(options)
        {
        }
        public MoneyTransferDbContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Initial Catalog = MTDb; MultipleActiveResultSets = true; User ID = sa; Password =MyP@ssw0rd#");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
