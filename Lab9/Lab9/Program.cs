using System;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 1, 4, 7, 8, 11, 20 };
            List<int> list2 = new List<int> { 2, 3, 4, 5, 10, 15, 16, 21, 22 };

            List<int> combinedList = Lab9.MergeLists(list1, list2);
            List<int> expectedList = new List<int> { 1, 1, 2, 3, 4, 4, 5, 7, 8, 10, 11, 15, 16, 20, 21, 22 };

            Console.WriteLine($"[ {string.Join(", ", combinedList)} ]");

            for (int i = 0; i < expectedList.Count; i++)
            {
                Debug.Assert(expectedList[i] == combinedList[i]);
            }

            Console.WriteLine("End of the Test");
        }
    }
}
