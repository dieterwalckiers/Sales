using Sales.Domain.Entities;

namespace Sales.Admin.Models
{
    public class OptionViewModel
    {
        private bool sizesVisible = false;

        public Option Option { get; set; }
        public bool SizesVisible { get { return sizesVisible; } set { sizesVisible = value; } }
    }
}