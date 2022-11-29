/*rogram poprosi użytkownika o podanie długości ciągu liczb,
a następnie wczyta po kolei te liczby do tablicy.Następnie program ma 
wyliczyć średnią z podanych liczb i wypisać ją na ekranie*/

using System;
using System.Collections;

namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program poprosi użytkownika o podanie długości ciągu liczb," +
                " a następnie wczyta po kolei te liczby do tablicy.Następnie program ma " +
                "wyliczyć średnią z podanych liczb i wypisać ją na ekranie");
            int ileLiczb;
            while (!int.TryParse(Console.ReadLine(), out ileLiczb) || ileLiczb < 1)
            {
                Console.WriteLine("Błędna wartość. Podaj liczbę >1");
            }
            double[] podaneLiczby = new double[ileLiczb];
            for (int i = 0; i < podaneLiczby.Length; i++)
            {
                Console.WriteLine("Podaj liczbę " + (i + 1));
                while (!double.TryParse(Console.ReadLine(), out podaneLiczby[i]))
                {
                    Console.WriteLine("Błędna wartość. Podaj liczbę");
                }
            }
            Console.Write("Średnia z liczb:");
            foreach (double item in podaneLiczby)
            {
                Console.Write(item + ";");
            }
            Console.Write(" wynosi " + podaneLiczby.Average());
        }
    }
}
