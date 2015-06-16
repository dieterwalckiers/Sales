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
        
        public int OptionCategoryID { get; set; }
        public virtual OptionCategory OptionCategory { get; set; }

        public virtual ICollection<RollSize> RollSizes { get; set; }
        public virtual ICollection<SheetSize> SheetSizes { get; set; }
    }
}
