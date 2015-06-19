using System.Collections.Generic;
using Sales.Domain.Entities;

namespace Sales.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<OptionType> OptionTypes { get; }
        IEnumerable<OptionCategory> OptionCategories { get; }
        IEnumerable<Option> Options { get; }
        IEnumerable<RollSize> RollSizes { get; }
        IEnumerable<SheetSize> SheetSizes { get; }
    }
}
