using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sales.Domain.Abstract;
using Sales.Domain.Entities;
using Sales.WebUI.Infrastructure.Abstract;

namespace Sales.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repository;
        private IAuthProvider authProvider;

        public HomeController(IProductRepository productRepository, IAuthProvider auth)
        {
            this.repository = productRepository;
            this.authProvider = auth;
        }

        public ActionResult Index(string selectedProduct = null)
        {
            Product product = (selectedProduct != null) ?
                repository.Products.FirstOrDefault(x => x.Name == selectedProduct) :
                repository.Products.FirstOrDefault();
            ViewBag.SelectedProduct = product.Name;
            return View(product);
        }


        public PartialViewResult Upload()
        {
           return PartialView();
        }

        public PartialViewResult OrderProcess(string selectedProduct)
        {
            Product product = (selectedProduct != null) ?
                repository.Products.FirstOrDefault(x => x.Name == selectedProduct) :
                repository.Products.FirstOrDefault();
            return PartialView(product);
        }

        public PartialViewResult Login()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Login(User user, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (authProvider.Authenticate(user.Name, user.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }


        

    }
}