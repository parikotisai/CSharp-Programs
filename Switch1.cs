using System;

class Switch1
{
    public static void Main()
    {  
        Console.WriteLine("Enter a and b:");
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        int c;
        Console.WriteLine("Enter which operation you want \n 1.Add 2.Sub 3.Mul 4. Div \n Enter 1 or 2 or 3 or 4");

        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1: c=a+b;
            Console.WriteLine("Add:"+c);
            break;

            case 2: c=a-b;
            Console.WriteLine("Sub:"+c);
            break;

            case 3: c=a*b;
            Console.WriteLine("Mul:"+c);
            break;

            case 4: c=a/b;
            Console.WriteLine("Div:"+c);
            break;

            default:
            Console.WriteLine("Cannot perform operation due to invalid case number!!! You entered:"+ operation);
            break;
        }
    }
}