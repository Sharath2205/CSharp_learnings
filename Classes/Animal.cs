using System;

/* 
    Class: 
    - Blueprint of an real world object
    - Contains fields (Variables) -> represents state and methods -> represents behaviour
*/


public class Animal
{
    //  Fields

    public string Name; 
    public string AnimalType;
    public int Age;
    public string Sound;


    /*
        Constructor:
        - Special method with same name as class
        - Used to initialise newly created object and its fields 
        - *** If not defined, compiler generates one default constructor with no parameters
    */

    public Animal(string name, string AnimalType, int age, string sound)
    {
        this.Name = name;
        this.AnimalType = AnimalType;
        this.Age = age;
        this.Sound = sound;
    }


    // Methods: Determines the behaviour of the object
    public void PrintSound()
    {
        Console.WriteLine($"{this.Name} says {this.Sound}");
    }

    public void PrintAge()
    {
        Console.WriteLine($"This {this.AnimalType} is {this.Age} years old");
    }

    public void PrintName()
    {
        Console.WriteLine($"This {AnimalType} name is {Name}");
    }
}
