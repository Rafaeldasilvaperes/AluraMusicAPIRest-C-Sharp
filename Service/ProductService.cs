
using AluraMusicAPIRest.DAO.Interfaces;
using AluraMusicAPIRest.Models;
using AluraMusicAPIRest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;

namespace AluraMusicAPIRest.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductDAO _daoProduct;

        public ProductService(IProductDAO daoProduct)
        {
            _daoProduct = daoProduct;
        }
        
        // GET ALL
        public async Task<List<ProductModel>> GetProdutos()
        {
            try
            {
                return await _daoProduct.GetProdutos();
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        // GET ONE BY ID
        public async Task<ProductModel> GetOneProduct(int id)
        {
            try
            {
                return await _daoProduct.GetOneProduct(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        // POST ONE
        public async Task<List<ProductModel>> PostOneProduct(ProductModel product)
        {
            try
            {

                var productToBePosted = await _daoProduct.PostOneProduct(product);
                var productsWithNewProduct = await _daoProduct.GetProdutos();
                if (productToBePosted > 0)
                {
                    return productsWithNewProduct;
                }
                else
                {
                    throw new Exception();
                }
                 
            }
            catch (Exception)
            {

                throw;
            }
        }
        // PUT ONE BY ID
        public async Task<ProductModel> PutOneProduct(int id, ProductModel product)
        {
            try
            {
                var productWithThisId = await _daoProduct.GetOneProduct(id);
                if (productWithThisId is null)
                {
                    return new ProductModel();
                }
             
                productWithThisId.productName = product.productName;
                productWithThisId.productPrice = product.productPrice ;
                productWithThisId.productDescription = product.productDescription;
                productWithThisId.productAlt = product.productAlt;
                productWithThisId.productType = product.productType; 
                productWithThisId.productImage = product.productImage;


                await _daoProduct.PutOneProduct(productWithThisId);

                return productWithThisId;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<ProductModel>> DeleteOneProduct(int id)
        {
            try
            {
                
                var productExists = await _daoProduct.GetOneProduct(id);
                if (productExists is not null)
                {
                    await _daoProduct.DeleteOneProduct(productExists);
                    var productsWithNewProduct = await _daoProduct.GetProdutos();
                    return productsWithNewProduct;

                }
                else
                {
                    throw new Exception();
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    
}
