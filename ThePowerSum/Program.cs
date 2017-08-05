//using System;
//using System.Collections;
//using System.Collections.Generic;
//using static System.Math;

//namespace ThePowerSum
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var x = Convert.ToInt32(Console.ReadLine());
//            var n = Convert.ToInt32(Console.ReadLine());

//            var result = FindPower(x, n, 0);
//            Console.WriteLine(result);
//        }

//        private static int FindPower(int x, int n, int counter)
//        {
//            var sqrtCeiling = (int)Ceiling(Sqrt(x));
//            if (x.Equals(sqrtCeiling * sqrtCeiling))
//                counter++;

//            var permutations = GetPermutations(sqrtCeiling);
//            foreach (var permutation in permutations)
//            {
//                var sum = 0;
//                foreach (var permValue in permutation)
//                {
//                    sum += (int)Pow(permValue, 2);
//                }
//                if (sum == x)
//                    counter++;
//            }

//            return counter;
//        }

//        private static HashSet<int>[] GetPermutations(int sqrtCeiling, HashSet<int>[] permutations)
//        {
//            if (sqrtCeiling == 3)
//            {
//                permutations.
//            }
//        }
//    }
//}