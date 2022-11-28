/* Program oblicza pole prostokąta o wymiarach boków podanych 
             przez użytkownika */
using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            double bokA, bokB, pole;
            Console.WriteLine("Podaj wymiary boku A:");
            bokA = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wymiary boku B:");
            bokB = double.Parse(Console.ReadLine());

            pole = bokA * bokB;
            Console.WriteLine("Pole prostokąta o wymiarach bok A = " + bokA +
                " bok B = " + bokB + " równe jest " + pole);
            Console.ReadLine();
        }
    }
}