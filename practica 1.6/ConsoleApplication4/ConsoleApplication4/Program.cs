using System;  

class Program
{
    static void Main()
    {
        int sum = 0;
        
        Console.Write("Введите положительное число a: ");
        
        if (int.TryParse(Console.ReadLine(), out int a) && a > 0)
        {
            while (true)
            {
                Console.Write("Введите положительное число (для завершения введите отрицательное число): ");
                
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number < 0)
                    {
                        break;
                    }
                    
                    if (number % a == 0)
                    {
                        sum += number;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите корректное число.");
                }
            }
            
            Console.WriteLine($"Сумма чисел, делящихся на {a} нацело: {sum}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите корректное положительное число.");
        }
    }
}