using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductWebApplication.Service;
using ProductWebApplication.Entity;
namespace ProductWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Get")]
        public IActionResult get()
        {
            {
                var P = _productService.GetProducts();
                return Ok(P);
            }
        }

        [HttpPost("insert")]
        public IActionResult insert(Product product)
        {
            var P = _productService.insert(product);
            return Ok(P);
        }

        [HttpPut("update")]
        public IActionResult update(Product product)
        {
            {
                var p = _productService.update(product);
                return Ok(p);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            var p= _productService.delete(id);
            return Ok(p);
        }

        [HttpGet("{id}")]
        public IActionResult GetResult(int id)
        {
            var p =_productService.Get(id);
            return Ok(p);

        }

        [HttpGet("sort")]
        public IActionResult sort(Product product)
        {
            var p=_productService.sort(product);
            return Ok(p);

        }

    }
}
