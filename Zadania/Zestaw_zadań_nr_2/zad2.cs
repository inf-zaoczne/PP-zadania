using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                int writenumber = i + 1;
                Console.WriteLine("Podaj liczbę nr " + writenumber);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }
            for (int i = 0; i <= 9; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    int writenumber = i + 1;
                    Console.WriteLine("Liczba " + numbers[i] + " jest parzysta. Jej miejsce w tablicy to " + i);
                }
            }
        }
    }
}