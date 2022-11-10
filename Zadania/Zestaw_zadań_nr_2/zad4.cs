using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            for (int i = 0; i <= 9; i++)
            {
                int writeline = i + 1;
                Console.WriteLine("Wpisz imię nr " + writeline);
                string ? name = Convert.ToString(Console.ReadLine());
                if (name != null)
                {
                    names[i] = name;
                }
            }
            string printNames = "witajcie ";
            for (int i = 0; i < names.Length; i++)
            {
                printNames += names[i] + ", ";
            }
            printNames = printNames.Remove(printNames.Length - 2) + ".";
            Console.Write(printNames);
            // Console.Write("Witajcie {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}.", 
            // names[0], names[1], names[2], names[3], names[4], names[5], names[6], names[7], names[8], names[9]);
        }
    }
}