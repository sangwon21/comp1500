using System;
using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_DAYS = 15;

            uint[] usersPerDay = new uint[NUMBER_OF_DAYS] { 0, 3, 5, 10, 34, 66, 89, 100, 101, 321, 657, 1000, 1032, 4520, 6578 };
            double[] revenuePerDay = new double[NUMBER_OF_DAYS] { 0, 1.50, 2.50, 5.00, 81.80, 184.20, 257.80, 293.00, 341.25, 23111.25, 104591.25, 245993.00, 246001.00, 246873.00, 247387.50 };

            bool bFixed = Lab5.TryFixData(usersPerDay, revenuePerDay);
            Debug.Assert(!bFixed);

            revenuePerDay[0] = 10000.2;
            revenuePerDay[6] = 156;
            revenuePerDay[11] = 45628.34;

            bFixed = Lab5.TryFixData(usersPerDay, revenuePerDay);
            Debug.Assert(bFixed);
        }
    }
}
