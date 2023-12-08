using System; 

class Program 
{
    static void Main() 
    {
        string[] lines = System.IO.File.ReadAllLines("numsTask1.txt");

        int[] numbers = Array.ConvertAll(lines[0].Split(' '), int.Parse); 

        int minIndex = 0; 
        for (int i = 1; i < numbers.Length; i++) 
        {
            if (numbers[i] < numbers[minIndex])
            {
                minIndex = i;
            }
        }

        long product = 1; 
        for (int i = minIndex + 1; i < numbers.Length; i++)
        {
            product *= numbers[i]; 
        }

        Console.WriteLine($"Произведение элементов после минимального: {product}");
    }
}