using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите высоты столбцов через пробел:");
        string input = Console.ReadLine();
        
        string[] heightStrings = input.Split(' ');
        
        int[] height = new int[heightStrings.Length];
        
        for (int i = 0; i < heightStrings.Length; i++)
        {
            if (int.TryParse(heightStrings[i], out int h))
            {
                height[i] = h;
            }
            else
            {
                Console.WriteLine("Ошибка при преобразовании строки в число.");
                return;
            }
        }
        
        int maxArea = MaxArea(height);
        Console.WriteLine($"Наибольшая площадь контейнера: {maxArea}");
    }

    static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;    
        int right = height.Length - 1;   

        while (left < right)
        {
            int width = right - left;
            
            int h = Math.Min(height[left], height[right]);
            
            int area = width * h;
            
            maxArea = Math.Max(maxArea, area);
            
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}