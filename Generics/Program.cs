using System;

/*
    - Generic is a concept that allows us to define classes and methods with placeholder. 
    - C# compiler replaces these placeholders with specified type at compile time. 
    - They allow us to design classes and methods decoupled from datatypes.
    - The concept of generics is used to create general purpose classes and methods. 
    - To define generic method, we must use angle <> brackets. 
    - The angle brackets are used to declare a class or method as generic type.

    - Generics are type safe which is not achievable by object and boxing/unboxing is not performed by generics
*/

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.AreEqual<int>(1, 1));
            Console.WriteLine(Calculator.AreEqual<char>('a', 'a'));
            Console.WriteLine(Calculator.AreEqual<string>("sharath", "sharath"));


            // In the above examples we used generic to make method AreEqual() to accept any type of arguments and compare rather than write code for each type.
            // We can also make classes generic.

            GenericClass<int> genericClass1 = new GenericClass<int>();
            genericClass1.PrintType(1);

            GenericClass<string> genericClass2 = new GenericClass<string>();
            genericClass2.PrintType("My Name is Sharath");

            GenericClass<bool> genericClass3 = new GenericClass<bool>();
            genericClass3.PrintType(true);
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T number1, T number2)
        {
            return number1.Equals(number2);
        }
    }

    public class GenericClass<T>
    {
        public void PrintType(T input)
        {
            Console.WriteLine($"{input}");
        }
    }
}