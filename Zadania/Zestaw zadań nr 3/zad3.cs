using System;
namespace Exercise
{
    class Program
    {
        static double RectangleDiagonalLength(int a, int b)
        {
            a *= a;
            b *= b;
            double result = Math.Sqrt(a+b);
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(RectangleDiagonalLength(3, 5));
        }
    }
}