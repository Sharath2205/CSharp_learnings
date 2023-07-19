using System;

namespace StaticAndInstanceMembers
{
    class Student
    {
        public string? FirstName;
        public string? LastName;
        public int Id;
        public int Age;
        static int NoOfStudents = 0;

        public Student(string firstName, string lastName, int Id, int Age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = Id;
            this.Age = Age;
            NoOfStudents++;
        }

        public void GetDetails()
        {
            Console.WriteLine($"First name: {this.FirstName} \nLast name: {this.LastName} \nId: {this.Id} \nAge: {this.Age}\n");
        }

        public static void GetNoOfStudents()
        {
            Console.WriteLine("No of students registered: {0}", NoOfStudents);
        }
    }
}
