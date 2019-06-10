using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = getTestArray();

            int[,] rotated = Lab6.Rotate90Degrees(data);
            printArray(rotated);

        }

        private static int[,] getTestArray()
        {
            return new int[5, 6]
            {
                { 1, 2, 3, 4, 5, 6 },
                { 11, 12, 13, 14, 15, 16 },
                { 21, 22, 23, 24, 25, 26 },
                { 31, 32, 33, 34, 35, 36 },
                { 41, 42, 43, 44, 45, 46 }
            };
        }

        private static void printArray(int[,] data)
        {
            Console.WriteLine("---------------------------------");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0, -4} ", data[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------");
        }
    }
}
