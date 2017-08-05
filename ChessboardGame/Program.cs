using System;

namespace ChessboardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var x = Convert.ToInt32(line[0]);
                var y = Convert.ToInt32(line[1]);
                var result = findWinner(x, y);
                Console.WriteLine(result);
            }
        }

        public static String findWinner(int x, int y)
        {
            x = x % 4;
            y = y % 4;
            if ((y == 0) || (y == 3) || (x == 0) || (x == 3)) return "First";
            return "Second";
        }
    }
}