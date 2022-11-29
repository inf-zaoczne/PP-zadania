/*PGra w zgadywanie liczby dla 2-5 osób. Program losuje dla kazdego gracza inną liczbę, 
 po czym każdy gracz ma szanse na jej odgadnięcie w max 4 próbach*/

using System;
using System.Collections;

namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gra w zgadywanie liczby dla 2-5 osób. " +
               "Program losuje dla kazdego gracza inną liczbę, po czym każdy gracz ma szanse " +
               "na jej odgadnięcie w max 4 próbach. ");

            //podanie liczby graczy
            int liczbaGraczy;
            Console.WriteLine("Podaj liczbę graczy:");
            while (!int.TryParse(Console.ReadLine(), out liczbaGraczy) || liczbaGraczy < 2 || liczbaGraczy > 5)
                Console.WriteLine("bład. podaj liczbę graczy od 2 do 5");
            //pobranie imion graczy
            string[] imionaGraczy = new string[liczbaGraczy];
            for (int i = 0; i < liczbaGraczy; i++)
            {
                Console.WriteLine("Podaj imię gracza nr " + (i + 1));
                imionaGraczy[i] = Console.ReadLine();
            }
            //wylosowanie liczb
            Random losowanie = new Random();
            int[] wylosowaneLiczby = new int[liczbaGraczy];
            for (int i = 0; i < liczbaGraczy; i++)
            {
                wylosowaneLiczby[i] = losowanie.Next(1, 10);
            }
            //kolejne proby odgadywania
            int podanaLiczba;
            for (int runda = 1; runda <= 4; runda++)
            {
                for (int i = 0; i < liczbaGraczy; i++)
                {
                    Console.WriteLine("Gra: " + imionaGraczy[i] + ".\nPodaj liczbę");
                    podanaLiczba = int.Parse(Console.ReadLine());
                    if (podanaLiczba == wylosowaneLiczby[i])
                    {
                        Console.WriteLine("Odgadles");
                    }
                    else
                    {
                        Console.WriteLine("Nie trafiles");
                    }
                }
            }
        }
    }
}
