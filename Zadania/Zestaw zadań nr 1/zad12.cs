using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            // string result = "Prawda"
            Console.WriteLine("Podaj bok a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok c: ");
            double c = double.Parse(Console.ReadLine());
            // a + b = c 
            double count = Math.Pow(a,2) + Math.Pow(b,2);
            if (count == Math.Pow(c,2))
            {
                Console.WriteLine("Trójkąt jest prostokątny");
            }
            else Console.WriteLine("Trójkąt nie jest prostokątny");
        }
    }
}