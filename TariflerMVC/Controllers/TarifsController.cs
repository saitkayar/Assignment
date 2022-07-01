using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace TariflerMVC.Controllers
{
    public class TarifsController : Controller
    {
        private ITarifService _tarifService;
        private ICategoryService _categoryervice;

        public TarifsController(ITarifService tarifService, ICategoryService categoryervice)
        {
            _tarifService = tarifService;
            _categoryervice = categoryervice;
        }

        public IActionResult Index()
        {
        ViewBag.tarifs=  _tarifService.GetAll().Data;
        ViewBag.categories=  _categoryervice.GetAll().Data;
            return View();
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var tarif = _tarifService.Get(x=>x.Id==id).Data;
            ViewBag.categories = _categoryervice.GetAll().Data;
            return Json(new { success = true, data = tarif });
        }

        [HttpPost]
        public IActionResult Add(Tarif tarif)
        {
            _tarifService.Add(tarif);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Tarif tarif)
        {
            _tarifService.Update(tarif);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var delete = _tarifService.Get(a => a.Id == id).Data;
            _tarifService.Delete(delete);
            return RedirectToAction("Index");
        }
    }
}
