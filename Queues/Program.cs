using System;

/*
    - Queue is a FIFO (First In First Out) Class Collection present in System.Collections.Generic namespace.
    - 
*/

namespace Queues
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

            Queue<Customer> queue = new Queue<Customer>();
            queue.Enqueue(customer1);
            queue.Enqueue(customer2);
            queue.Enqueue(customer3);
            queue.Enqueue(customer4);
            queue.Enqueue(customer5);
            queue.Enqueue(customer6);
            queue.Enqueue(customer7);

        }
    }

    class Customer
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
    }
}