using ShopOnlineWeb.Enitity;
using ShopOnlineWeb.Repository;
using System.Reflection.Metadata.Ecma335;

namespace ShopOnlineWeb.Service
{
    public class ProductService:IProductService
    {
        public List<Products> GetProducts()
        {
            IProductManger productManger = new ProductManager();
            return productManger.GetProducts();
        }
    }
}
