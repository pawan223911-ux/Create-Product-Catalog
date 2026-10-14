using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using Demo.Models;

namespace Demo.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var products = GetProducts();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = GetProducts()
                .FirstOrDefault(p => p.ProductId == id);

            return View(product);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Laptop", Description = "MAC", Price = 55000, Category = "Electronics" },
                new Product { ProductId = 2, ProductName = "Mobile", Description = "Iphone 18 Pro Max", Price = 250000, Category = "Electronics" },
                new Product { ProductId = 3, ProductName = "Mobile", Description = "Redmi 13C 5G", Price = 50000, Category = "Electronics" },
                new Product { ProductId = 4, ProductName = "Tablets", Description = "Samsung", Price = 25000, Category = "Electronics" }
            };
        }
    }
}
