/*Program z mozliwoscia wybierania z menu:
1. Policz potege
2. Informacja o autorze
3. Liczby pierwsze
4. Koniec*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSBkolo
    {
        class Program
        {
            static void LiczbyPierwsze(int przedział)
            {
                bool[] tablica = new bool[przedział + 1];
                for (int i = 2; i < tablica.Length; i++)
                {
                    tablica[i] = true;
                }
                //wykreślanie wielokrotnosci
                for (int i = 2; i <= Math.Sqrt(tablica.Length); i++)
                {
                    if (tablica[i])//tablica[i]==true
                        for (int j = 2; i * j < tablica.Length; j++)
                        {
                            tablica[i * j] = false;
                        }
                }
                //odczytanie adresow tablicy z wartoscia true/wyswietla liczby pierwsze
                Console.WriteLine("Liczby pierwsze:");
                for (int i = 2; i < tablica.Length; i++)
                {
                    if (tablica[i])
                    {
                        Console.Write(i + ",");
                    }
                }
            }
            static void Autor(string imie)
            {
                Console.WriteLine("O autorze: " + imie);
            }
            static int Kwadrat(int podstawaPotęgi)
            {
                int wynik = podstawaPotęgi * podstawaPotęgi;
                return wynik;
            }
            static void Main(string[] args)
            {
                string odpowiedz = "nie";
                while (!(odpowiedz == "tak" || odpowiedz == "TAK"))
                {
                    Console.WriteLine("Wybierz opcje:\n1 - Policz potęgę \n2 - Informacje o autorze \n" +
                        "3 - Liczby pierwsze, \n4 - Koniec");
                    int opcja;
                    while (!int.TryParse(Console.ReadLine(), out opcja) || opcja < 1 || opcja > 3)
                    {
                        Console.WriteLine("Błędna wartość. Podaj liczbę 1-3");
                    }
                    switch (opcja)
                    {
                        case 1:
                            Console.WriteLine("Program podnosi do kwadratu liczbę. \n Podaj liczbę");
                            int liczba = int.Parse(Console.ReadLine());
                            Console.WriteLine("Potęga liczby to: " + Kwadrat(liczba));
                            break;
                        case 2:
                            Autor("Rafał");
                            break;
                        case 3:
                            Console.WriteLine("Program wyswieta liczby pierwsze do 100");

                            LiczbyPierwsze(100);
                            break;
                        case 4:
                            Console.WriteLine("Czy napewno chcesz zakonczyc program? tak/nie");
                            odpowiedz = Console.ReadLine();

                            break;
                    }
                    if (!(odpowiedz == "tak" || odpowiedz == "TAK"))
                    {
                        Console.WriteLine("Aby wrócić do menu, naciśnij klawisz ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                Console.ReadLine();
            }
       }
}
