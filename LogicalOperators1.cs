//  && -> mentioned conditions should be true, if any condition is false, it returns false.

using System;

class LogicalOperators1
{
    public static void Main()
    {
        int a=10,b=20,c=30;

        if((a>b) && (c>a))
        {
            Console.WriteLine("this is true statement");
        }
        else
        {
            Console.WriteLine("False");
        }
         
         //OR - when any one condition is true , it returns True
         
         if((a>b) || (c>a))
        {
            Console.WriteLine("this is true statement");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

       
     
}