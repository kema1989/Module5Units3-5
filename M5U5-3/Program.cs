using System;

namespace M5U5_3
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

        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if(modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.WriteLine("..." + modif);

            Console.BackgroundColor = (ConsoleColor)deep;

            Console.WriteLine("..." + modif);

            if(deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}
