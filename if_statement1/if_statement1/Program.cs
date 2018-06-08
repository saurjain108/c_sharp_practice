using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Enter a number");
        int i = int.Parse(Console.ReadLine());

        if(i ==1)
        {
            Console.WriteLine("this is number {0}", i);
            Console.ReadLine();
        }
 else   if (i ==2 )
        {
            Console.WriteLine("this is number {0}", i);
            Console.ReadLine();
        }

 else   if (i == 3)
        {
            Console.WriteLine("this is number {0}", i);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Try either 1 or 2 or 3"); 
            Console.ReadLine();
        }
        }
    }
