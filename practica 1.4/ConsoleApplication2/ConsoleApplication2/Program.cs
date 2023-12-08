using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] numbers = File.ReadAllText("numsTask2.txt").Split(';');
        double sum = 0;

        foreach (string number in numbers)
        {
            double currentNumber;
            if (double.TryParse(number, out currentNumber))
            {
                if (currentNumber > 0)
                {
                    sum += currentNumber;
                }
                if (currentNumber == 0)
                {
                    break;
                }
            }
        }

        Console.WriteLine($"Сумма положительных элементов последовательности до 0: {sum}");
    }
}