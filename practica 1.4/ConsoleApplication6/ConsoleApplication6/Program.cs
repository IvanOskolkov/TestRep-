using System;
using System.Globalization;


namespace Program5
{
    class Program5
    {
        public static void Main()
        {
            Console.WriteLine("Введите число a: "); // x
            float numA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Введите число b: "); // y
            float numB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          
            if (( ((numB - 2) / 2.5f) <= numA && ((numB - 2) / -2.5f) >= numA ) && (numB >= -3 && numB <= 2)) 
            {
                Console.WriteLine("Точка входит в эту область");
            }
            else
            {
                Console.WriteLine("Точка не входит в эту область");
            }
        }
    }
}