using Sales.Domain.Abstract;
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
            return View(repository.Products.FirstOrDefault());
        }
    }
}