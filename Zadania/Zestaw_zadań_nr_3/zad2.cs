using System;
namespace Exercise
{
    class Program
    {
        static long Strong(int number)
        {
            long result = 1;
            int temp = 0;
            for (int i = 0; i < number; i++)
            {
                temp = number-i;
                result *= temp;
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Strong(17));

        }
    }
}