using System;

namespace FinancialForecasting
{
    class Program
    {
        // Recursive method to calculate future value
        static double FutureValue(double amount, double rate, int years)
        {
            if (years == 0)
            {
                return amount;
            }

            return FutureValue(amount * (1 + rate), rate, years - 1);
        }

        static void Main(string[] args)
        {
            double amount = 10000;
            double growthRate = 0.10;   // 10%
            int years = 5;

            double result = FutureValue(amount, growthRate, years);

            Console.WriteLine("Financial Forecast");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Initial Amount : " + amount);
            Console.WriteLine("Growth Rate    : " + (growthRate * 100) + "%");
            Console.WriteLine("Years          : " + years);
            Console.WriteLine("Future Value   : " + result);
        }
    }
}