using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sales.Domain.Abstract;
using Sales.Domain.Entities;

namespace Sales.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;

        public HomeController(IProductRepository productRepository) {
            this.repository = productRepository;
        }

        public ActionResult Index(string selectedProduct = null)
        {
            Product product = (selectedProduct != null) ?
                repository.Products.FirstOrDefault(x => x.Name == selectedProduct) :
                repository.Products.FirstOrDefault();
            ViewBag.SelectedProduct = product.Name;
            return View(product);
        }

        public PartialViewResult OrderProcess(string selectedProduct)
        {
            Product product = (selectedProduct != null) ?
                repository.Products.FirstOrDefault(x => x.Name == selectedProduct) :
                repository.Products.FirstOrDefault();
            return PartialView(product);
        }
    }
}