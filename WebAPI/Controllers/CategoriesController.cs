using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(this._categoryService.GetAll());
        }
        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            return Ok(this._categoryService.Add(category));
        }
        [HttpPut("update")]
        public IActionResult Update(Category category)
        {
            return Ok(this._categoryService.Update(category));
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Category category)
        {
            return Ok(this._categoryService.Delete(category));
        }
    }
}
