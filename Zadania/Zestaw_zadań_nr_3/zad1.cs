using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {

            int howManyEven = 0;
            for (int i = 0; i < 1000; i++)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next();
                if (randomNumber%2==0) howManyEven++;
            }
            Console.WriteLine("Znaleziono {0} liczb parzystych",howManyEven);

        }
    }
}