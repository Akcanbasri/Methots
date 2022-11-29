using generics;

List<string> cities = new List<string>();
Mylist<string> cities2 =new Mylist<string>();
Console.WriteLine(cities2.Count);
cities2.Add("Ankara");
cities2.Add("İstanbul");
Console.WriteLine(cities2.Count);