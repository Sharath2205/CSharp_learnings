using System;


/*
Inheritance:
    - a mechanism in which one object acquires all the properties and behaviors of a parent object.
    - Base class (PARENT): A class from which other classes derive this class fields and methods.
    - Derived class (CHILD): A class which inherits the fields and methods from another class.

    used for - code resuabilty


    There are 5 types of inheritance
        - Single 
        - Multiple (Not supported by c#)
        - Mulitlevel
        - Hierarchical
        - Hybrid
*/

public class Employee
{
    public string? FirstName;
    public string? LastName; 
    public int Age;

    public Employee(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

class FullTime : Employee  // Here class FullTime is inheriting Employee class so every field and method are accessible by FullTime ojbect
{
    public float YearlySalary;

    public FullTime(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }
}

public class PartTime: Employee // Here class PartTime is inheriting Employee class so every field and method are accessible by PartTime ojbect
{
    public float HourlyRate;

    public PartTime(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }
}

class Program
{
    static void Main()
    {
        FullTime fte = new FullTime("Dave", "Singh", 30);
        fte.YearlySalary = 300000;
        
        fte.PrintFullName();

        PartTime pte = new PartTime("Bob", "Hensly", 30);
        pte.HourlyRate = 17;

        pte.PrintFullName();
    }
}