using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę całkowitą: ");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę całkowitą: ");
            double second = double.Parse(Console.ReadLine());
            // double value = Math.Round(first / second,1);
            // double result = Math.Round((value - Math.Truncate(value)*10));
            double result = first/second;
            
            Console.WriteLine("Wynik dzielenia to "+result);
        }
    }
}