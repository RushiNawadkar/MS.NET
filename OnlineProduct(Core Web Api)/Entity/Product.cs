using Org.BouncyCastle.Bcpg;

namespace ProductWebApplication.Entity
{
    public class Product
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public double price { get; set; }
        public int qty { get; set; }
        public DateTime mdate { get; set; }

    }
}
