using System;


/*
    - Polymorphism means "many forms"
    - occurs when we have many classes that are related to each other by inheritance.
    - Ex: Method Overloading
*/

class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN ";

    public virtual void PrintDetails()          // By making the base class method virtual we are allowing derived class to override this method.
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

class FullTimeEmployee : Employee
{
    public override void PrintDetails()         // Overriding the base class method by using override keyword.
    {
        Console.WriteLine($"{FirstName} {LastName} - Full Time Employee");
    }
}

class PartTimeEmployee : Employee
{
    public override void PrintDetails()
    {
        Console.WriteLine($"{FirstName} {LastName} - Part Time Employee");
    }
}


class TemporaryEmployee : Employee
{
    public override void PrintDetails()
    {
        Console.WriteLine($"{FirstName} {LastName} - Temporary Employee");
    }
}
class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(); 
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
        TemporaryEmployee temporaryEmployee = new TemporaryEmployee();

        emp.PrintDetails();
        fullTimeEmployee.PrintDetails();
        partTimeEmployee.PrintDetails();
        temporaryEmployee.PrintDetails();
    }
}