using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnlineWeb.Service;

namespace ShopOnlineWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        //[HttpGet("GetResult")]
        [HttpGet]
        public IActionResult GetResult()
        {
            return Ok(_productService.GetProducts());
        }
    }
}
