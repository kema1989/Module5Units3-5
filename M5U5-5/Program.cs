using System;

namespace M5U5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основание степени:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите показатель степени:");
            byte y = byte.Parse(Console.ReadLine());
            Console.WriteLine($"{x}^{y}={PowerUp(x, y)}");
        }

        private static long PowerUp(int x, byte y)
        {
            if(y == 0)
            {
                return 1;
            }
            else if(y == 1)
            {
                return x;
            }
            else
            {
                return x * PowerUp(x, --y);
            }
        }
    }
}
