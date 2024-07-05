using Abstract_Class;


Console.WriteLine("Enter Student id,Name,title,rollno,fee");
int id=Convert.ToInt32(Console.ReadLine());
String name=Console.ReadLine();
String title=Console.ReadLine();
int rollno=Convert.ToInt32(Console.ReadLine());
Double fees=Convert.ToDouble(Console.ReadLine());


Student std = new Student(id, name, title, rollno, fees);
std.showDetails();

