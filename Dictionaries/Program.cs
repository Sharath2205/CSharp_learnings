using System;
using System.Collections.Generic;

/*
    - Dictionary is a collection of {key, value} pairs.
    - Keys should be unique.
    - We can access the value by using the key.

    - DECLARING AN DICTIONARY: Dictionary<KeyType, ValueType> dictionaryObjectName = new Dictionary<KeyType, ValueType>();

    - ADDING ELEMENTS IN DICTIONARY: dictionaryObject.add(Key, Value)
    - RETRIVING VALUE CORRESPONDING TO A KEY: dictionaryObject[key]
    - REMOVING A PAIR FROM DICTIONARY: dictionaryObject.remove(key);
    - CLEARING A DICTIONARY: dictionaryObject.clear();

    FEW IMPORTANT DICTIONARY METHODS
    - Add() -Adds a value to a dictionary.
    - ContainsKey() - Returns true if the dictionary contains key or else returns false.
    - ContainsValue() - Returns true if the dictionary contains one or more than one Value or else returns false.
    - Count() - Returns no. of fields in a dictionary
    - dictObj.Count(kvp => kvp.Id == id) - Returns values which satisfies the condition.

    FEW IMPORTANT DICTIONARY PROPERTIES
    - Count -> returns the numbers of records in an dictionary
    - Keys -> returns all Keys from the dictionary
    - Values -> returns all Values from the dictionary
*/


namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 101, Name = "Sharath", Salary=6000};
            Customer customer2 = new Customer() { Id = 102, Name = "Shravan", Salary=9000};
            Customer customer3 = new Customer() { Id = 103, Name = "Sanjay", Salary=10000};
            Customer customer4 = new Customer() { Id = 104, Name = "Vamshi", Salary=12000 };
            Customer customer5 = new Customer() { Id = 105, Name = "Raghav", Salary=10000 };
            Customer customer6 = new Customer() { Id = 106, Name = "Anuj", Salary=11000 };
            Customer customer7 = new Customer() { Id = 107, Name = "Abhishek", Salary=6000 };

            Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();

            customerDictionary.Add(customer1.Id, customer1);
            customerDictionary.Add(customer2.Id, customer2);
            customerDictionary.Add(customer3.Id, customer3);
            customerDictionary.Add(customer4.Id, customer4);
            customerDictionary.Add(customer5.Id, customer5);
            customerDictionary.Add(customer6.Id, customer6);
            customerDictionary.Add(customer7.Id, customer7);

            Customer c1 = customerDictionary[101]; // Retriving a item using key

            Console.WriteLine($"{c1.Name} {c1.Id} {c1.Salary}");

            Dictionary<int, Customer>.KeyCollection keys = customerDictionary.Keys;
            foreach(var key in keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("--------------");

            foreach(KeyValuePair<int, Customer> customer in customerDictionary)
            {
                // We can access the keys using customer.Key and values using customer.Value
                Console.WriteLine("Name: {0} Id: {1} Salary: {2}", customer.Value.Name, customer.Value.Id, customer.Value.Salary);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }

        
    }
}