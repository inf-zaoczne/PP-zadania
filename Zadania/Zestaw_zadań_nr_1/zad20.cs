using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string even_number = "Liczby parzyste to: ";
            for (int i = 0; i < 1000; i++)
            {
                Random random_number = new Random();
                int number = random_number.Next(1, 10000);
                if (number % 2 == 0)
                {
                    even_number = even_number + " " + number + ",";
                }
            }
            Console.WriteLine(even_number);
        }
    }
}
