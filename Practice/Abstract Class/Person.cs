namespace Abstract_Class
{
   public abstract class Person
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public string Title { get; set; }


        public Person(int id, String Name,String Title) { 
            this.Id = id;
            this.Name = Name;
            this.Title = Title;
        }
        public abstract void showDetails();
    }


}
