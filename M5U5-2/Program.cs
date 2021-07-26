using System;

namespace M5U5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-нибудь:");

            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эхо:");

            var deep = Convert.ToInt32(Console.ReadLine());

            Echo(str, deep);
        }

        static void Echo(string phrase, int deep)
        {
            Console.WriteLine(phrase);
            if (deep > 1)
            {
                Echo(phrase, deep - 1);
            }
        }
    }
}
