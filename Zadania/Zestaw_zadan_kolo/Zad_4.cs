/* Program sprawdza czy liczba podana przez użytkownika 
* jest wieksza, mniejsza lub równa 5 */

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe do sprawdzenia");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba > 4)
                Console.WriteLine("Liczba jest wieksza od 4");
            else if (liczba == 4)
                Console.WriteLine("Liczba jest równa 4");
            else
                Console.WriteLine("Liczba jest mniejsza od 4");
        }
    }
}