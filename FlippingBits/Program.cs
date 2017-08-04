using System;

namespace FlippingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var value = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine(UInt32.MaxValue - value);
            }
        }
    }
}