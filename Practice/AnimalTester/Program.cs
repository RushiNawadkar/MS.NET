using Dog;

Console.WriteLine("Enter Animal Name & Desc");
String name=Console.ReadLine();
string desc=Console.ReadLine();
DogAbs dog=new DogAbs(name,desc);
dog.display();
dog.DogName="Chimya";
dog.display();
dog.sound();