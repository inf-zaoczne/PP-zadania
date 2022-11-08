using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string even_number = "Liczby parzyste to: ";
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Podaj " + i + " liczbę całkowitą: ");
                int even_check = Convert.ToInt32(Console.ReadLine());
                if (even_check % 2 == 0)
                {
                    even_number = even_number + " " + even_check + ",";
                }
            }
            Console.WriteLine(even_number);
        }
    }
}
