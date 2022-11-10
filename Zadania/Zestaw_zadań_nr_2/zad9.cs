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
            double ifPositive = 1;
            var input = "";
            while (input != "STOP" ^ ifPositive <= 0)
            {
                Console.WriteLine("Wpisz dodatnią liczbę zmiennoprzecinkową");
                input = Console.ReadLine();
                // Sprawdzanie czy input jest większe lub równe zero.
                if (double.TryParse(input, out _))
                {
                    ifPositive = Convert.ToDouble(input);
                }
                if (input != "STOP" ^ ifPositive <= 0)
                {
                    double number = Convert.ToDouble(input);
                    numbers *= number;
                    count += 1;
                }
                if (ifPositive <= 0)
                {
                    Console.WriteLine("Wpisano liczbę niedodatnią. Nie zostanie ona uwzględniona przy obliczeniach");
                }
            }
            double calculations = Math.Pow(numbers, (1 / count));
            Console.WriteLine("Średnia geometryczna podanych liczb to {0}", calculations);
        }
    }
}