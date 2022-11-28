/* Program oblicza objetosc kuli o promieniu podanym przez uzytkownika */

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, V;
            Console.WriteLine("Podaj promien:");
            r = double.Parse(Console.ReadLine());
            V = (4 * Math.PI * Math.Pow(r, 3)) / 3;
            Console.WriteLine("Objetosc kuli o promieniu r = " + r + " wynosi V = " + V);
            Console.WriteLine("Objetosc kuli o promieniu r = {0} wynosi V = {1}", r, V);
            Console.ReadLine();
        }
    }
}