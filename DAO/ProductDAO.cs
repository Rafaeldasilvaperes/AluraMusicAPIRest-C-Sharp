using AluraMusicAPIRest.DAO.Interfaces;
using AluraMusicAPIRest.Models;
using Newtonsoft.Json;

namespace AluraMusicAPIRest.DAO
{
    public class ProductDAO : IProductDAO
    {
        public List<ProductModel> GetProdutosHttp()
        {
            return new List<ProductModel>();

        }
    }
}
