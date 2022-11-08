using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
