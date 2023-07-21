using System;
namespace AssemblyOne
{
    class Test
    {
        public static void Main(string[] args)
        {
            AssemblyOneClassI assemblyOneClassI = new AssemblyOneClassI();
            assemblyOneClassI.ID = 1;

            assemblyOneClassI.InternalPrint();
            assemblyOneClassI.ProtectedInternalPrint();
        }
    }
}
