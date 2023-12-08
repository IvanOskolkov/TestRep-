using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Введите числа. Для завершения введите 0:");
        while (true)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0)
                break;

            numbers.Add(input);
        }

        int sum = 0;
        int product = 1;
        foreach (int number in numbers)
        {
            sum += number;
            product *= number;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine("Сумма всех элементов: " + sum);
        Console.WriteLine("Произведение всех элементов: " + product);
        Console.WriteLine("Среднее значение: " + average);
    }
}