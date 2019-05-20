using System;

namespace EvenOddNumber
{
    class Program
    {
        // This program will find the number is even or odd
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number = ");
            int num = int.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }
        }
    }
}
