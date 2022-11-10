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
                Console.WriteLine("Wpisz liczbę nr " + writenumber);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }
            for (int i = 9; i >= 0; i--)
            {
                int writenumber = i + 1;
                Console.WriteLine("Liczba nr " + writenumber + " to " + numbers[i]);
            }
        }
    }
}