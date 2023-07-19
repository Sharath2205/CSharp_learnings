using System;

class Program
{
    static void Main(string[] args)
    {

        //Creating an object of type animal
        Animal dog = new Animal("Henry", "Dog", 5, "Grrrrrr");

        dog.PrintSound();
        dog.PrintName();
        dog.PrintAge();

        Console.WriteLine("-----------");

        //Creating another object of type animal

        Animal cat = new Animal("Fluffy", "Cat", 2, "Meow");
        cat.PrintName();
        cat.PrintAge();
        cat.PrintSound();
    }
}