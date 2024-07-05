using System;

namespace homeWorkLocalHighs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int arraySize = 30;

            Random random = new Random();

            int minRangeValue = 0;
            int maxRangeValue = 21;

            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(minRangeValue, maxRangeValue);
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");

            if (array[0] > array[1])
            {
                Console.WriteLine("начальный максимум - " + array[0] + "\n");
            }
            if (array[arraySize - 1] > array[arraySize - 2])
            {
                Console.WriteLine("конечный максимум - " + array[arraySize - 1] + "\n");
            }

            Console.Write("максимумы: ");

            for (int i = 1; i < arraySize - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine("\n");
        }
    }
}
