using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[100];
        int currentValue = 297; 
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = currentValue;
            currentValue -= 3;
        }

        Console.WriteLine("Массив чисел в убывающем порядке:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}