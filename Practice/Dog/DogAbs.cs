using Animal;
namespace Dog
{
    public class DogAbs:AnimalAbs
    {
        private String Description;

        public DogAbs(String name,String description):base(name) 
        {
            this.Description = description;
        }

        public void display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Desc : "+ Description);
        }

        public override void sound()
        {
            Console.WriteLine("Barks.....!");
        }
    }
}
