using ProductWebApplication.Entity;
namespace ProductWebApplication.Service
{
    public interface IProductService
    {
        List<Product> GetProducts();
        bool insert(Product product);
        bool update(Product product);
        bool delete(int id);

        Product Get(int id);
        List<Product> sort(Product product);



    }
}
