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

            totalPrice = (totalPrice * 100 + 0.5) / 100;

            totalPrice = Math.Truncate(totalPrice * 100) / 100;

            return totalPrice;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            int people = int.Parse(input.ReadLine());

            totalCost = totalCost / people;

            totalCost = (totalCost * 100 + 0.5) / 100;

            totalCost = Math.Truncate(totalCost * 100) / 100;

            return totalCost;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            double perPrice = double.Parse(input.ReadLine());

            if(totalCost % perPrice == 0)
            {
                return (uint)(totalCost / perPrice);
            }


            return (uint)(totalCost / perPrice) + 1;
        }
    }
}