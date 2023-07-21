namespace AssemblyOne
{
    internal class AssemblyOneClassI // This class is only accessable in this assembly.
    {
        internal int ID = 101;   // This can be accessed any where in this assembly

        internal void InternalPrint()
        {
            Console.WriteLine("From Assembly one class 1 - Internal method ----- " + ID);
        }

        protected internal void ProtectedInternalPrint() {
            Console.WriteLine("From Assembly one class 1 - Protected Internal method ----- " + ID);
        }
    }

    public class AssemblyOneClassII
    {
        public int ID = 201;

       public void ProtectedInternalPrint()
        {
            Console.WriteLine("From Assembly one class 1 - Protected Internal method ----- " + ID);
        }
    }
}