/*Program wyswietla liczby całkowite z przedziału -10 do 10*/

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wyswietla liczby całkowite z przedziału podanego przez użytkownika");
            Console.WriteLine("Podaj wartosc dolną przedziału");
            int przedzialOD = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc górną przedziału");
            int przedzialDO = int.Parse(Console.ReadLine());
            for (int i = przedzialOD; i <= przedzialDO; i++)
            {
                if (i == 5)
                    continue; // pominiecie kolejnych instrukcji i przejscie do kolejnej iteracji

                if (i > 100)
                    break; //zakonczenie działania pętli
                Console.Write(i + ",");
            }
        }
    }
}