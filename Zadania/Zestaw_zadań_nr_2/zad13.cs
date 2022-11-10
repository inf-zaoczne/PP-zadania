using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sprawdzę, czy podana przez Ciebie liczba jest potęgą dwójki.");
            Console.WriteLine("Podaj liczbę całkowitą");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPowerOf2 = false;
            do
            {
                if (number % 2 == 0) number /= 2;
                if (number == 1) isPowerOf2 = true;
                if (number % 2 != 0) number = 0;
            }
            while (number >= 1);
            if (isPowerOf2 == true) Console.WriteLine("TAK");
            else Console.WriteLine("NIE");
        }
    }
}
