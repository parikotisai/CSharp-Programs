using System;

class Datatypes1
{
    public static void Main(string[] args)
    {
        int a=10;

        var b =20.5;  // var will be compile type checking datatype
 
        dynamic c= 'a'; // var will be runtime type checking datatype

        Console.WriteLine("a value b value c value:{0},{1},{2}", a, b, c);

        Console.WriteLine("a type:"+ a.GetType());
        Console.WriteLine("b type:"+ b.GetType());
        Console.WriteLine("c type:"+ c.GetType());

        object p="sai";
        object q=10;
        object r= true;

        Console.WriteLine("P:{0} Q:{1} R:{2}",p,q,r);
    }
}