/*Program losuje 100 liczb, zapamietuje je i wyswietla podsumowanie
 z informacja ile jest parzystych, a ile nieparzystych*/

using System;
using System.Collections;

namespace WSBkolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program losuje 100 liczb, zapamietuje je i wyswietla podsumowanie " +
               "z informacja ile jest parzystych, a ile nieparzystych");
            int ileLiczb = 100;
            int ileParzystych = 0;
            int ileNieparzystych = 0;
            ArrayList liczbyParzyste = new ArrayList();
            ArrayList liczbyNieparzyste = new ArrayList();
            Random losowanie = new Random();
            int[] wylosowaneLiczby = new int[ileLiczb];
            for (int i = 0; i < ileLiczb; i++)
            {
                wylosowaneLiczby[i] = losowanie.Next(1, 1000);
            }
            Console.WriteLine("Wylosowane liczby:");
            foreach (int item in wylosowaneLiczby)
            {
                Console.Write(item + ";");
                if (item % 2 == 0)
                {
                    ileParzystych++;
                    liczbyParzyste.Add(item);
                }
                else
                {
                    ileNieparzystych++;
                    liczbyNieparzyste.Add(item);
                }
            }
            Console.WriteLine("\nLiczby parzyste: " + ileParzystych);
            foreach (int item in liczbyParzyste)
            {
                Console.Write(item + ";");
            }
            Console.WriteLine("\nLiczby nieparzyste: " + ileNieparzystych);
            foreach (int item in liczbyNieparzyste)
            {
                Console.Write(item + ";");
            }
        }
    }
}
