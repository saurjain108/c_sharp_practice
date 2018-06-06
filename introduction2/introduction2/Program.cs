using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enter your name:  ");
        string x = Console.ReadLine();
        Console.WriteLine( x + ", you're exiting the terminal");
        Console.WriteLine("Have a good day {0}", x);
        Console.ReadLine();
    }
    }
