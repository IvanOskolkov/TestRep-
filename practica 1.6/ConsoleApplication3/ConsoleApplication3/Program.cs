using System;  

class Program
{
    static void Main()
    {
        
        Console.Write("Введите число: ");
        string userInput = Console.ReadLine();
        
        if (int.TryParse(userInput, out int number))
        {
            if (IsEvenAndMultipleOfTen(number))
            {
                Console.WriteLine("Число четное и кратное 10.");
            }
            else
            {
                Console.WriteLine("Число не четное или не кратное 10.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите корректное число.");
        }
    }
    
    static bool IsEvenAndMultipleOfTen(int num)
    {
        return num % 2 == 0 && num % 10 == 0;
    }
}