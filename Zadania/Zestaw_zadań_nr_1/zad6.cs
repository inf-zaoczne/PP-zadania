using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj promień kuli: ");
            double first = double.Parse(Console.ReadLine());
            double result = Math.Round(4.0/3*Math.PI*Math.Pow(first, 3),4);
            
            Console.WriteLine("Objętość kuli o promieniu "+first+"cm to: "+result+"cm3");
        }
    }
}
// V = 4/3 πr³