using System;

partial class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = random.Next(1, 100); 
        }
        
        Console.Write("Массив: ");
        foreach (var number in numbers) 
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
        
        int minIndex = 0;
        for (int i = 1; i < 10; i++)
        {
            if (numbers[i] < numbers[minIndex])
            {
                minIndex = i;
            }
        }
        
        minIndex += 1;
        
        Console.WriteLine($"Номер минимального элемента: {minIndex}");
    }
}