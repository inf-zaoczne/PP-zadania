using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {

                string[] letters = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "W", "V", "X", "Y", "Z"};

                for (int i = 0; i < letters.Length; i++)
                {
                    Console.Write(letters[i]+" ");
                }

        }
    }
}