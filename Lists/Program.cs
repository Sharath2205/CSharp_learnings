using System;
using System.Collections.Generic;

/*
    - List class can be used to create a collection of any type.
    - Objects stored in the list can be accessed using index.
    - Lists grow automatically in size.

    - Few List methods:
        - Add(Value) - appends a value at the end of the list.
        - Insert(index, value) - Inserts the value at the specified index.
        - IndexOf(Value)- Returns the index of the value if it is present in the list.
        - IndexOf(Value, index)- Starts searching from the provided index and returns the index of the value if it is present in the list.
        - Contains(Value) - returns true if the list conatins the value else returns false.
        - Exists() - Checks for an item based on condition/predicate. Returns true if the item satisfies the condition else returns false.
            ex: MyObj.Exists(obj => obj.Name.StartsWith("p"));
        - Find() - Searches for an element that matches the provided lambda expression and returns the first element which satisfies the condition.
        - FindLast() - Searches for an element that matches the provided lambda expression and returns the last element which satisfies the condition.
        - FindAll() - Searches for All elements that matches the provided lambda expression and returns them if they satisfies the condition.
        - FindIndex() - Returns the index of the first element which satisfies the lambda expression.
        - FindLastIndex() - Returns the index of the Last element which satisfies the lambda expression.
        - Clear() - removes all elements from the list.

    - Few List Properties:
        - Count - returns no of elements in a list.

    - Conversions:
        - ArrayObj.ToList() - converts array elements into a new list and returns it.
        - ListObj.ToArray() - converts list objects into an array and return new array object.
        - ListObj.ToDictionary(key, [optional] value)- Makes a new dictinary. If value is not provided then by default ListObj elements are used.

    - Using Ranges:
        - AddRange() - Takes another list with same type and appends all items at the end of the list.
        - GetRange(index, count) - returns given count of elements from specified index.
        - InsertRange() - Takes an index and another list as arguments and appends all the list items at the end of the list.
        - RemoveRange() - Removes a range of elements.
        - RemoveAt(index) - removes the element at given index.
        - RemoveAll() - removes all elements which satisfies the condition.

    - Sorting: For simple types like int, char, float, string etc.
        - Sort() - sort all the elements in the list
        - Decending sort: sort using Sort() method and use Reverse() method to reverse it
        
        : For complex types the type have to inherit IComparable interface and override the CompareTo method.

        listObj.Sort((x, y) => x.Id.CompareTo(y.Id);
*/

namespace Lists
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

            List<Customer> customerList = new List<Customer>(5); // Here 5 is the initial size of the list and it grows dynamically if required

            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            customerList.Add(customer4);
            customerList.Add(customer5);
            customerList.Add(customer6);
            customerList.Add(customer7);

            // Contains() Method

            if (customerList.Contains(customer1))
            {
                Console.WriteLine("Customer found using Contains() Method");
            }

            // Exists() Method

            if (customerList.Exists(customer => customer.Id == 103))
            {
                Console.WriteLine("Customer found using Exists() Method");
            }

            Customer? c = customerList.Find(customer => customer.Name == "Sharath");
            if(c != null)
            {
                Console.WriteLine($"Customer found named {c.Name}");
            } else
            {
                Console.WriteLine("Customer not found");
            }

            int idx = customerList.FindIndex(customer => customer.Salary > 10000);
            Console.WriteLine(idx);
        }
    }

    class Customer
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
    }
}