using AluraMusicAPIRest.Models;

namespace AluraMusicAPIRest.DAO.Interfaces
{
    public interface IProductDAO
    {
        public Task<List<ProductModel>> GetProdutos();
    }
}
