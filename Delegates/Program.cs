using System;
using System.Collections.Generic;

/*
    Delegate
    - A delegate is a type safe function pointer.
    - With delegates we can pass methods as parameters which can be used as callback methods.
    - 
*/

public delegate bool IsPromoteable(Employee emp);

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public void PrintPromotableEmployees(List<Employee> employees, IsPromoteable CheckIfPromotable)
    {
        foreach (Employee emp in employees)
        {
            if(CheckIfPromotable(emp))
            {
                Console.WriteLine(emp.Name + " is Promotable");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee() { Name= "Sharath", Experience = 5, Id = 1, Salary=10000 });
        employees.Add(new Employee() { Name= "Vamshi", Experience = 4, Id = 2, Salary=8000 });
        employees.Add(new Employee() { Name= "Raghav", Experience = 6, Id = 3, Salary=13000 });
        employees.Add(new Employee() { Name= "Abhi", Experience = 2, Id = 4, Salary=2000 });
        employees.Add(new Employee() { Name= "Anuj", Experience = 9, Id = 5, Salary=19000 });

        Employee employee = new Employee();

        IsPromoteable isPromoteable = new IsPromoteable(Promote);
        employee.PrintPromotableEmployees(employees, isPromoteable);

        //                          OR

        // Instead of creating a method and delegate object and passing it as a parameter we can make use of lambda expressions.

        employee.PrintPromotableEmployees(employees, emp => emp.Experience >= 5); // Internally a delegate ojb is created and this expression is passed as a function to that delegate ojb and that created object is then passed as parameter to the Employee class method.
        // Above emp.Experience is a lambda expression
    }

    public static bool Promote(Employee emp)
    {
        return (emp.Experience >= 5) ?  true: false;
    } 
}