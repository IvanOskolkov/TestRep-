using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string inputString = Console.ReadLine();

        string[] words = inputString.Split(' ');
        int wordCount = words.Length;

        string resultString = "Start " + inputString + " End";

        Console.WriteLine("Результат: " + resultString);
        Console.WriteLine("Количество слов в предложении: " + wordCount);
    }
}