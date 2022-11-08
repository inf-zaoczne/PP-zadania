using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadź liczbę b:");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
