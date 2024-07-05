
 namespace Customer
{
    public class Cust
    {
      public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Cust(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }


        
        public override string ToString()
        {
            return Id+" "+Name+" "+Description;
        }
    }
}
