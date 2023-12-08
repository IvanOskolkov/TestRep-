using System;
using System.Globalization;


namespace Program4
{
    class Program4
    {
        public static void Main()
        {
            Console.WriteLine("Введите число x: ");
            float numA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Введите число y: "); 
            float numB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ((numA >= -1 && numA <= 3) && (numB >= -2 && numB <= 4))
            {
                Console.WriteLine("Точка входит в заштрихованную область");
            }
            else
            {
                Console.WriteLine("Точка не входит в заштрихованную область");
            }
        }
    }
}