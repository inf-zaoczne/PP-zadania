using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz imię:");
            string Name = Console.ReadLine();
            Console.WriteLine("Imię to: " + Name);
        }
    }
}