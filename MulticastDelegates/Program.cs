using System;

/*
    Multicast Delegate:
    - A delegate that has reference to more than 1 function is called multicast delegate.
    - If you invoke a multicast delegate all the functions pointed by that delegate will get invoked too.

    - To register a delegate: + or +=
    - To unregister a delegate: - or -=

    - Methods invoked are invoked in the same way they are added.
*/

public delegate void SampleDelegate();

namespace MulticastDelegates
{
    class Program
    {
        static void Main()
        {
            SampleDelegate MCSD1, Sd1, Sd2, Sd3; // Sd = sampledelegate, MCSD = Multi cast sample delegate
            Sd1 = new SampleDelegate(SampleMethodOne);
            Sd2 = new SampleDelegate(SampleMethodTwo);
            Sd3 = new SampleDelegate(SampleMethodThree);


            // Calling Sample methods one by one
            Sd1();Sd2();Sd3();


            Console.WriteLine("--------------");

            // Multicasting Delegate
            MCSD1 = Sd1 + Sd2 + Sd3;
            MCSD1();

            // Using -= for uscasting method 3
            MCSD1 -= SampleMethodThree;
            Console.WriteLine("---------------                      Removed method 3 using -= from MCSD1");
            MCSD1();

            Console.WriteLine("-------------                          Using '-' for uncasting method 2 from MCSD1");

            MCSD1 = MCSD1 - Sd2;
            MCSD1();

            // Or 


            Console.WriteLine("--------------                         Using += for multicasting");
            SampleDelegate MCSD2 = new SampleDelegate(SampleMethodOne);
            MCSD2 += SampleMethodTwo;
            MCSD2();
        }

        static void SampleMethodOne()
        {
            Console.WriteLine("sampple method One called");

        }

        static void SampleMethodTwo()
        {
            Console.WriteLine("sampple method Two called");

        }

        static void SampleMethodThree()
        {
            Console.WriteLine("sampple method Three called");

        }
    }
}