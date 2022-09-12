using System;

namespace LightningTalkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Input
            int num;
            Console.Write("Enter a number: ");
            num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} is {1}", num, OddOrEven(num));
            Console.ReadKey();
        }

        static string OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
    }
}
