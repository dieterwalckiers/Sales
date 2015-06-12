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

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(repository.Products);
        }
    }
}