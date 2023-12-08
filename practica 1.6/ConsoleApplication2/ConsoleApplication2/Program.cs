using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "numsTask2.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] words = reader.ReadToEnd().Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                
                string resultString = string.Join(" ", words);

                Console.WriteLine("Результат: " + resultString);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}
