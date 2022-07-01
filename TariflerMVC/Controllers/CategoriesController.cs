using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TariflerMVC.Controllers
{
    public class CategoriesController : Controller
    {
       
        private ICategoryService _categoryervice;

        public CategoriesController(ICategoryService categoryervice)
        {
            _categoryervice = categoryervice;
        }

        public IActionResult Index()
        {
            ViewBag.categories = _categoryervice.GetAll().Data;
            return View();
        }

        [HttpGet]
        public IActionResult Get(int id)
        {

            var category = _categoryervice.Get(x => x.Id == id).Data;
            return Json(new { success = true, data = category });
        }

        [HttpPost]
        public IActionResult Add(Category categories)
        {
            _categoryervice.Add(categories);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Category categories)
        {
            _categoryervice.Update(categories);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var delete = _categoryervice.Get(a => a.Id == id).Data;
            _categoryervice.Delete(delete);
            return RedirectToAction("Index");
        }
    }
}
