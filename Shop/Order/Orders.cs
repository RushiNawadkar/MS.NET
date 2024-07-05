using Customer;
namespace Order
{
    public class Orders : Cust
    {
       
        public double ounit { get; set; }


        public Orders(int oId, string oName, String description, double ounit) : base(oId, oName, description)
        {
           

            this.ounit = ounit;

        }
    
        public override string ToString()
        {
            return base.ToString()+" "+ounit;
        }


    }
}
