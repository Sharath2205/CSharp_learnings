using System;


/*
    - An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
    - Increases readability of the program.
    - Scrictly types intergal constants. Means we have to type cast them to (int) or (Gender) as required
*/

namespace Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer { Gender = Gender.Unknown, Name = "Sam" };
            customers[1] = new Customer { Gender = Gender.Male, Name = "Ram" };
            customers[2] = new Customer { Gender = Gender.Female, Name = "Vam" };

            foreach (Customer customer in customers) {
                Console.WriteLine($"Customer Name : {customer.Name} \nCustomer Gender : {FindGender(customer.Gender)}");

                // or we can use enums for getting gender
                Console.WriteLine();
            }
        }

        public static string FindGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Undefined";
            }
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Customer
    {
        public string? Name { get; set; }
        public Gender Gender { get; set; }
    }
}