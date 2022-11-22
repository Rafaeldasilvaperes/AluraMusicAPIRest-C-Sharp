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

        public async Task<List<ProductModel>> GetProdutos()
        {
            return await _productDbContext.Product.ToListAsync();
        }
        public async Task<ProductModel> GetOneProduct(int id)
        {
            return await _productDbContext.Product.FindAsync(id);
            
        }
    }
}
