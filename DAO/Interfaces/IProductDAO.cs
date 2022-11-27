using AluraMusicAPIRest.Models;

namespace AluraMusicAPIRest.DAO.Interfaces
{
    public interface IProductDAO
    {
        public Task<List<ProductModel>> GetProdutos();
        public Task<ProductModel> GetOneProduct(int id);
        public Task<int> PostOneProduct(ProductModel product);
        public Task PutOneProduct(ProductModel product);
        public Task<int> DeleteOneProduct(ProductModel product);   
    }
    
}
