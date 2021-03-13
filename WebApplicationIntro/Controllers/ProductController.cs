using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationIntro.Entity;
using WebApplicationIntro.Extentions;
using WebApplicationIntro.Models;

namespace WebApplicationIntro.Controllers
{
    
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index3()
        {
            List<Product>products=new List<Product>()
            {
                new Product(){Id = 1,CategoryId = 1,ProductName = "Laptop",UnitPrice = 300},
                new Product(){Id = 2,CategoryId = 1,ProductName = "Mouse",UnitPrice = 50},
                new Product(){Id = 3,CategoryId = 2,ProductName = "Keyboard",UnitPrice = 30},
                new Product(){Id = 4,CategoryId = 3,ProductName = "Phone",UnitPrice = 100}
            };
            List<string>categories=new List<string>(){"Beverage","Electronics","Food"};
            ProductViewModel model=new ProductViewModel()
            {
               Categories =  categories,
               Products=products
            };
            return View(model);
        }
        [Route ("add")]
        [HttpPost]
        public string AddProduct(Product product)
        {
            return "added";
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
           var categories = new List<SelectListItem>()
           {
           new SelectListItem() {Text = "Beverage",Value ="1"},
           new SelectListItem() {Text = "Electronics",Value ="2"},
           new SelectListItem() {Text = "Food",Value ="3"},
           };
           
            AddProductViewModel viewModel=new AddProductViewModel()
            {
                Categories = categories
            };
            return View(viewModel);
        }


        public string SetProduct()
        {
            Product product=new Product(){ProductName = "Laptop"};
            HttpContext.Session.SetObject("product",product);
            return product.ProductName;
        }
        public string GetProduct()
        {
            var product = HttpContext.Session.GetObject<Product>("product");
            return product==null ?" ":product.ProductName;
        }
    }
}
