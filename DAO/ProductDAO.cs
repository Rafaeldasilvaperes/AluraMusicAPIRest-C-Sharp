using AluraMusicAPIRest.DAO.Interfaces;
using AluraMusicAPIRest.Data;
using AluraMusicAPIRest.Models;


namespace AluraMusicAPIRest.DAO
{
    public class ProductDAO : IProductDAO
    {

        private readonly DataContext _dataContext;

        public List<ProductModel> GetProdutos()


        {
            return new List<ProductModel>();

        }
    }
}
