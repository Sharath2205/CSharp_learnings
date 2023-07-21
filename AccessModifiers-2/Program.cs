using System;
using AssemblyOne;

namespace AccessModifiers_2



/*
    ** Types (Classes, structs, emums, interfaces, delegates) can only use public and internal access modifiers
    Internal access modifier:
        - Accessable only in this assembly
        - When a c# code complies it either generates a .exe or .dll file and the field or type which is declared internal are accessable in that particular assembly

    Protected Internal Access Modifier:
        - Accessable with in the any code in which the field is declared or in assembly which derives this assembly
*/

{
    public class AssemblyOneClassOne
    {
        internal int ID = 101;
    }

    public class AssemblyOneClassTwo
    {
        public void Print()
        {
            AssemblyOneClassOne class1 = new AssemblyOneClassOne();
            class1.ID = 201;
            Console.WriteLine(class1.ID + " hello");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Accessing and modifing the value of ID from main method in the same assembly
            AssemblyOneClassOne cls1 = new AssemblyOneClassOne(); ;
            cls1.ID = 301;

            AssemblyOneClassII assemblyOneClassII = new AssemblyOneClassII();
            assemblyOneClassII.ID = 1;

            assemblyOneClassII.ProtectedInternalPrint();
        }
    }
}