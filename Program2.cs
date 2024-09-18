using System;

class Program1
{
static void Main()
{
   int a=10,b=20,c=3;

   if(a>b)
   {
    if(b>c)
    {
        if(c>a)
        {
            Console.WriteLine("c>a");
        }
    }

    else
    {
        Console.WriteLine("this is else block");
    }
   }
   else{
    Console.WriteLine("hello how r u ?");
   }

}

}