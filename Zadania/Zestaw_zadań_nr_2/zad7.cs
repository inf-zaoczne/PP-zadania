using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double numbers = 0;
            var input = "";
            while (input != "STOP")
            {
                Console.WriteLine("Wpisz liczbę zmiennoprzecinkową, bądź STOP, aby zatrzymać program.");
                input = Console.ReadLine();
                if (input != "STOP")
                {
                    bool isNum = double.TryParse(input, out _);
                    if (isNum == true)
                    {
                        double number = Convert.ToDouble(input);
                        numbers += number;
                        count += 1;
                    }
                    else Console.WriteLine("Błąd. Spróbuj ponownie");
                }
            }
            double calculations = numbers / count;
            Console.WriteLine("Użytkownik wpisał liczby {0} razy. Średnia artymetryczna tych liczb to {1}", count, calculations);
        }
    }
}