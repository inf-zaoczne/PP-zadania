/*Program rysujący poziomy histogram z gwiazdek ilustrujący rozkład 
wartości w podanym przez użytkownika ciągu liczb z przedziału 1 – 5*/


using System;
using System.Collections;

namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" program rysujący poziomy histogram z gwiazdek ilustrujący rozkład " +
            "wartości w podanym przez użytkownika ciągu liczb z przedziału 1 – 5");
            int ileLiczb;
            while (!int.TryParse(Console.ReadLine(), out ileLiczb) || ileLiczb < 1)
            {
                Console.WriteLine("Błędna wartość. Podaj liczbę >1");
            }

            int[] histogram = new int[6];
            int podanaLiczba;
            for (int i = 0; i < ileLiczb; i++)
            {
                Console.WriteLine("Podaj liczbę nr " + (i + 1));
                while (!int.TryParse(Console.ReadLine(), out podanaLiczba) || podanaLiczba < 1 || podanaLiczba > 5)
                {
                    Console.WriteLine("Błędna wartość. Podaj liczbę  z zakresu 1-5 ");
                }
                histogram[podanaLiczba]++;
            }
            Console.WriteLine("Rysuje histogram");
            for (int i = 1; i < histogram.Length; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < histogram[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
