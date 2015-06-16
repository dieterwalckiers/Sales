using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entities
{
    public class OptionType
    {
        public int OptionTypeID { get; set; }
        public string Name { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        public virtual ICollection<OptionCategory> OptionCategories { get; set; }
    }
}
