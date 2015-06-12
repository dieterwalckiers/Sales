using System.Collections.Generic;
using Sales.Domain.Entities;

namespace Sales.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
