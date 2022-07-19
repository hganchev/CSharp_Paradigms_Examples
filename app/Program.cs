using System;
namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            OOP.Flowers myFlower = new OOP.Flowers(); // example of instantiation of the object(class)
            Console.WriteLine(myFlower.Color);
            myFlower.LeafsCount();
            myFlower.AddWater();

            OOP.Rose myRose = new OOP.Rose(); // example of instantiation chiled class
            Console.WriteLine(myRose.Color);
            myRose.LeafsCount();

            OOP.Orchid myOrchid = new OOP.Orchid(); // example of instantiation chiled class
            Console.WriteLine(myOrchid.Color);
            myOrchid.LeafsCount();

            OOP.Daisy myDaisy = new OOP.Daisy(); // example of instantiation chiled class
            Console.WriteLine(myDaisy.Color);
            myDaisy.AddWater();
        }
    }
}