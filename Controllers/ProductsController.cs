
using AluraMusicAPIRest.Models;
using AluraMusicAPIRest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AluraMusicAPIRest.Controllers
{
    [ApiController]
    [Route("/v1/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _serviceProduct;
        public ProductsController(IProductService serviceProduct)
        {
            _serviceProduct = serviceProduct;
        }

        // GET ALL: v1/products
        [HttpGet]
        [Route("")]
        public ActionResult<List<ProductModel>> Get()
        {
            return Ok( _serviceProduct.GetProdutos());
            
        }

        // GET ONE: v1/products/5
        [HttpGet()]
        [Route("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST ONE: v1/products/
        [HttpPost]
        [Route("")]
        public void Post([FromBody] string value)
        {
        }

        // PUT ONE: api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE ONE: api/products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
