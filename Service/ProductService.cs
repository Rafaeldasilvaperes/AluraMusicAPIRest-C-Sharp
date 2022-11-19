using AluraMusicAPIRest.DAO;
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
      
        public List<ProductModel> GetProdutos()
        {

            return _daoProduct.GetProdutos() ?? new List<ProductModel>();
        }
    }
    
}
