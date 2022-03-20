using System;

namespace MasterClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 23;
            int sum = num1 + num2;
            Console.WriteLine($"num1 {num1}" + ", num2 " + num2);
            //int num3, num4, num5;

            ///<summary>
            ///
            /// 
            /// 
            /// </summary>

            //string test = "test";
            //test = Console.ReadLine();
            //Console.WriteLine(test);
            Console.WriteLine("---------------------------");

            Console.WriteLine("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered: " + readInput);
            Console.WriteLine("You have entered: {0}", readInput);

            Console.Write("Enter a string and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is: " + asciiValue);


        }
    }
}
