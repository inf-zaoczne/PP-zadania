/*Program sprawdza czy podana liczba jest pierwsza*/

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Program sprawdza czy liczba jest pierwsza/nPodaj liczbe:");
                int liczba;
                while (!int.TryParse(Console.ReadLine(), out liczba))
                {
                    Console.WriteLine("błedna wartość. podaj liczbę:");
                }
                bool czyPierwsza = true;
                for (int i = 2; i <= Math.Sqrt(liczba); i++)
                {
                    if (liczba % i == 0)
                    {
                        czyPierwsza = false;
                        break;
                    }
                }
                if (czyPierwsza)
                    Console.WriteLine("Podana liczba jest pierwsza");
                else
                    Console.WriteLine("Podana liczba nie jest pierwsza");
            }
        }
    }
}
