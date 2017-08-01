//using System;
//using System.Collections.Generic;
//using System.IO;
//class Solution
//{
//    static void Main(String[] args)
//    {
//        var t = Convert.ToInt32(Console.ReadLine());
//        var testCases = new int[t];
//        for (int i = 0; i < t; i++)
//        {
//            testCases[i] = Convert.ToInt32(Console.ReadLine());
//            var testCase = testCases[i];
//            FindWinner(testCase);
//        }
//    }

//    private static void FindWinner(int stoneNumber)
//    {
//        if (stoneNumber < 2)
//        {
//            Console.WriteLine("Second");
//            return;
//        }
//        bool firstPlayerMoves = false;
//        do
//        {
//            firstPlayerMoves = !firstPlayerMoves;
//            stoneNumber = MakeMove(stoneNumber);
//        } while (stoneNumber > 1);

//        if (firstPlayerMoves)
//            Console.WriteLine("First");
//        else
//            Console.WriteLine("Second");
//    }

//    private static int MakeMove(int stoneNumber)
//    {
//        switch (stoneNumber % 5)
//        {
//            case 0:
//                if (stoneNumber == 5)
//                    return stoneNumber - 5;
//                return stoneNumber - 3;
//            case 1:
//            case 4:
//                return stoneNumber - 5;
//            case 2:
//                return stoneNumber - 2;
//            case 3:
//                return stoneNumber - 3;
//        }
//        return stoneNumber;
//    }
//}