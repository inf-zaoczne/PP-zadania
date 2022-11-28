/* Program oblicza wartośc funkcji y = 2x+5 w przedziale od 0 do 10  */

using System;
namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza wartośc funkcji y = 2x+5 w przedziale od 0 do 10 ");

            ///////////////////////////////////////////////////////////////////
            //
            //  for (int x = 0; x <= 10; x++)
            //  {
            //    Console.WriteLine("y = {0} dla x = {1}", 2 * x + 5, x);
            //  }
            //  Console.WriteLine("Pętla zakonczyła działanie");
            //
            //////////////////////////////////////////////////////////////////
            //
            //  int x = 0;
            //  do
            //  {
            //    Console.WriteLine("y = {0} dla x = {1}", 2 * x + 5, x);
            //    x++;
            //  } while (x<=10);
            //
            //////////////////////////////////////////////////////////////////

            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine("y = {0} dla x = {1}", 2 * x + 5, x);
                x++;
            }
            Console.WriteLine("Pętla zakonczyła działanie");
        }
    }
}