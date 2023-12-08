using System;

class Program
{
    static void Main()
    {
        int[] oddNumbers = new int[100];
        int currentValue = 1; // Начинаем с числа 1
        for (int i = 0; i < oddNumbers.Length; i++)
        {
            oddNumbers[i] = currentValue;
            currentValue += 2;
        }

        Console.WriteLine("Массив последовательных нечетных чисел:");
        foreach (int number in oddNumbers)
        {
            Console.Write(number + " ");
        }
    }
}    