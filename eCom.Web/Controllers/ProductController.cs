using eCom.Entities;
using eCom.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCom.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsServices productsServices = new ProductsServices();
        [HttpGet]
        public IActionResult Index()
        {
            var All_products = productsServices.GetProducts();
            return View(All_products);
        }

        //[HttpPost]
        public ActionResult productTable(string search)
        {
            var All_products = productsServices.GetProducts();
            if (!string.IsNullOrEmpty(search))
            {
                All_products = All_products.Where(p => p.name.ToLower().Contains(search.ToLower())).ToList();
            }
            return PartialView("productTable", All_products);
        }

        public IActionResult Search(string search)
        {
            var searched = productsServices.Getproduct(search);
            return View(searched);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(product product)
        {
            productsServices.Saveproduct(product);
            return RedirectToAction("Index");
        }
    }
}
