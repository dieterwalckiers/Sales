using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entities
{
    public class RollSize
    {
        public int RollSizeID { get; set; }
        public string Name { get; set; }
        public int OptionID { get; set; }
        public virtual Option Option { get; set; }
    }
}
