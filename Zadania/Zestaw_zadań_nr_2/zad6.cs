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
                Console.WriteLine("Podaj {0} liczbę", writenumber);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }
            int calculations = 0;
            for (int i = 0; i <= 9; i++) calculations += numbers[i];
            calculations = calculations / numbers.Length;
            Console.WriteLine("Średnia arytmetyczna liczb: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9} to {10}", 
            numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], 
            numbers[6], numbers[7], numbers[8], numbers[9], calculations);
        }
    }
}
