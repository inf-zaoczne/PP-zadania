/*Program wyswietla sumę liczb z przedziału -10 do 10*/

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wyswietla sumę liczb całkowitych z przedziału podanego przez użytkownika");
            Console.WriteLine("Podaj wartosc dolną przedziału");
            int przedzialOD = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc górną przedziału");
            int przedzialDO = int.Parse(Console.ReadLine());

            int suma = 0;

            for (int i = przedzialOD; i <= przedzialDO; i++)
            {

                suma += i; //suma = suma + i;
            }
            Console.WriteLine("Suma liczb z przedziału {0} - {1} wynosi {2}", przedzialOD, przedzialDO, suma);     
        }

    }
}