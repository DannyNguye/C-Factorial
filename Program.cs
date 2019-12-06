using System;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            int i, total = 1, number;
            
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                total = total * i;
            }
            Console.Write(total);

            // int factorial_func(int number)
            // {
            //     int total = 1;
            //     while (number != 1)
            //     {
            //         total = total * number;
            //         number = number - 1;
            //     }
            //     return total;
            // }

            // Console.Write(factorial_func(4));
        }
    }
}

