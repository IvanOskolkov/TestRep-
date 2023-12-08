using System;  

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int arrayLength = int.Parse(Console.ReadLine());
        
        double[] originalArray = new double[arrayLength];
        
        Random random = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            originalArray[i] = random.NextDouble() * (random.Next(2) == 0 ? -1 : 1);
        }
        
        double[] positiveArray = new double[arrayLength];
        double[] negativeArray = new double[arrayLength];
        
        int positiveIndex = 0;
        int negativeIndex = 0;
        
        for (int i = 0; i < arrayLength; i++)
        {
            if (originalArray[i] > 0)
            {
                positiveArray[positiveIndex] = originalArray[i];
                positiveIndex++;
            }
            else if (originalArray[i] < 0)
            {
                negativeArray[negativeIndex] = originalArray[i];
                negativeIndex++;
            }
        }
        
        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        Console.WriteLine("Положительные элементы:");
        PrintArray(positiveArray, positiveIndex);

        Console.WriteLine("Отрицательные элементы:");
        PrintArray(negativeArray, negativeIndex);
    }
    
    static void PrintArray(double[] arr, int length = -1)
    {
        if (length == -1)
        {
            length = arr.Length;
        }

        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
