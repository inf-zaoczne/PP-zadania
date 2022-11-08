using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pierwsza cyfra:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Druga cyfra:");
            int second = int.Parse(Console.ReadLine());
            int output = first+second;
            Console.WriteLine("Wynik dodawania to " + output);
        }
    }
}