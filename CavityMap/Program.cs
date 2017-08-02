using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] grid = new string[n];
        string[] result = new string[n];
        for (int grid_i = 0; grid_i < n; grid_i++)
        {
            grid[grid_i] = Console.ReadLine();
        }
        result = (string[])grid.Clone();
        for (var i = 1; i < n - 1; i++)
            for (var j = 1; j < n - 1; j++)
            {
                if (CheckCellDepth(grid, i, j))
                {
                    var sb = new StringBuilder(result[i]);
                    sb[j] = 'X';
                    result[i] = sb.ToString();
                }
            }
        Array.ForEach(result, Console.WriteLine);
    }

    //static void Main(String[] args)
    //{
    //    var file = new StreamReader("seed_data.txt");
    //    int n = Convert.ToInt32(file.ReadLine());
    //    string[] grid = new string[n];
    //    string[] result = new string[n];
    //    for (int grid_i = 0; grid_i < n; grid_i++)
    //    {
    //        grid[grid_i] = file.ReadLine();
    //    }
    //    result = (string[])grid.Clone();
    //    for (var i = 1; i < n - 1; i++)
    //        for (var j = 1; j < n - 1; j++)
    //        {
    //            if (CheckCellDepth(grid, i, j))
    //            {
    //                var sb = new StringBuilder(result[i]);
    //                sb[j] = 'X';
    //                result[i] = sb.ToString();
    //            }
    //        }
    //    Array.ForEach(result, Console.WriteLine);
    //}


    //static void Main(String[] args)
    //{
    //    var file = new StreamReader("seed_data.txt");
    //    int n = Convert.ToInt32(file.ReadLine());
    //    char[,] matrix = new char[n, n];
    //    for (int i = 0; i < n; i++)
    //    {
    //        string line = file.ReadLine();
    //        for (int j = 0; j < n; j++)
    //            matrix[i, j] = line[j];
    //    }
    //    for (int i = 1; i < n - 1; i++)
    //    {
    //        for (int j = 1; j < n - 1; j++)
    //        {
    //            char val = matrix[i, j];
    //            if (matrix[i - 1, j] < val && matrix[i, j - 1] < val &&
    //               matrix[i, j + 1] < val && matrix[i + 1, j] < val)
    //                matrix[i, j] = 'X';
    //        }
    //    }
    //    for (int i = 0; i < n; i++)
    //    {
    //        for (int j = 0; j < n; j++)
    //            Console.Write(matrix[i, j]);
    //        Console.WriteLine();
    //    }
    //}
    public static bool CheckCellDepth(string[] grid, int row, int col)
    {
        if (String.CompareOrdinal(grid[row - 1][col].ToString(), grid[row][col].ToString()) < 0 &&
            String.CompareOrdinal(grid[row][col - 1].ToString(), grid[row][col].ToString()) < 0 &&
            String.CompareOrdinal(grid[row + 1][col].ToString(), grid[row][col].ToString()) < 0 &&
            String.CompareOrdinal(grid[row][col + 1].ToString(), grid[row][col].ToString()) < 0)
            return true;
        return false;
    }
}
