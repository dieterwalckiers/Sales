using Sales.Domain.Abstract;
using Sales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sales.Admin.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;

        public HomeController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ActionResult Index()
        {
            return View(repository.Products);
        }

        public PartialViewResult ManageProducts()
        {
            return PartialView(repository.Products);
        }

        public PartialViewResult CreateProduct()
        {
            return PartialView();
        }

        public PartialViewResult GetProductContent(int productId)
        {

            Product product = repository.Products.FirstOrDefault(p => p.ProductID == productId);

            return PartialView("Product", product);
        }

        public PartialViewResult GetOptionTypeContent(int optionTypeId)
        {
            OptionType optionType = repository.OptionTypes.FirstOrDefault(o => o.OptionTypeID == optionTypeId);
            return PartialView("OptionType", optionType);
        }

        public ActionResult GetRollSizeContent(int optionId, bool sizesOpen = false) 
        {
            ICollection<RollSize> rollSizes = repository.Options.FirstOrDefault(o => o.OptionID == optionId).RollSizes;
            ViewBag.sizesOpen = !sizesOpen;
            if (sizesOpen)
            {
                return new EmptyResult();
            }
            else
            {
                return PartialView("RollSizes", rollSizes); 
            } 
        }

        public ActionResult GetSheetSizeContent(int optionId, bool sizesOpen = false)
        {
            ICollection<SheetSize> sheetSizes = repository.Options.FirstOrDefault(o => o.OptionID == optionId).SheetSizes;
            TempData["sizesOpen"] = !sizesOpen;
            if (sizesOpen)
            {
                return new EmptyResult(); 
            }
            else
            {
                return PartialView("SheetSizes", sheetSizes);
            } 
        }
    }
}