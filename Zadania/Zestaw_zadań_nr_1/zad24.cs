using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string even_numbers = "Liczby parzyste to:";
            var input = "";
            while (input != "STOP")
            {
                Console.WriteLine("Wprowadź liczbę całkowitą, bądź wpisz STOP, by zatrzymać program: ");
                input = Console.ReadLine();
                if (input != "STOP")
                {
                    int even_number = Convert.ToInt32(input);
                    if (even_number % 2 == 0)
                    {
                        even_numbers = even_numbers + " " + even_number;
                    }
                }
            }
            Console.WriteLine(even_numbers);
        }
    }
}
