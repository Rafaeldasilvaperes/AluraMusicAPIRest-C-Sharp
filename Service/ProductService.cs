using AluraMusicAPIRest.DAO;
using AluraMusicAPIRest.DAO.Interfaces;
using AluraMusicAPIRest.Models;
using AluraMusicAPIRest.Service.Interfaces;

namespace AluraMusicAPIRest.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductDAO _daoProduct;

        public ProductService()
        {
            _daoProduct = new ProductDAO();
        }
      
        public List<ProductModel> GetProdutos()
        {

            return _daoProduct.GetProdutosHttp() ?? new List<ProductModel>();
        }
    }
    
}
