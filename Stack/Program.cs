using System;
using System.Collections.Generic;


/*
    Stack - LIFO (Last in first out)
    
    Methods:
        - Push() - Adds element to the top of the stack.
        - Pull() - Removes element from top of the stack.
        - Peek() - Returns the top element from the stack.
        - Contains() - Checks if the element is present in the stack or not.

    Properties:
        - Count - counts the no.of elements in the stack
        - 
*/

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 101, Name = "Sharath", Salary = 6000 };
            Customer customer2 = new Customer() { Id = 102, Name = "Shravan", Salary = 9000 };
            Customer customer3 = new Customer() { Id = 103, Name = "Sanjay", Salary = 10000 };
            Customer customer4 = new Customer() { Id = 104, Name = "Vamshi", Salary = 12000 };
            Customer customer5 = new Customer() { Id = 105, Name = "Raghav", Salary = 10000 };
            Customer customer6 = new Customer() { Id = 106, Name = "Anuj", Salary = 11000 };
            Customer customer7 = new Customer() { Id = 107, Name = "Abhishek", Salary = 6000 };

            Stack<Customer> st = new Stack<Customer>();

            st.Push(customer1);
            st.Push(customer2);
            st.Push(customer3);
            st.Push(customer4);
            st.Push(customer5);
            st.Push(customer6);
            st.Push(customer7);

            Console.WriteLine("No. of elements in the stack are: {0}", st.Count);


            Console.WriteLine("Element popped from the list is: {0}", st.Pop().Id);

            Console.WriteLine("No. of elements in stack after popping the last element: {0}", st.Count);

            Console.WriteLine("Top most Customer in the stack is: {0}", st.Peek().Name);

            foreach (Customer c in st) Console.WriteLine(c.Name);

            if(st.Contains(customer3))
            {
                Console.WriteLine("Customer 3 is present in the stack");
            } else
            {
                Console.WriteLine("Customer 3 is not present in the stack");
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set;}
    }
}