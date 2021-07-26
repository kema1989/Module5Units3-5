using System;

namespace M5U5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{x}!={Factorial(x)}");
            Console.ReadKey();
        }

        static decimal Factorial(decimal x)
        {
            if(x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
