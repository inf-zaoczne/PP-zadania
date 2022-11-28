/* Program przelicza kwote EUR na PLN w oparciu o podany kurs wymiany */

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double kursEUR = 4.9;
                Console.WriteLine("Podaj kwote w EURO:");
                double EUR = double.Parse(Console.ReadLine());
                double PLN = EUR * kursEUR;
                Console.WriteLine("Kwota {0} EUR jest warta {1} PLN", EUR, PLN);
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak, a dokładniej: " + e.Message);
            }
        }
    }
}