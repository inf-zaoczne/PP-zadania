/*Program oblicza silnie dla podanej liczby w przedziale 1-15*/

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza silnie dla podanej liczby w przedziale 1-15");
            int liczba;
            while (!int.TryParse(Console.ReadLine(), out liczba) || liczba > 15 || liczba < 1)
            {
                Console.WriteLine("błedna wartość. podaj liczbę 1-15:");
            }
            int silnia = 1;
            for (int i = 1; i <= liczba; i++)
            {
                silnia *= i; //silnia = silnia * i;
            }
            Console.WriteLine("Silnia z liczby: " + silnia);
        }
    }
}
