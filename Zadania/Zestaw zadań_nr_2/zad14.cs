using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
           bool notPositive = false;

           for (int i = 0; i <= 9; i++)
           {
            int userNumber = i+1;
            Console.WriteLine("Podaj {0} liczbę całkowitą dodatnią.", userNumber);
            int number = Convert.ToInt32(Console.ReadLine());
            if (number<0)
            {
                notPositive = true;
                break;
            }
           }

           if (notPositive == false) Console.WriteLine("SUKCES");

        }
    }
}