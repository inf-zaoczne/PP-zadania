using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Podaj wysokość drzewka h:");
           int height = Convert.ToInt32(Console.ReadLine());

           for (int i = 0; i < height; i++)
           {
            
            for (int l = 0; l <= i; l++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

           }

        }
    }
}