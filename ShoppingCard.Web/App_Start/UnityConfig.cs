using System.Collections.Generic;
using System.Web.Mvc;
using Moq;
using ShoppingCart.Core.Domain;
using ShoppingCart.Core.Facade;
using Unity;
using Unity.Mvc5;

namespace ShoppingCard.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            var mockProducts = new Mock<IProductsRepository>();
            mockProducts.Setup(m => m.FindAll()).Returns(new List<Product>
            {
                new Product {ProductId = "P1000", Name = "Café", PhotoFile = "cafe.jpg", UnitPrice = 1.5M},
                new Product {ProductId = "P2000", Name = "Thé", PhotoFile = "The.jpg", UnitPrice = 1.5M},
                new Product {ProductId = "P3000", Name = "Chocoloat", PhotoFile = "Chocoloat.jpg", UnitPrice = 1.5M},
                new Product {ProductId = "P4000", Name = "Gateau", PhotoFile = "Gateau.jpg", UnitPrice = 1.5M},
            });
            container.RegisterInstance(mockProducts.Object);
          
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}