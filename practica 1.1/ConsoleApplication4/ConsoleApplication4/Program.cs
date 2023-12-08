using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начало диапазона:");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите конец диапазона:");
        int end = Convert.ToInt32(Console.ReadLine());

        int[] randomNumberArray = GenerateRandomNumbers(start, end);
        PrintArray(randomNumberArray);
    }

    static int[] GenerateRandomNumbers(int start, int end)
    {
        Random random = new Random();
        int[] result = new int[10]; 

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = random.Next(start, end + 1); 
        }

        return result;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " "); 
        }
    }
}