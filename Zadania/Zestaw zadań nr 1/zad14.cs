using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());

            if (a > 0) Console.WriteLine("1");
            if (a == 0) Console.WriteLine("0");
            if (a < 0) Console.WriteLine("-1");


        }
    }
}