using System;
namespace UsingVar{

    public class Var
    {
        private int id;
        private string name;
        private string value;

        public int getId
        {
            set {
                 this.id = value; 
                    }
            get {
                return this.id;
                }
        }

        public string getName
        {
            set
            {
                this.name = value;

            }
            get
            {
                return this.name;
            }
        }

      

        

       static void Main(String[] args)
        {
            Var v = new Var();
            v.id = 1;
            Console.WriteLine(v.id);
        }
    }

}
