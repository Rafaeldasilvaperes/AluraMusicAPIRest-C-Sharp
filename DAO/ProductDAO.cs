using AluraMusicAPIRest.DAO.Interfaces;
using AluraMusicAPIRest.Models;
using Microsoft.EntityFrameworkCore;

namespace AluraMusicAPIRest.DAO
{
    public class ProductDAO : IProductDAO
    {
        private readonly ProductDbContext _productDbContext;

        public ProductDAO(ProductDbContext productDbContext) 
        {
            _productDbContext = productDbContext;
        }
        // GET ALL
        public async Task<List<ProductModel>> GetProdutos()
        {
            return await _productDbContext.Product.ToListAsync();
        }
        // GET ONE BY ID
        public async Task<ProductModel> GetOneProduct(int id)
        {
            return await _productDbContext.Product.FindAsync(id);
            
        }
        // POST ONE
        public async Task<int> PostOneProduct(ProductModel product)
        {
            _productDbContext.Product.Add(product);
            return await _productDbContext.SaveChangesAsync();
            
        }
        // EDIT ONE
        public async Task PutOneProduct(ProductModel product)
        {
            await _productDbContext.SaveChangesAsync();
        }
        // DELETE ONE
        public async Task<int> DeleteOneProduct(ProductModel product)
        {
            _productDbContext.Product.Remove(product);
            return await _productDbContext.SaveChangesAsync();
        }
    }
}
