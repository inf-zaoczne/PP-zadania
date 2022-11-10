using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pamiętać, żeby wartości double wpisywać z kropką. Przecinek tworzy błędy.
            double numbers = 1;
            double count = 0;
            var input = "";
            while (input != "STOP")
            {
                Console.WriteLine("Wpisz dodatnią liczbę zmiennoprzecinkową");
                input = Console.ReadLine();
                if (input != "STOP")
                {
                    double number = Convert.ToDouble(input);
                    numbers *= number;
                    count += 1;
                }
            }
            double calculations = Math.Pow(numbers, (1 / count));
            Console.WriteLine("Średnia geometryczna podanych liczb to {0}", calculations);
        }
    }
}