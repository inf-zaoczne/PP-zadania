using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pierwszy bok:");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Drugi bok:");
            double second = double.Parse(Console.ReadLine());
            double result = first*second;
            Console.WriteLine("Prostokąt o bokach " +first+"cm i "+second+"cm ma pole "+result+"cm");
        }
    }
}