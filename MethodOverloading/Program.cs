using System;


/*
    Method Overloading: 
        - Ability to redefine a function in more than one form.
        - Usually done by defining two or more functions in a class sharing the same name but different signatures
        - Functions can be overloaded based on number of parameters, type of parameters, kind(Vaule, Out, Ref) of parameters and order of parameters.
        - Overloading doesnt depend on return type and params modifier.
*/

class Program
{

    public static int Add(int x, int y)
    {
        Console.WriteLine("Calling int add method");
        return x + y;
    }

    public static double Add(double x, double y) {  
        Console.WriteLine("Calling int double method");
        return x + y; 
    }

    public static int Add(int x, int y, int z)
    {
        Console.WriteLine("Calling add method with 3 parameters");
        return x + y + z;
    }
    public static double Add(int x, double y)
    {
        Console.WriteLine("Calling add method with int and double DT");
        return x + y;
    }

    public static double Add(double x, int y)
    {
        Console.WriteLine("Calling add method with double and int DT");
        return x + y;
    }

    static void Main()
    {
        Console.WriteLine(Add(1, 2));
        Console.WriteLine(Add(4.5, 6.0));
        Console.WriteLine(Add(4, 6, 5));
        Console.WriteLine(Add(4.5, 6));
        Console.WriteLine(Add(4, 6.0));
    }
}