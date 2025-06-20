using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Enter initial value (₹): ");
        double initialValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual growth rate (e.g., 0.1 for 10%): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter number of years to forecast: ");
        int years = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nFinancial Forecast:");
        for (int i = 0; i <= years; i++)
        {
            double forecastValue = Forecast(initialValue, rate, i);
            Console.WriteLine($"Year {i}: ₹{forecastValue:F2}");
        }
    }
    static double Forecast(double value, double rate, int year)
    {
        if (year == 0)
            return value;

        return Forecast(value * (1 + rate), rate, year - 1);
    }
}
