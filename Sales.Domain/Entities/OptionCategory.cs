using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entities
{
    public class OptionCategory
    {
        public int OptionCategoryID { get; set; }
        public string Name { get; set; }

        public int OptionTypeID { get; set; }
        public virtual OptionType OptionType { get; set; }

        public virtual ICollection<Option> Options { get; set; }
    }
}
