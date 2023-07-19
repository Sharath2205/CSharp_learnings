using System;

/*
    Method Hiding:
    -  Hides the implementation of the methods of a base class from the derived class using the new keyword.
*/

public class Employee
{
    public string? FirstName;
    public string? LastName;
    public int Id;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;

} 

public class PartTimeEmployee : Employee
{
    public float HourlyRate;

    public new void PrintFullName() // Here we are hiding the Base class PrintFullName method by rewriting the method in derived class. To achieve that we have to use "new" keyword in method declaration.
    {
        Console.WriteLine(FirstName + " " + LastName + " - Contract Based.");

        //If you want to call the base class method despite hiding it we can achieve that using base keyword.

        //base.PrintFullName();

        // or we can typecast the PartTimeEmployee class object to Employee class object and call the base class PrintFullName method.

        // Or we can create Employee class refernce object with derived class and call the hidden method
        // Ex: Employee emp = new PartTimeEmployee();
        //     emp.PrintFullName();             // print base class method.   
    }

}

public class Program
{
    static void Main()
    {
        FullTimeEmployee fulltimeEmp = new FullTimeEmployee();
        fulltimeEmp.FirstName = "FullTime";
        fulltimeEmp.LastName = "Employee";
        fulltimeEmp.PrintFullName();


        PartTimeEmployee employee = new PartTimeEmployee();
        employee.FirstName = "PartTime";
        employee.LastName = "Employee";
        employee.PrintFullName();
    }
}