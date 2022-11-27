
using AluraMusicAPIRest.Models;
using AluraMusicAPIRest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AluraMusicAPIRest.Controllers
{
    [ApiController]
    [Route("/v1/[Controller]")]
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
        public async Task<ActionResult<List<ProductModel>>> Get()
        {

            var products = await _serviceProduct.GetProdutos();

            return products.Count == 0 ? NotFound("Products not found") : Ok(products);

        }

        // GET ONE: v1/products/5
        [HttpGet()]
        [Route("{id}")]
        public async Task<ActionResult<ProductModel>> Get(int id)
        {
            var singleProduct = await _serviceProduct.GetOneProduct(id);

            return singleProduct == null ? BadRequest("Product not found") : Ok(singleProduct);
        }

        // POST ONE: v1/products/
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<ProductModel>>> Post([FromBody] ProductModel product)
        {
            var productToBePosted = await _serviceProduct.PostOneProduct(product);
            
            return Ok(productToBePosted);
        }

        // PUT ONE: api/products/5
        [HttpPut("{id}")]
        public async Task<ActionResult<List<ProductModel>>> Put(int id, [FromBody] ProductModel product)
        {
            var productToBeEdited = await _serviceProduct.PutOneProduct(id, product);
   
            return productToBeEdited != null ? Ok(productToBeEdited) : BadRequest();
        }

        // DELETE ONE: api/products/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ProductModel>>> Delete(int id)
        {
            var singleProduct = await _serviceProduct.DeleteOneProduct(id);

            return Ok(singleProduct);
        }
    }
}
