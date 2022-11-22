
using AluraMusicAPIRest.DAO.Interfaces;
using AluraMusicAPIRest.Models;
using AluraMusicAPIRest.Service.Interfaces;

namespace AluraMusicAPIRest.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductDAO _daoProduct;

        public ProductService(IProductDAO daoProduct)
        {
            _daoProduct = daoProduct;
        }
        
        // GET ALL
        public async Task<List<ProductModel>> GetProdutos()
        {
            try
            {
                return await _daoProduct.GetProdutos();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public async Task<ProductModel> GetOneProduct(int id)
        {
            try
            {
                return await _daoProduct.GetOneProduct(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    
}
