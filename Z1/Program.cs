int a, b;

Console.Write("Enter a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter b: ");
b = Convert.ToInt32(Console.ReadLine());

if(a<=b)
{
    Console.WriteLine("max = " + b);
}
else if(a>b)
{
    Console.WriteLine("max = " + a);
}