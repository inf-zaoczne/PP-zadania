using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            var input = "";
            while (input != "STOP")
            {
                Console.WriteLine("Wprowadź liczbę całkowitą, bądź wpisz STOP, by zatrzymać program: ");
                input = Console.ReadLine();
                if (input != "STOP")
                {
                    int sum_converted = Convert.ToInt32(input);
                    sum = sum + sum_converted;
                }
            }
            Console.WriteLine("Suma liczb to: " + sum);
        }
    }
}
