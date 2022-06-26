using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(this._productService.GetAll());
        }

        [HttpPost("get-all-by-filter")]
        public IActionResult GetByCategoryId(ProductFilterDto productFilter)
        {
            return Ok(this._productService.GetAll(p =>
               (productFilter.CategoryId == 0 || p.CategoryId == productFilter.CategoryId) &&
               (productFilter.BrandId == 0 || p.BrandId == productFilter.BrandId) &&
               (productFilter.UnitTypeId == 0 || p.UnitTypeId == productFilter.UnitTypeId)
            ));
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            return Ok(this._productService.Add(product));
        }
        [HttpPut("update")]
        public IActionResult Update(Product product)
        {
            return Ok(this._productService.Update(product));
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Product product)
        {
            return Ok(this._productService.Delete(product));
        }
    }
}
