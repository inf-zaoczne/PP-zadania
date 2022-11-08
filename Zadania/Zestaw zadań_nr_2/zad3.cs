using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10];

            for (int i = 0; i <=9; i++)
            {
                int writenumber = i+1;
                Console.WriteLine("Wpisz liczbę nr {0}", writenumber);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i]=number;
            }

            // musi pokazać miejsce 1, 3, 5, 7, 9

            for (int i = 1; i <= numbers.Length/2; i++)
            {
                int arraynumber = i*2-1;
                int showarraynumber = i*2;
                Console.WriteLine("Liczba {0} jest na {1} miejscu w tabeli", numbers[arraynumber], showarraynumber);
            }

        }
    }
}