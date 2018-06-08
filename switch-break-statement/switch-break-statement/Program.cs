using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int i = int.Parse(Console.ReadLine());
        switch (i)
        {
            case 10:
                Console.WriteLine("your number is 10");
                Console.ReadLine();
                break;
            case 20:
                Console.WriteLine("your number is 20");
                Console.ReadLine();
                break;
            case 30:
                Console.WriteLine("your number is 30");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("your number is not 10 ,20 or 30");
                Console.ReadLine();
                break; 


        }

        
       
    }
}
