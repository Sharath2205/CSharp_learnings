using StaticAndInstanceMembers;
using System;


/*
    Instance Variables:
    - Property of an instance.
    - An instance variable is created everytime an instance is created.
    - Used to store a value that represents property of single instance.
    - Accessed using objects.
    
    Static Variable:
    - Variables are property of the class.
    - Created only once when the classloader loads the class.
    - Accessed only using class Name.
*/
class Program
{
    static void Main()
    {
        Student virat = new Student("Virat", "Kohli", 1, 24);
        Student rohit = new Student("Rohit", "Sharma", 2, 28);
        Student rahul = new Student("KL", "Rahul", 3, 21);

        virat.GetDetails();
        rohit.GetDetails();
        rahul.GetDetails();

        Student.GetNoOfStudents();
        
    }
}