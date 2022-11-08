using System;
namespace Exercise
{
    class Program
    {
        static string SecondsToHHMMSS(int a, int b)
        {
            // Deklarowanie zwracanego stringa
            string[] returnString = new String[2];
            // Sortowanie parametrów
            int[] SortArray = new int[2];
            if (a>b || a==b)
            {
                SortArray[0] = b;
                SortArray[1] = a;
            }
            else
            {
                SortArray[0] = a;
                SortArray[1] = b;
            }

            // Algorytm zamieniający sekundy na HH:MM:SS
            for (int i = 0; i < 2; i++)
            {
                int number = SortArray[i];
                int hours = 0;
                int minutes = 0;
                while (true)
                {
                    if (number >= 3600)
                    {
                        hours++;
                        number -= 3600;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    if (number >= 60)
                    {
                        minutes++;
                        number -= 60;
                    }
                    else
                    {
                        break;
                    }
                }
                returnString[i] += hours + ":" + minutes + ":" + number;
            }
            return returnString[0]+" - "+returnString[1];

        }
        public static void Main(string[] args)
        {
            Console.WriteLine(SecondsToHHMMSS(2137, 420));
        }
    }
}