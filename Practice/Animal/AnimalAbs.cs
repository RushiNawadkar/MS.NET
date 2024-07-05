namespace Animal
{
    public abstract class AnimalAbs
    {
        protected String Name;

        public AnimalAbs(String name)
        {
            this.Name = name;
        }

        public string DogName
        {
            get { return this.Name; }

            set { this.Name = value; }
        }


        public abstract void sound();


        public void display()
        {
            Console.WriteLine("Name : "+Name);
        }
    }
}
