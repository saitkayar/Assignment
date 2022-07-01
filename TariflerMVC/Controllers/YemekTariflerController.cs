using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TariflerMVC.Controllers
{
    public class YemekTariflerController : Controller
    {
        private ITarifService _tarifService;
        private ICategoryService _categoryervice;

        public YemekTariflerController(ITarifService tarifService, ICategoryService categoryervice)
        {
            _tarifService = tarifService;
            _categoryervice = categoryervice;
        }
        public IActionResult Tarifler()
        {
            ViewBag.tarifs = _tarifService.GetAll().Data;
            ViewBag.categories = _categoryervice.GetAll().Data;
            return View();
           
        }
        [HttpGet]
        public IActionResult YemekDetay(int id)
        {
           ViewBag.tarif= _tarifService.GetAll(x => x.Id == id).Data.FirstOrDefault();
       
            return View();
        }
    }
}
