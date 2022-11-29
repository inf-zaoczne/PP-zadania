/*Program sortuje liczby algorytmem bąbelkowym*/

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sortuje liczby algorytmem bąbelkowym");
            int[] liczby = { 5, 4, 3, 1, 6, 0 };
            Console.WriteLine("Liczby nieposortowane:");
            foreach (int item in liczby)
            {
                Console.Write(item + ",");
            }
            int temp;
            for (int j = 0; j < liczby.Length - 1; j++)
            {
                for (int i = 0; i < liczby.Length - 1; i++)
                {
                    if (liczby[i] > liczby[i + 1])
                    {
                        temp = liczby[i];
                        liczby[i] = liczby[i + 1];
                        liczby[i + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nLiczby posortowane");
            foreach (int item in liczby)
            {
                Console.Write(item + ",");
            }
        }
    }
}
