using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();
        
        Console.WriteLine("Введите слова. Для завершения введите пустую строку:");
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;

            words.Add(input);
        }
        
        string shortest = string.Empty;
        string longest = string.Empty;

        foreach (string word in words)
        {
            if (string.IsNullOrEmpty(shortest) || word.Length < shortest.Length)
                shortest = word;

            if (string.IsNullOrEmpty(longest) || word.Length > longest.Length)
                longest = word;
        }
        
        Console.WriteLine("Самое короткое слово: " + shortest);
        Console.WriteLine("Самое длинное слово: " + longest);
    }
}