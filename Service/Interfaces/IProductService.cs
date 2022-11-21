using AluraMusicAPIRest.Models;

namespace AluraMusicAPIRest.Service.Interfaces
{
    public interface IProductService
    {
        public Task<List<ProductModel>> GetProdutos();
    }
}
