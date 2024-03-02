

List<int> list = new List<int>() {1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};
var a= list.Max();
System.Console.WriteLine($"Max number in List- {a}");
//list.RemoveAll(p=>p);
list.Sort();
System.Console.WriteLine("Sort");
foreach (var item in list)
{
    System.Console.Write(item+" ");
}
System.Console.WriteLine();
System.Console.WriteLine(" Replace all negative numbers with 0");
foreach (var item in list)
{
    var b=0;
    if(item<0)
    {
        b=item;
        b=0;
    }
    System.Console.Write(item+" ");
}
