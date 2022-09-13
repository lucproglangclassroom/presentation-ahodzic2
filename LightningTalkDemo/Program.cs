using System;

namespace LightningTalkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while (true) {
                //User Input
                Console.Write("Enter a number: ");
                num = Int32.Parse(Console.ReadLine());

                Console.WriteLine("{0} is {1}", num, OddOrEven(num));
            }
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
