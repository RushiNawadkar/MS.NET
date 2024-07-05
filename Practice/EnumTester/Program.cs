using EnumType;

String[] arr = (string[])Enum.GetNames(typeof(Days));

foreach (string s in arr)
{
    Console.WriteLine(s);
}
