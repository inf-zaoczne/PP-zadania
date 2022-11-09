using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            // string result = "Prawda"
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int first = int.Parse(Console.ReadLine());
            if (first % 2 == 0) Console.WriteLine("Liczba " + first + " jest parzysta");
        }
    }
}
// V = 4/3 πr³
