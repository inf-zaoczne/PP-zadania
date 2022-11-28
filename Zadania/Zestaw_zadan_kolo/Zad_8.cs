/*Program pozwala odgadnac użytkownikowi wylosowana liczbę w 3 próbach*/

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program pozwala odgadnac użytkownikowi wylosowana liczbę w 3 próbach");

            Random losowanie = new Random();
            string odpowiedz;
            do
            {
                int wylosowana = losowanie.Next(1, 100);
                //Console.WriteLine("Wylosowano: "+wylosowana);
                int podanaLiczba;
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Próba {0}/3, odgadnij liczbę:", i + 1);
                    podanaLiczba = int.Parse(Console.ReadLine());
                    if (wylosowana == podanaLiczba)
                    {
                        Console.WriteLine("Gratuluję, odgadles!");
                        break;
                    }
                    Console.WriteLine("Niestety to nie ta licza");
                    if (i == 2)
                    {
                        Console.WriteLine("Liczba wylosowana to: " + wylosowana);
                    }
                }
                Console.WriteLine("Czy chcesz odgadnąc nową liczbę? tak/nie");
                odpowiedz = Console.ReadLine();

            } 
            while (odpowiedz == "tak");
        }

    }
}