using AluraMusicAPIRest.Models;

namespace AluraMusicAPIRest.Service.Interfaces
{
    public interface IProductService
    {
        public Task<List<ProductModel>> GetProdutos();
        public Task<ProductModel> GetOneProduct(int id);
        public Task<List<ProductModel>> PostOneProduct(ProductModel product);
        public Task<ProductModel> PutOneProduct(int id, ProductModel product);
    }
}
