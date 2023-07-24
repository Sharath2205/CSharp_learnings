using System;
using System.Collections.Generic;

/*
    Lambda Expressions:
        - Lambda expressions and anonymous functions are almost similar.
        - Lambda expression to create an anonymous function.
        - Use the lambda declaration operator =>(goes to) to separate the lambda's parameter list from its body.
            - (input-parameters) => expression
            - (input-parameters) => { <sequence-of-statements> }

    - To to find a employee with ID: 102 we hava to use find property which accepts a predicate.
    - we have to follow these steps to do that:
        Step 1: Create a method with requried condition like return emp where emp.ID == 102;
        Step 2: Create a delegate instance with suitable signature, parameters and return type.
        Step 3: Pass the delegate to the find method.

    By using Anonymous method we can do that in a single step.
        lets consider we have listEmployees list and we have to find emp with emp.Id = 102.

        Employee emp = listEmployees.Find(Delegate(Employee emp) {return emp.Id == 102}

    By using Lambda expressions
*/

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 101, Name="Sharath" },
                new Employee(){ Id = 102, Name="Anuj"},
                new Employee(){ Id = 103, Name = "Abhi"}
            };


            // Step 2: Creating a delegate instance
            Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);
            // Step 3: Using that delegate in Find method
            Employee? emp = employees.Find(emp => employeePredicate(emp));
            Console.WriteLine(emp?.Name + " - Found using general method");


            // Using Anonymous method.

            Employee? anoEmp = employees.Find(delegate (Employee emp) { return emp.Id == 102; });
            Console.WriteLine(anoEmp?.Name + " - Found using Anonymous method");

            // Using LambdaExpressions.

            Employee? lambdaEmp = employees.Find(emp => emp.Id == 102);
            Console.WriteLine(lambdaEmp?.Name + " - Found using Lambda expression");
        }

        // Step 1: Creating a function with condition
        static bool FindEmployee(Employee emp)
        {
            return emp.Id == 102;
        }

        class Employee
        {
            public int Id { get; set; }
            public string? Name { get; set; }
        }
    }
}