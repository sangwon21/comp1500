using System.IO;
using System;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            double sum = 0.0;
            for(int i = 0; i < 5; i++)
            {
                string foodPrice = input.ReadLine(); // 사용자가 정수를 입력
                double price = double.Parse(foodPrice);
                sum += price;
            }

            double tax = sum * 0.05;

            string tipNumber = input.ReadLine();
            double tipPercent = double.Parse(tipNumber);

            double tip = (sum + tax) * tipPercent / 100;

            double totalPrice = sum + tax + tip;

            totalPrice = (totalPrice * 1000 + 0.5) / 1000;

            totalPrice = Math.Truncate(totalPrice * 100) / 100;

            return totalPrice;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            return 0;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            return 0;
        }
    }
}