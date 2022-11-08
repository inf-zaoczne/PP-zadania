using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Program przepytujący z tabliczki mnożenia");

            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    bool goodAsnwear = false;
                    while (goodAsnwear == false)
                    {
                        Console.WriteLine("{0}*{1}=?", i, j);
                        int givenResult = Convert.ToInt32(Console.ReadLine());
                        int askedResult = i * j;
                        if (givenResult == askedResult) goodAsnwear = true;
                        else Console.WriteLine("Spróbuj jeszcze raz!");
                    }

                }

            }
            Console.WriteLine("SUKCES");

        }
    }
}