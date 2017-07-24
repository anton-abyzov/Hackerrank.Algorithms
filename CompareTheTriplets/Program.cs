using System;

namespace CompareTheTriplets
{
    class Program
    {
        private static int _alicePoints;
        private static int _bobPoints;

        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            _alicePoints = 0;
            _bobPoints = 0;
            CompareTriples(a0, b0);
            CompareTriples(a1, b1);
            CompareTriples(a2, b2);
            return new[]{ _alicePoints, _bobPoints};
        }

        private static void CompareTriples(int alicePoint, int bobPoint)
        {
            if (alicePoint > bobPoint)
                _alicePoints++;
            if (alicePoint < bobPoint)
                _bobPoints++;
        }

        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}