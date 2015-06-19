using Sales.Domain.Entities;
using System.Data.Entity;

namespace Sales.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<OptionType> OptionTypes { get; set; }
        public DbSet<OptionCategory> OptionCategories { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<RollSize> RollSizes { get; set; }
        public DbSet<SheetSize> SheetSizes { get; set; }
    }
}
