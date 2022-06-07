int a;

Console.Write("Enter a: ");

a = Convert.ToInt32(Console.ReadLine());

if(a>0)
{
    for(int i = 1; i<=a; i++)
    {
       if(i%2==0) Console.Write(i + " ");
    }
}

else if(a==0) Console.Write("0"); 

else if(a<0) 
{
    for(int i = a; i<1; i++)
    {
       if(i%2==0) Console.Write(i + " ");
    }
}