using System;
    class Program
    {
        static void Main()
        {
     int i, j;

        Console.WriteLine("Print the first number: ");
        i = int.Parse(Console.ReadLine());

        Console.WriteLine("print the second number: ");
        j= int.Parse(Console.ReadLine());

///     Console.ReadLine();

        Console.WriteLine("the sum of these two numbers is "+ (i + j));
        Console.WriteLine("the sub of these two numbers is " + (i - j));
        Console.WriteLine("the product of these two numbers is " + (i * j));
        Console.WriteLine("the division of these two numbers is "+ (i / j));

        Console.ReadLine();
        one();
        }
static void one()
    {
        int number = 21;

        bool num = number == 19 ? true : false;

        Console.WriteLine("number is {0}", number);
        Console.ReadLine();
            }

   }

