using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Program przepytujący z tabliczki mnożenia");
            
            bool whileStuff1 = false;
            bool whileStuff2 = false;

            while (whileStuff2 == false)
            {
                while (whileStuff1 == false)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        if (whileStuff1 == true) break;
                        for (int j = 1; j <= 10; j++)
                        {
                                Console.WriteLine("{0}*{1}=?", i, j);
                                int givenResult = Convert.ToInt32(Console.ReadLine());
                                int askedResult = i * j;
                                if (givenResult != askedResult)
                                {
                                    Console.WriteLine("Spróbuj jeszcze raz, ale od nowa!");
                                    whileStuff1 = true;
                                }
                                if (whileStuff1 == true) break;

                        }

                    }
                    if (whileStuff1 == false) whileStuff2 = true;
                    if (whileStuff2 == true) whileStuff1 = true;
                }   
                if (whileStuff1 == true) whileStuff1 = false;
            }

            Console.WriteLine("SUKCES");

        }
    }
}