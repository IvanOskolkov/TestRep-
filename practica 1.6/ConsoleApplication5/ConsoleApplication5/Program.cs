using System;  

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк в матрице (n): ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество столбцов в матрице (m): ");
        int m = int.Parse(Console.ReadLine());
        
        int[,] a = new int[n, m];
        
        Console.WriteLine("Введите элементы матрицы (0 или 1):");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        AddParityColumn(a, n, m);
        
        Console.WriteLine("Матрица с новым столбцом:");
        PrintMatrix(a, n, m + 1);
    }
    
    static void AddParityColumn(int[,] matrix, int numRows, int numCols)
    {
        for (int i = 0; i < numRows; i++)
        {
            int countOnes = 0;  
            
            for (int j = 0; j < numCols; j++)
            {
                if (matrix[i, j] == 1)
                {
                    countOnes++;
                }
            }
            
            if (countOnes % 2 != 0)
            {
                matrix[i, numCols - 1] = 1;
            }
        }
    }
    
    static void PrintMatrix(int[,] matrix, int numRows, int numCols)
    {
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
