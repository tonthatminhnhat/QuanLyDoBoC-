using System;

string[] names = new string[]
{
    "NHAT","PRO","ok","6","oklad","nam","long","ly","luong"
};
/*for(int i=0;i < names.Length; i++){
    if (names[i].Length >= 4)
        Console.WriteLine(names[i]);
}
Console.WriteLine("----------------------");
var ls4 = names.Where(e => e.Length >= 4).ToList();
foreach(string s in ls4) {
    Console.WriteLine(s);
}*/

/*foreach(string name in names)
{
    if(name.StartsWith("l")&&name.Length>=4)
        Console.WriteLine(name);
}
Console.WriteLine("----------------------");
var lsL=names.Where (name => name.StartsWith("l")&& name.Length >= 4);
foreach (var a in lsL)
{
    Console.WriteLine(a);
}
*/
List<int> numbers = new List<int>();
Random random = new Random();
for (int i = 0; i <= 10; i++)
{
    numbers.Add(random.Next(100));
}
numbers.ForEach(x => Console.Write(x+" "));
Console.WriteLine("\ndanh sach so chan");
var sochan = numbers.Where(x => x % 2 == 0).ToList();
sochan.ForEach(x => Console.Write(x+" "));
Console.WriteLine("\nTong cac so chan:");
var tongsochan=0;
foreach(var s in sochan)
{
    tongsochan += s;
}
Console.WriteLine(tongsochan);
Console.WriteLine($"\nSo max: {numbers.Max()},Min: {numbers.Min()},Average: {numbers.Average()} " );

Console.WriteLine("\nCac so chinh phuong:");
var sochinhphuong = numbers.Where(x => Math.Sqrt(x) % 1 == 0 && Math.Sqrt(x) > 0);
foreach (var item in sochinhphuong)
{
    Console.Write(item+",");
}