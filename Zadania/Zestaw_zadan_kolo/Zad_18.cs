/*Program rysuje piramidę o podanej wysokosci*/
//
//
//  h = 4
//
//     *
//    ***
//   ******
//  ********

using System;
using System.Collections;

namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program rysuje piramidę. \n Podaj wysokość:");
            int wysokosc;
            while (!int.TryParse(Console.ReadLine(), out wysokosc) || wysokosc < 1)
            {
                Console.WriteLine("Błędna wartość. Podaj liczbę >1");
            }

            for (int i = 0; i < wysokosc * 2; i += 2)
            {
                for (int j = (wysokosc * 2) - i; j > 0; j -= 2)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
