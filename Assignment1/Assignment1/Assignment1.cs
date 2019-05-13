using System;
using System.IO;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output)
        {
            output.WriteLine("         oct        dec      hex");
            output.WriteLine("------------ ---------- --------");

            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(input.ReadLine());

                string strHex = Convert.ToString(number, 16);
                string strOct = Convert.ToString(number, 8);

                output.WriteLine("{0, 12} {1, 10} {2, 8}", strOct, number, strHex);
            }
        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            float minFloat = float.MaxValue;
            float maxFloat = float.MinValue;
            float sum = 0.0f;
            float average = 0.0f;

            for (int i = 0; i < 5; i++)
            {
                float number = float.Parse(input.ReadLine());
                if (number > maxFloat)
                {
                    maxFloat = number;
                }
                if (number < minFloat)
                {
                    minFloat = number;
                }

                sum += number;

                string floatNumber = string.Format("{0:f3}", number);
                output.WriteLine("{0, 20}", floatNumber);
            }
            average = sum / 5;

            string minStr = string.Format("{0:f3}", minFloat);
            string maxStr = string.Format("{0:f3}", maxFloat);
            string sumStr = string.Format("{0:f3}", sum);
            string averageStr = string.Format("{0:f3}", average);


            output.Write("Min");
            output.WriteLine("{0, 17}", minStr);
            output.Write("Max");
            output.WriteLine("{0, 17}", maxStr);
            output.Write("Sum");
            output.WriteLine("{0, 17}", sumStr);
            output.Write("Average");
            output.WriteLine("{0, 13}", averageStr);
        }
    }
}