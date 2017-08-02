using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine());
        var testCases = new int[t];
        for (int i = 0; i < t; i++)
        {
            testCases[i] = Convert.ToInt32(Console.ReadLine());
            var testCase = testCases[i];
            if (testCase % 7 == 0 || testCase % 7 == 1)
                Console.WriteLine("Second");
            else
            {
                Console.WriteLine("First");
            }
            //var memory = new string[101];
            //var winner = FindWinner(testCase, memory);
            //Console.WriteLine(winner);
        }
    }

    private static string FindWinner(int stoneNumber, String[] memory)
    {
        if (stoneNumber == 1)
            return "Second";
        if (2 <= stoneNumber && stoneNumber <= 5)
        {
            return "First";
        }
        if (!string.IsNullOrEmpty(memory[stoneNumber]))
            return memory[stoneNumber];

        if ((FindWinner(stoneNumber - 5, memory) == "First") && (FindWinner(stoneNumber - 3, memory) == "First")
            && (FindWinner(stoneNumber - 2, memory) == "First"))
        {
            memory[stoneNumber] = "Second";
        }
        else
        {
            memory[stoneNumber] = "First";
        }
        return memory[stoneNumber];
    }

   
}