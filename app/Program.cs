﻿using System;
namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // ========================= OOP Programming examples ============================================== 
            #region OOP Examples
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

            OOP.RoadBike myBike = new OOP.RoadBike(); // example of instantiation chiled class
            myBike.GetWeight();

            OOP.Magnolia myMagnolia = new OOP.Magnolia(); // example of instantiation chiled class
            myMagnolia.AddWater();
            myMagnolia.LeafsCount();

            OOP.WaterLevel myVar = OOP.WaterLevel.Medium; // You can access enum with dot syntax
            Console.WriteLine(myVar);
            #endregion
            // ========================= Functional Programming examples =======================================
            #region Functional Examples
            Functional.Functions.MyFunc f = Math.Sin;
            double y = f(4); //y=sin(4)
            Console.WriteLine(y);
            f = Math.Exp;
            y = f(4);        //y=exp(4) 
            Console.WriteLine(y);

            // Once you define function objects, you can assign them other existing functions as shown in the previous listings or other function variables. Also, you can pass them to other functions as standard variables. 
            // If you want to assign a value to a function, you have the following possibilities:
            // Point the function object to reference some existing method by name.
            // Create an anonymous function using the lambda expression or delegate and assign it to the function object.
            // Create a function expression where you can add or subtract a function and assign that kind of multicast 
            // delegate to the function object (described in the next section).
            Func<double, double> f1 = Math.Sin;
            Func<double, double> f2 = Math.Exp;
            double y1 = f1(6) + f2(10); //y1=sin(6) + exp(10)
            Console.WriteLine(y1);
            f2 = f1;
            y1 = f2(19);                //y1=sin(19) 
            Console.WriteLine(y1);

            //  Lambda expressions
            // Lambda expression must have part for definition of argument names - 
            // if lambda expression does not have parameters, empty brackets () should be placed. 
            // If there is only one parameter in the list, brackets are not needed. After => sign, 
            // you need to put an expression that will be returned.
            Func<double, double> f3 = delegate(double x) { return 3*x+1; };
            double y2 = f3(4); //y2=13    
            Console.WriteLine(y2);         
            f3 = x => 3*x+1;  // lambda expression of syntax  - parameters => return-expression
            y2= f3(5);        //y2=16 
            Console.WriteLine(y2);

            // Exaples of lambda expressions
            var f4 = () => 3;
            Console.WriteLine(f4());   
            var f5= () => DateTime.Now;
            Console.WriteLine(f5());   
            Func<int, int, int> f6 = (x, y) => x+y;
            Console.WriteLine(f6(1,2));   

            // attach methods to functions
            Func<string, int, string[]> extractMethod = ExtractWords;
            string title = "The Scarlet Letter";
            // Use delegate instance to call ExtractWords method and display result
            foreach (string word in extractMethod(title, 5))
            Console.WriteLine(word);

            // Actions 
            Action<string> action = Console.WriteLine;
            Action<string> hello = Hi;
            Action<string> goodbye = Bye;

            action += Hi; //Operator += is used for attaching new functions that will be called by the multicast delegate
            action += (x) => { Console.WriteLine("  Greating {0} from lambda expression", x); };

            action("First");
            #endregion
        }

        private static string[] ExtractWords(string phrase, int limit)
        {
            char[] delimiters = new char[] {' '};
            if (limit > 0)
                return phrase.Split(delimiters, limit);
            else
                return phrase.Split(delimiters);
        }

        static void Hi(string s)
        {
            System.Console.WriteLine("  Hi, {0}!", s);
        }

        static void Bye(string s)
        {
            System.Console.WriteLine("  Bye, {0}!", s);
        }
    }
}