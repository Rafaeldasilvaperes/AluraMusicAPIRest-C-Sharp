using AluraMusicAPIRest.Models;

namespace AluraMusicAPIRest.DAO.Interfaces
{
    public interface IProductDAO
    {
        public List<ProductModel> GetProdutos();
    }
}
