using eCom.Entities;
using eCom.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCom.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesServices categoriesService = new CategoriesServices();

        [HttpGet]
        public IActionResult Index()
        {
            var categories = categoriesService.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(category category)
        {
           categoriesService.SaveCategory(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int ID)
        {
            var category = categoriesService.GetCategory(ID);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(category category)
        {
            categoriesService.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int ID)
        {
            var category = categoriesService.GetCategory(ID);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(category category)
        {
           category = categoriesService.GetCategory(category.id);

            categoriesService.DeleteCategory(category);
            return RedirectToAction("Index");
        }
    }
}
