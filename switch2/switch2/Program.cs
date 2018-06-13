using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter the color: ");
        string color = Console.ReadLine();
        //Console.ReadLine();
        if (color == "red")
        {
            Console.WriteLine("your favorite color is Red");
            Console.ReadLine();

        }

        else if (color == "pink")
        {
            Console.WriteLine("your favorite color is pink");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("you do not have favourite color");
            Console.ReadLine();
        }
        }
    }
