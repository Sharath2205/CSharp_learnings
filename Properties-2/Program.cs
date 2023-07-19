using System;

/*
    Goals:
    - Creating fields with read/write properties
    - Creating fields with only read properties
    - Creating fielss with only write properties
    - Creating Auto implemented properites
*/

/*
    - In C# we use properties to encapsulate and protect fields.
    - We use get and set accessors to implement properties
    - A property with both get and set accessors will have READ and WRITE properties
    - A property with set accessor will have WRITE property
    - A property with get accessor will have READ property 
*/

class Student
{

    string? _name;
    //int _age;  // To use Auto implemented properties we dont need to use this. Only to reduce code.
    int _id;
    int _passingMarks = 35;

    // read and write operations for name
    public string Name { 
        get {
            return !String.IsNullOrEmpty(this._name) ? this._name : "No Name";
        }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Name cannot be empty or null.");
            
            this._name = value;
        }
    }

    // Read and write operations for id
    public int Id
    {
        set
        {
            if (value < 1)
                throw new Exception("Id should not be less than 1");
            
            this._id = value;
        }
        get { return this._id; }
    }

    // Only read operations for Passing marks 
    public int PassingMarks
    {
        get { return this._passingMarks; }
    }

    // Auto implemented properties
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student stu = new Student();

        stu.Name = "Student 1";
        stu.Age = 10;
        stu.Id = 1;

        Console.WriteLine($"Name : {stu.Name}\nAge: {stu.Age}\nId: {stu.Id}\nPassing Marks: {stu.PassingMarks}");
    }
}