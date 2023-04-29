using AdvRentalApp;
using System.IO.Pipes;

var stack = new BasicStack<double>();
var stackString = new BasicStack<string>();
var stackInt =new BasicStack<int>();

stack.Push(item:4.5);
stack.Push(item: 43);
stack.Push(item: 333.6);
stackInt.Push(item: 8);
stackInt.Push(item: 53);
stackInt.Push(item: 633);
stackString.Push(item: "company1");
stackString.Push(item: "company2");
stackString.Push(item: "company3");
double sum = 0.0;

while(stack.Count > 0)
{
    double item =stack.Pop();
    Console.WriteLine(item);
    sum += item;
}
Console.WriteLine($"sumDouble: {sum}\n");
sum = 0;
while (stackInt.Count > 0)
{
    int item = stackInt.Pop();
    Console.WriteLine(item);
    sum += item;
}
Console.WriteLine($"sumInt: {sum}\n");
while (stackString.Count > 0)
{
    string item = stackString.Pop();
    Console.WriteLine(item);   
}