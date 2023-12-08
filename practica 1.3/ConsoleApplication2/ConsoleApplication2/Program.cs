using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "nums.txt";
        
        string outputFilePath = "filtered_nums.txt";
        
        try
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (string line in lines)
                {
                    string[] numbers = line.Split(' ');
                    
                    foreach (string number in numbers)
                    {
                        if (int.TryParse(number, out int num))
                        {
                            if (num % 2 != 0)
                            {
                                writer.Write(num + " ");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Ошибка при преобразовании строки в число: {number}");
                        }
                    }
                    writer.WriteLine();
                }
            }
            Console.WriteLine("Четные числа удалены. Результат сохранен в файле: " + outputFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}