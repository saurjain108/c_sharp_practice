using System;

    class Program
    {
        static void Main(string[] args)
        {

        //below code proves that there is no need of casting while converting int to float as float is bigger than int

        /*int i = 111;
        float f = i;
        Console.WriteLine(f);
        Console.ReadLine();*/

        /*   float f = 1.334F;
           int i = (int)f;// This will print only the integer 
           int j = Convert.ToInt32(f); // This will also convert it into integer
           Console.WriteLine(i);
           Console.WriteLine(j);
           Console.ReadLine(); */

// the code given below is demonstration of int.parse()
        string number = "111";
        int i = int.Parse(number);
        Console.WriteLine(i);
        Console.ReadLine();



    }
}
