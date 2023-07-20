using System;

/*
    - Interface is a collection of abstract methods.
    - Interface only have method declarations. Classes which inherit the interface must provide definations for all the methods declared in the interface.
    - Interface only contains methods. Fields are not allowed in an interface
    - Interface members are PUBLIC by default. We cannot explicitly have access modifiers for interface methods.
*/

interface ICustomer
{
    void Print();
}

class Customer : ICustomer
{
    public void Print() { }
}


// ------------- Explicit implementation

interface I1
{
    void PrintInterface();
}

interface I2
{
    void PrintInterface();
} 

public class Program : I1, I2
{

    //public void PrintInterface()
    //{
    //    Console.WriteLine("Interface method");
    //}


    // Explict implementation
    void I1.PrintInterface()
    {
        Console.WriteLine("Interface 1");
    }

    void I2.PrintInterface()
    {
        Console.WriteLine("Interface 2");
    }


    static void Main()
    {
        //Program p1 = new Program();

        //p1.PrintInterface();

        I1 i1 = new Program();
        i1.PrintInterface();

        I2 i2 = new Program();
        i2.PrintInterface();
    }
}