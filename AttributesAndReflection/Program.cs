using System;
using System.Collections.Generic;

using System.Reflection;



/*
    Attributes:
        - Attributes allow us to add declarative information to programs.
        - This information is queried at runtime by reflection.
        - Some of the predefined Attributes are -
            - Obsolete: Marks types and types members outdated
            - WebMethod: Exposes method as XML web service method
            - Serializable: Indicates that the class can be serialized 

    Reflection: 
        - Ability to inspect an assembly metadata at run time. It allows us to inspect and manipulate classes, constructors, methods, and fields at runtime
        - Primary way to access the metadata is by using "Type" class.
        - Type class provides methods and properties using which we can get information about the type declaration.
        - Ex: Type typeName = Type.GetType(NamespaceName.ClassName);
        - We can also use typeof(ClassName) to get the type of the class
        - Ex: Type typeName = typeof(ClassName)
*/


namespace AttributesAndReflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 3, 4};
            Console.WriteLine(Calculator.Add(numbers));

            // By adding true to Obsolete constructor C# complier will not all us to use this method and throws and error.
            //Console.WriteLine(Calculator.Add(2, 3));  
        
            
            // Reflection   
        
            Type? T = Type.GetType("AttributesAndReflection.Calculator");

            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }

            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach(ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }

    public class Calculator
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }

        public void PrintId()
        {
            Console.WriteLine($"Id {Id}");
        }


        [Obsolete("This is an outdated method. Use int Add(List<int> numbers) for better flexibility", true)]
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Add(List<int> numbers)
        {
            int sum = 0;
            foreach (int x in numbers)
            {
                sum += x;
            }

            return sum;
        }
    }
}