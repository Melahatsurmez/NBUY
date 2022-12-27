using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.Business.Abstract;

namespace ShoppingApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        //Projenizdde swagger var ise tüm  action mettolarınızın Http Request türü yazılmalıdır.HttpGet, HttpPost vb.
        [HttpGet]
        public async Task<IActionResult> GetProducts() 
        {
            var product = await _productService.GetAllAsync();
            return Ok(product);
        }
    }
}
