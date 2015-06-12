using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entities
{
    public class OptionType
    {
        public int OptionTypeID { get; set; }
        public string Name { get; set; }

        public IEnumerable<OptionCategory> OptionCategories { get; set; }
    }
}
