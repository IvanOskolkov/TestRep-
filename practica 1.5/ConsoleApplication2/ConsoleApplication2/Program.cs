using System; 
using System.Linq;

class Program 
{
    static void Main()
    {
        string[] lines = System.IO.File.ReadAllLines("numsTask2.txt"); 
        string[] numbersString = lines[0].Split(';'); 
        double[] numbers = Array.ConvertAll(numbersString, double.Parse); 

        Array.Sort(numbers); 

        string sortedNumbers = string.Join(";", numbers); 

        System.IO.File.WriteAllText("numsTask2.txt", sortedNumbers);

        Console.WriteLine("Числа были отсортированы и записаны обратно в файл"); 
    }
}