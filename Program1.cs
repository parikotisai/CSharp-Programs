using System;

class Program1
{
static void Main()
{
    int x=10,y=10;
   
    if (x>y)
    {
        Console.WriteLine("x is greater than y");
    }

    else{
        Console.WriteLine("y is greater than x");
    }

int a=10,b=10,c=10;

if (a>b)
{
Console.WriteLine("a>b");
}
else if (a>c)
{
Console.WriteLine("a<b");
}
else if(b>c)
{
Console.WriteLine("b>c");
}

else if(c>a)
{
Console.WriteLine("c>a");
}
else{
    Console.WriteLine("a=b");
}

}

}