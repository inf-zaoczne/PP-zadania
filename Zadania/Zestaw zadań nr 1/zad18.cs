using System;
namespace WSBExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("y = 3x");
            
            for (int i = 0; i <= 100; i++)
            {

                double math = 3*i;
                Console.WriteLine(math+" = 3*"+i);

            }

        }
    }
}