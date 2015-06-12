using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entities
{
    public class Option
    {
        public int OptionID { get; set; }
        public string Name { get; set; }

        public IEnumerable<RollSize> RollSizes { get; set; }
        public IEnumerable<SheetSize> SheetSizes { get; set; }
    }
}
