
using c__L3;
using Lab3;

Mylist<int> list = new Mylist<int>();

list.Add(10);
list.Add(20);
list.Add(30);
list.Add(20);
list.PrintAll();  


if (list.Remove(20)) 
list.PrintAll();  
else
Console.WriteLine("elment not found ");

if(list.Remove(100))  
list.PrintAll();
else
Console.WriteLine("elment not found ");

Console.WriteLine(list[0]);





InhiritList<string> list1 = new InhiritList<string>();
list1.Add("Hello");
list1.Add("World");
Console.WriteLine(list1.get(0));
Console.WriteLine(list1.get(1));