using System;

namespace M5U3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var someage = 27;
            Console.WriteLine(someage);

            ChangeAge();

            Console.WriteLine(someage);

            Console.ReadKey();
        }

        static void ChangeAge(int age = 19)
        {
            Console.WriteLine("Введите свой возраст:");
        }
    }
}
