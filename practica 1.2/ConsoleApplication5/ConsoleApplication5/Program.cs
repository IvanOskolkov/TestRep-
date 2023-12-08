using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int[]> monthlyTemperatures = new Dictionary<string, int[]>();
        Random random = new Random();

        for (int month = 1; month <= 12; month++)
        {
            int[] temperatures = new int[30];
            for (int day = 0; day < 30; day++)
            {
                temperatures[day] = random.Next(-20, 40);
            }
            monthlyTemperatures.Add(GetMonthName(month), temperatures);
        }

        Dictionary<string, int> averageMonthlyTemperatures = CalculateAverageTemperatures(monthlyTemperatures);

        Console.WriteLine("Средние температуры по месяцам:");
        foreach (var kvp in averageMonthlyTemperatures)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}°C");
        }
    }

    static string GetMonthName(int month)
    {
        return new DateTime(2023, month, 1).ToString("MMMM");
    }

    static Dictionary<string, int> CalculateAverageTemperatures(Dictionary<string, int[]> monthlyTemperatures)
    {
        Dictionary<string, int> averageTemperatures = new Dictionary<string, int>();

        foreach (var kvp in monthlyTemperatures)
        {
            int totalTemperature = 0;
            foreach (int temperature in kvp.Value)
            {
                totalTemperature += temperature;
            }
            int averageTemperature = totalTemperature / kvp.Value.Length;
            averageTemperatures.Add(kvp.Key, averageTemperature);
        }

        return averageTemperatures;
    }
}