using System; 

class Program 
{
    static void Main() 
    {
        string[] lines = System.IO.File.ReadAllLines("numsTask3.txt");
        int[] numbers = Array.ConvertAll(lines[0].Split(' '), int.Parse); 

        int minIndex = 0; 
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < numbers[minIndex]) 
            {
                minIndex = i; 
            }
        }

        double sum = 0; 
        for (int i = 0; i < minIndex; i++) 
        {
            sum += numbers[i]; 
        }

        double average = sum / minIndex; 

        Console.WriteLine($"Среднее арифметическое элементов до минимального: {average}"); 
    }
}