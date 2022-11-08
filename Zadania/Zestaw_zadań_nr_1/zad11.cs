using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            // string result = "Prawda"
            Console.WriteLine("Podaj liczbę nr1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr3: ");
            int n3 = int.Parse(Console.ReadLine());
            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    if (n2 < n3)
                    {
                        // n1 n2 n3
                        Console.WriteLine("3 liczby w kolejności od najmniejszej do największej to: " + n1 + ", " + n2 + ", " + n3);
                    }
                    else
                    {
                        // n1 n3 n2
                        Console.WriteLine("3 liczby w kolejności od najmniejszej do największej to: " + n1 + ", " + n3 + ", " + n2);
                    }
                }
                else
                {
                    if (n3 < n2)
                    {
                        // n3 n1 n2
                        Console.WriteLine("3 liczby w kolejności od najmniejszej do największej to: " + n3 + ", " + n1 + ", " + n2);
                    }
                }
            }
            else
            {
                // n1 mniejsze od n2! Mamy całe n1 i "n3 n1 n2"
                if (n1 > n3)
                {
                    if (n2 < n3)
                    {
                        // n2 n3 n1
                        Console.WriteLine("3 liczby w kolejności od najmniejszej do największej to: " + n2 + ", " + n3 + ", " + n1);
                    }
                    else
                    {
                        // n3 n2 n1
                        Console.WriteLine("3 liczby w kolejności od najmniejszej do największej to: " + n3 + ", " + n2 + ", " + n1);
                    }
                }
                else
                {
                    Console.WriteLine("3 liczby w kolejności od najmniejszej do największej to: " + n2 + ", " + n1 + ", " + n3);
                }
            }
        }
    }
}
