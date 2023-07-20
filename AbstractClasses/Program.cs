using System;

/*
    Abstract Classes:
    - Restricted class that cannot be used to create objects.
    - Abstract method can only be used in an abstract class, and it does not have a body. The body is provided by the derived class.
    - Contains abstract methods and regular methods.
*/

public abstract class Customer
{
    public void RegularPrint()  // Non abstract method.
    {
        Console.WriteLine("Printing regular method");
    }

    public abstract void AbstractPrint();
}

class CustomerClass : Customer 
{
    public override void AbstractPrint()
    {
        Console.WriteLine("Printing Abstract class method from derived class");
    }
}


class Program
{
    static void Main()
    {
        CustomerClass cust = new CustomerClass();
        cust.RegularPrint();
        cust.AbstractPrint();
    }
}