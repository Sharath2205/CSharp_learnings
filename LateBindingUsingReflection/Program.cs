using System;
using System.Reflection;

/*
    - Late binding occurs when an object is dynamic or unknown, which will only bind during run-time. 
    -  In late binding compilation, the compiler does not know what kind of object it is and what the methods or properties it holds.
*/

namespace LateBindingUsingReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is early binding. Compiler have knowledge of Customer class so it is allowing us to create an object of customer class.
            Customer customer = new Customer();
            string fn = customer.GetFullName("Sharath", "Chandra"); 
            Console.WriteLine(fn);


            // --------------------------------------



            // Using late binding to execute GetFullName method in customer class.

            // We have load the current executing assembly as the Customer class is present in it.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            // Loading the Customer class for which we want to create an instance dynamically
            Type? customerType = executingAssembly.GetType("LateBindingUsingReflection.Customer");

            // Create the instance of the customer type using Activator class 
            object? customerInstance = Activator.CreateInstance(customerType);

            // Get the method information using the customerType and GetMethod()
            MethodInfo? getFullName = customerType.GetMethod("GetFullName");

            // Invoke the method passing in customerInstance and parameters
            string fullName = (string) getFullName?.Invoke(customerInstance, new string[] {"Sharath", "Chandra"});

            Console.WriteLine($"{fullName}");
        }
    }

    class Customer
    {
        public string GetFullName(string FN, string LN)
        {
            return FN + " " + LN;
        }
    }
}