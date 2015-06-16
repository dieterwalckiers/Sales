using Sales.Domain.Entities;
using System.Data.Entity;

namespace Sales.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
