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
            else if (a == 0) Console.WriteLine("0");
            else Console.WriteLine("-1");
        }
    }
}
