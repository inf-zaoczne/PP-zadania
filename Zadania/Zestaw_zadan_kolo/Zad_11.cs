/*Program oblicza kwadrat podanej liczby*/

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza kwadrat liczby\npodaj liczbę:");
            int liczba;
            while (!int.TryParse(Console.ReadLine(), out liczba))
            {
                Console.WriteLine("Nie podales liczby. Podaj liczby");
            }
            Console.WriteLine("Kwadrat liczby: " + liczba * liczba);
            Console.ReadLine();
        }
    }
}
