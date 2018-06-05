using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string userinput = Console.ReadLine();

            int number1 = int.Parse(userinput);

            Console.Write("Enter the second number: ");
            userinput = Console.ReadLine();

            int number2 = int.Parse(userinput);

            int sum = number1 + number2;
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The sum is " + sum.ToString());

            Console.ReadLine();


        }
    }
}
