/*Program rysuje, wybierz 1 - trojkat, 2 - prostokąt*/

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program rysuje, wybierz 1 - trojkat, 2 - prostokąt");
            int wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Podaj wysokosc trojkata");
                    int wysokosc = int.Parse(Console.ReadLine());
                    for (int i = 0; i < wysokosc; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Program rysuje prostokat z gwiazdek o wymiarach podanych przez użytkownika");
                    /* np. 4 x 10
                      **********
                      **********
                      **********
                      **********
                      */
                    Console.WriteLine("Podaj dlugosc");
                    int dlugosc = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj szerokosc");
                    int szerokosc = int.Parse(Console.ReadLine());

                    for (int j = 0; j < szerokosc; j++)
                    {
                        for (int i = 0; i < dlugosc; i++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }

    }
}