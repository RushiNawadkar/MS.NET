using MySql.Data.MySqlClient;
using ShopOnlineWeb.Enitity;
using System.Data;

namespace ShopOnlineWeb.Repository
{
    public class ProductManager :IProductManger
    {
        public List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();
            string concatString = @"server=localhost;port=3306;database=dotnet;user=root;password=Rushi9499";
           
            MySqlConnection con = new MySqlConnection(concatString);
            string Query = "SELECT * from products";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    int quantity = int.Parse(reader["quantity"].ToString());
                    string imgeurl = reader["imageurl"].ToString();
                    int unitprice = int.Parse(reader["untiprice"].ToString());


                    Products prod = new Products();
                    prod.Id = id;
                    prod.title = title;
                    prod.Quantity = quantity;
                    prod.Description = description;
                    prod.imgurl = imgeurl;
                    prod.unitprice=unitprice;
                    products.Add(prod);
                    
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return products;

        }

    }
}
