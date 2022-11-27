using AluraMusicAPIRest.Models;

namespace AluraMusicAPIRest.Helpers
{
    public class MyExceptions
    {
        public IEnumerable<string> ChecksForInputErrors(ProductModel product)
        {
            var errors = string.IsNullOrEmpty(product.productName) ? string.Empty : product.productName;
            return new string[4];
        }
    }
}
