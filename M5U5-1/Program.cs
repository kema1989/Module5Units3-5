using System;

namespace M5U5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-нибудь:");

            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эхо:");

            byte deep = Convert.ToByte(Console.ReadLine());

            for(int i = 0; i < deep; i++)
            {
                Echo(str);
            }
        }

        static void Echo(string str)
        {
            Console.WriteLine(str);
        }
    }
}
