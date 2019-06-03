using System;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return false;
            }

            bool bJudge = false;

            for (uint i = 0; i < usersPerDay.Length; i++)
            {
                double tmp = 0.0;

                if (usersPerDay[i] > 1000)
                {
                    tmp = 245743 + usersPerDay[i] / 4.0;
                    tmp = tmp * 100;
                    tmp += 0.5;
                    long temp = (long)tmp;
                    tmp = (double)temp / 100.0;
                }
                else if (usersPerDay[i] > 100)
                {
                    tmp = usersPerDay[i] * usersPerDay[i] / 4.0 - 2.0 * usersPerDay[i] - 2007;
                    tmp = tmp * 100;
                    tmp += 0.5;
                    long temp = (long)tmp;
                    tmp = (double)temp / 100.0;
                }
                else if (usersPerDay[i] > 10)
                {
                    tmp = 16 * usersPerDay[i] / 5.0 - 27;
                    tmp = tmp * 100;
                    tmp += 0.5;
                    long temp = (long)tmp;
                    tmp = (double)temp / 100.0;
                }
                else
                {
                    tmp = usersPerDay[i] / 2.0;
                    tmp = tmp * 100;
                    tmp += 0.5;
                    long temp = (long)tmp;
                    tmp = (double)temp / 100.0;
                }

                if (tmp != revenuePerDay[i])
                {
                    revenuePerDay[i] = tmp;
                    bJudge = true;
                }
            }

            return bJudge;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            int ans = 0;

            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return -1;
            }

            for (uint i = 0; i < usersPerDay.Length; i++)
            {
                double tmp = 0.0;

                if (usersPerDay[i] > 1000)
                {
                    tmp = 245743 + usersPerDay[i] / 4.0;
                    tmp = tmp * 100;
                    tmp += 0.5;
                    long temp = (long)tmp;
                    tmp = (double)temp / 100.0;
                }
                else if (usersPerDay[i] > 100)
                {
                    tmp = usersPerDay[i] * usersPerDay[i] / 4.0 - 2.0 * usersPerDay[i] - 2007;
                    tmp = tmp * 100;
                    tmp += 0.5;
                    long temp = (long)tmp;
                    tmp = (double)temp / 100.0;
                }
                else if (usersPerDay[i] > 10)
                {
                    tmp = 16 * usersPerDay[i] / 5.0 - 27;
                    tmp = tmp * 100;
                    tmp += 0.5;
                    long temp = (long)tmp;
                    tmp = (double)temp / 100.0;
                }
                else
                {
                    tmp = usersPerDay[i] / 2.0;
                    tmp = tmp * 100;
                    tmp += 0.5;
                    long temp = (long)tmp;
                    tmp = (double)temp / 100.0;
                }

                if (tmp != revenuePerDay[i])
                {
                    ans++;
                }
            }

            return ans;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            if(start > end)
            {
                return -1.0;
            }

            if(end > revenuePerDay.Length - 1)
            {
                return -1.0;
            }

            double sum = 0.0;

            for(uint i = start;i <= end; i++)
            {
                sum += revenuePerDay[i];
            }

            if(sum == 0.0)
            {
                sum = -1.0;
            }

            return sum;
        }
    }
}