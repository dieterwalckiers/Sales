using Sales.Domain.Abstract;
using Sales.Domain.Entities;
using System.Collections.Generic;

namespace Sales.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products { get { return context.Products; }}
        public IEnumerable<OptionType> OptionTypes { get { return context.OptionTypes; } }
        public IEnumerable<OptionCategory> OptionCategories { get { return context.OptionCategories; } }
        public IEnumerable<Option> Options { get { return context.Options; } }
        public IEnumerable<RollSize> RollSizes { get { return context.RollSizes; } }
        public IEnumerable<SheetSize> SheetSizes { get { return context.SheetSizes; } }
    }
}