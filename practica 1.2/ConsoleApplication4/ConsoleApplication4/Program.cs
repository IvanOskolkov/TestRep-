using System;

class Program
{
    static void Main()
    {
        int[,] temperatures = new int[12, 30];
        Random random = new Random();

        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperatures[month, day] = random.Next(-20, 40); 
            }
        }

        int[] averageTemperatures = CalculateAverageTemperatures(temperatures);

        Console.WriteLine("Средние температуры по месяцам:");
        for (int month = 0; month < 12; month++)
        {
            Console.WriteLine($"Месяц {month + 1}: {averageTemperatures[month]}°C");
        }

        Array.Sort(averageTemperatures);

        Console.WriteLine("\nОтсортированные средние температуры:");
        foreach (int averageTemperature in averageTemperatures)
        {
            Console.Write(averageTemperature + "°C ");
        }
    }

    static int[] CalculateAverageTemperatures(int[,] temperatures)
    {
        int[] averageTemperatures = new int[12];

        for (int month = 0; month < 12; month++)
        {
            int totalTemperature = 0;
            for (int day = 0; day < 30; day++)
            {
                totalTemperature += temperatures[month, day];
            }
            averageTemperatures[month] = totalTemperature / 30;
        }

        return averageTemperatures;
    }
}