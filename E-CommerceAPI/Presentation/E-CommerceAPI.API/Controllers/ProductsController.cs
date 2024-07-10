using E_CommerceAPI.Application.Abstarction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductSercive _productSercive;

        public ProductsController(IProductSercive productSercive)
        {
            _productSercive = productSercive;
        }

        [HttpGet]
        public IActionResult GetProducts() 
        {
            var products = _productSercive.GetProducts();   
            return Ok(products);
        }
    }
}
