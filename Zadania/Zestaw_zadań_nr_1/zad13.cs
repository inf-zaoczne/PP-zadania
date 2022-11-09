using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c: ");
            int c = int.Parse(Console.ReadLine());
            // obliczenia
            double math1 = c - b;
            if (math1 % 2 == 0)
            {
                double result = math1 / a;
                Console.WriteLine("X = " + result);
            }
            else
            {
                double result = math1 / a;
                Console.WriteLine("X (w przybliżeniu) = " + Math.Round(result, 2));
            }
        }
    }
}
