using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ninject;
using Moq;
using Sales.Domain.Abstract;
using Sales.Domain.Entities;
using Sales.Domain.Concrete;
using Sales.WebUI.Infrastructure.Abstract;
using Sales.WebUI.Infrastructure.Concrete;

namespace Sales.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            /*
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product> {
                                new Product { ProductID = 1, Name = "Diasec Classic"},
                                new Product { ProductID = 2, Name = "Diasec \"A la carte\""}
            });
             kernel.Bind<IProductRepository>().ToConstant(mock.Object);
             */

            kernel.Bind<IProductRepository>().To<EFProductRepository>();
            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}