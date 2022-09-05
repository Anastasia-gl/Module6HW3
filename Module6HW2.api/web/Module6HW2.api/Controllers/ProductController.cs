using Microsoft.AspNetCore.Mvc;
using Module6HW2.core.Interface;
using Module6HW2.db.Model;

namespace Module6HW2.api.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _productService.Create(product);
        }

        [HttpGet("{id}")]
        public IActionResult GetEntityId([FromRoute] int id)
        {
            var result = _productService.GetById(id);
            return Json(result);
        }

        [HttpPut]
        public void Put([FromBody] Product product)
        {
            _productService.Update(product);
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
             _productService.Delete(id);
        }
    }
}
