using System;

    class Program
    {
        static void Main(string[] args)
        {

        ///  int b = null;
        // the above line will not run as the integer cannot hold a null value 
        // now to get rid of the issue, just use "?" after the datatype. In our case it is int. 
        ///?b = null;

        bool?a = null;

        if (a == true)
        {
            Console.WriteLine("user wants to continue");
            Console.ReadLine();
                }
        else if (a == false)
        {
            Console.WriteLine("user does not wants to continue");
            Console.ReadLine();

        }
        else
        {
            Console.WriteLine("no option was chosen");
            Console.ReadLine();

        }
    }
        }




