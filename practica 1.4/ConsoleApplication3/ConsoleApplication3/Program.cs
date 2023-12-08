using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] numbersStr = File.ReadAllText("numsTask3.txt").Split(',');
        int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            if (number == 0)
            {
                break;
            }
        }

        if (max == 0 || min == 0)
        {
            Console.WriteLine("В последовательности нет чисел до 0");
        }
        else
        {
            double ratio = (double) min / max;
            Console.WriteLine($"Отношение минимального и максимального элементов: {ratio}");
        }
    }
}