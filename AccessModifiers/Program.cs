using System;

/*
    - Basically there are 5 access modifiers in c#
        - public
        - Private
        - Internal
        - Protected
        - Protected Internal

    - Public fields are available everywhere
    - Private fields are available only in the type scope
    - Protected are available in the type scope and the types which derives this basee type
*/

namespace AccessModifiers
{

    class Supervisor
    {
        private int _id;   // accessable only in this class
        protected string _name = "No Name";  // Accessable only in this class and the classes which derive this class
        public readonly static string position = "Supervisor"; // Possible to access from anywhere

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        protected string Name
        {
            get { return _name ?? "No Name"; }
            set { _name = value; }

        }
    }

    class Employee : Supervisor
    {
        // Cannot access _id here as the field is private.
        // Can access _name here as this class derive supervisor class

        public void print()
        {
            Console.WriteLine("From derived class method - " + this._name);

            // Or 
            Employee emp = new Employee();
            Console.WriteLine("From derived class method - " + emp._name);

            // Or 
            Console.WriteLine("From derived class method - " + base._name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.print();
            Console.WriteLine("from Main method - " + Supervisor.position);
        }
    }
}