using System;

namespace M5U3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void SortArray(in int[] array, out int[] sortedasc, out int[] sorteddesc)
        {
            sortedasc = SortArrayAsc(array);
            sorteddesc = SortArrayDesc(array);
        }

        static int[] SortArrayAsc(int[] array)
        {
            int temp;
            for(int i = 0; i < array.Length; i++)
                for(int j = i + 1; j < array.Length; j++)
                    if(array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            return array;
        }

        static int[] SortArrayDesc(int[] array)
        {
            int temp;
            for(int i = 0; i < array.Length; i++)
                for(int j = i + 1; j < array.Length; j++)
                    if(array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            return array;
        }
    }
}
