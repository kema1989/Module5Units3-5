using System;

namespace Module5Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            var someName = "Евгения";
            Console.WriteLine(someName);

            GetName(in someName);

            Console.WriteLine(someName);

            Console.ReadKey();
        }

        static void GetName(in string name)
        {
            Console.WriteLine("Введите свое имя:");
            name = Console.ReadLine();
        }
    }
}
