using System;

class Program
{
    static void Main() 
    {
        string[] lines = System.IO.File.ReadAllLines("numsTask4.txt"); 
        int[] numbers = Array.ConvertAll(lines[0].Split(' '), int.Parse); 

        int maxNumber = 0;

        foreach (int number in numbers) 
        {
            if (number > maxNumber) 
            {
                maxNumber = number; 
            }
        }

        int sum = 0;

        foreach (int number in numbers) 
        {
            if (Math.Abs(number - maxNumber) == 1) 
            {
                sum += number; 
            }
        }

        Console.WriteLine($"Сумма элементов, отличающихся от максимального на 1: {sum}"); 
    }
}