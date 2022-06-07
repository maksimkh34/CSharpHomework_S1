int a, b, c, max;

Console.Write("Enter a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter c: ");
c = Convert.ToInt32(Console.ReadLine());

max = a;

if(b>max) max = b;
if(c>max) max = c;

Console.Write("max = " + max);