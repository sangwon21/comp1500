using System;
using System;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader READER = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter WRITER = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true })
            {
                Console.WriteLine("Enter your 5 digits for PrintIntegers():");
                Assignment1.PrintIntegers(READER, WRITER);

                Console.WriteLine("Enter your 5 digits for PrintStats():");
                Assignment1.PrintStats(READER, WRITER);
            }
        }
    }
}
