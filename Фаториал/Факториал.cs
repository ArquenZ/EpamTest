using System;
using System.Numerics;


namespace Факториал
{
    class Program
    {
        static BigInteger Fact(uint a)
        {
            BigInteger b = 1;
            for (uint i = 2; i <= a; i++)
            {
                 b = b * i;
            }
            return b;
        }
        static void Main(string[] args)
        {            
            uint a = Convert.ToUInt32(Console.ReadLine());
            
            Console.WriteLine(Fact(a));
        }
    }
}
