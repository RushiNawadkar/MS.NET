using ProductWebApplication.Entity;
using ProductWebApplication.Repository;
using System.Reflection.Metadata.Ecma335;

namespace ProductWebApplication.Service
{
    public class ProductService : IProductService
    {
         public bool delete(int id)
        {
            using (var context = new StoreContext())
            {
                var p=context.products.Find(id);
                if(p != null)
                {
                    context.products.Remove(p);
                    context.SaveChanges();
                }
                
            }
            return true;

        }

       public  Product Get(int id)
        {
            using (var context = new StoreContext())
            {
                var p=context.products.Find(id);
                return p;
            }
       
        }

        public List<Product> GetProducts()
        {
            using (var context = new StoreContext())
            {
                var s= from p in context.products select p;
                return s.ToList<Product>();
            }
        }

        public bool insert(Product product)
        {
            using (var context = new StoreContext())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
            return true;

        }

        public bool update(Product product)
        {
            using (var context = new StoreContext())
            {
                var p=context.products.Find(product.pid);
                if(p != null)
                {
                    p.pname = product.pname;
                    p.price = product.price;
                    p.qty = product.qty;
                    p.mdate = product.mdate;
                    context.products.Update(p);
                    context.SaveChanges();
                }
            }
            return true;
        }

        public List<Product> sort(Product product)
        {
            using (var context = new StoreContext())
            {
                var p = context.products.OrderBy(equals => equals.pname);
                return p.ToList<Product>();
            }
        }
    }

}
