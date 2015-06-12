using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entities
{
    public class OptionCategory
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public IEnumerable<Option> Options { get; set; }
    }
}
