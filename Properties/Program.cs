using System;

/*
    - If we use variables with public access specifier other users/people can change the field without permission and we can't use private fields
    - Solution to that problem is making the fields private and giving read-write/read only/write only permissions to that fields.
    - That can be acheived by using properties. Languages which cannot use properties use getter and setters methods to achieve that.

    Properties:
    - A property is a member/field that provides a flexible mechanism to read, write, or compute the value of a private field.
    - Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code.
    - Properties make use of get and set accessor properties to interact with the field.
*/


// Build a class which have name, id and passmarks as fields. 
// - Names should not be empty.
// - Id should only be Positive.
// - Passmarks should be 35 (Dont use const for Pass marks.
class Student
{


    private string? _name;
    private int _id;
    private int _passMarks = 35;

    public void SetName(String Name)
    {
        if(String.IsNullOrEmpty(Name))
        {
            throw new Exception("Name should not be empty");
        }
        this._name = Name;
    }
    public string GetName() { return this._name ?? "No Name"; }

    public void SetId(int Id)
    {
        if(Id < 1)
        {
            throw new Exception("Number should be less than 1");
        }
        this._id = Id;
    }

    public int GetId() { return this._id; }

    public int GetPassMarks() { return this._passMarks; }
}

class Program
{
    public static void Main(string[] args)
    {
        Student stu = new Student();
        stu.SetId(1);
        stu.SetName("Sharath");
        
        Console.WriteLine("Student Name:  " + stu.GetName());
        Console.WriteLine("Student Id:    " + stu.GetId());
        Console.WriteLine("Pass Marks:    " + stu.GetPassMarks());

        // If we try to access that fields directly we get a error for accessing private fields.
        //stu._passMarks = 0;


        // We cannot leave the name empty which will throw an exception.
        //stu.SetName("");

        // We cannot set the age less than 1.
        //stu.SetId(-1);

        // We cannot change passing marks as there is no setter method for it.
    }
}