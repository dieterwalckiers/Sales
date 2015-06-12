using Sales.Domain.Abstract;
using Sales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sales.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository repository;

        public NavController(IProductRepository rep)
        {
            repository = rep;
        }

        public PartialViewResult Menu(string selectedProduct = null)
        {
            ViewBag.SelectedProduct = selectedProduct;

            IEnumerable<string> productNames = repository.Products.Select(x => x.Name);
            return PartialView(productNames);
        }
    }
}