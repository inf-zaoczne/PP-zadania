using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args){

            /*
            Napisz program, który oblicza pole czworokąta. Użytkownik podaje długości
            wszystkich boków i miary wszystkich kątów (w stopniach) jako liczby zmiennoprzecinkowe.
            Program powinien posiadać funkcję, która na podstawie wskazanych danych rozpoznaje, czy
            czworokąt jest kwadratem, prostokątem, rombem, równoległobokiem, trapezem czy deltoidem
            (ale ma wskazywać tylko jedno z nich!). Powinien też posiadać funkcje obliczające pole
            dla każdego z podanych czworokątów na podstawie przekazanych danych. Jeżeli czworokąt
            nie jest żadnym z wymienionych, program wypisuje komunikat o niepowodzeniu.
            */

            // Tablice, zmienne itd.
            string[] sides = new string[] {"a", "b", "c", "d"};
            string[] angles = new string[] {"AD", "AC", "BD", "BC"};
            double[] userSides = new double[4];
            double[] userAngles = new double[4];
            double math;
            double math2;
            double math3;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Program do obliczania pola czworokąta.");
            Console.WriteLine("");
            Console.WriteLine("");
            
            
            
            Console.WriteLine("");
            Console.WriteLine("RYSUNEK POGLĄDOWY");
            Console.WriteLine("");
            Console.WriteLine(" BD             b          BC   ");
            Console.WriteLine("     ---------------------   ");
            Console.WriteLine("    |                     |");
            Console.WriteLine("    |                     |");
            Console.WriteLine("    |                     |");
            Console.WriteLine(" d  |                     | c ");
            Console.WriteLine("    |                     |");
            Console.WriteLine("    |                     |");
            Console.WriteLine("    |                     |");
            Console.WriteLine("     ---------------------   ");
            Console.WriteLine(" AD             a          AC   ");
            Console.WriteLine("");
            Console.WriteLine("");

            // wpisywanie boków
            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    Console.WriteLine("Podaj długośc boku {0}", sides[i]);
                    string? input = Console.ReadLine();
                    double userInput;
                    var userCheck = double.TryParse(input, out userInput);
                    if (userInput>0)
                    {
                        userSides[i] = userInput;
                        Console.WriteLine("");
                        break;
                    }
                    else Console.WriteLine("Nie podano liczby zmiennoprzecinkowej, lub podano liczbę mniejszą bądź równą zero. Wpisz liczbę ponownie");
                }
            }

            // wpisywanie kątów
            while (true)
            {
                for (int i = 0; i < 4; i++)
                {
                    while (true)
                    {
                        Console.WriteLine("Podaj kąt {0}", angles[i]);
                        string? input = Console.ReadLine();
                        double userInput;
                        var userCheck = double.TryParse(input, out userInput);
                        if (userInput > 0)
                        {
                            userAngles[i] = userInput;
                            Console.WriteLine("");
                            break;
                        }
                        else Console.WriteLine("Nie podano liczby zmiennoprzecinkowej, lub podano liczbę mniejszą bądź równą zero. Wpisz liczbę ponownie");
                    }
                }
                if (userAngles[0] +userAngles[1] +userAngles[2] +userAngles[3] == 360) break;
                else 
                {
                    Console.WriteLine("");
                    Console.WriteLine("Podane kąty nie dają sumy 360 stopni. Proszę wprowadź je ponownie z zachowaniem tej reguły.");
                    Console.WriteLine("");
                }
            }

            /*
                kwadratem, prostokątem, rombem, równoległobokiem, trapezem czy deltoidem

                Kwadrat - boki takie same, kąty 90 stopni każdy
                0,1,2,3 w usersides muszą być takie same, 0,1,2,3 w userangles muszą równać się 90

                Prostokąt - boki przeciwległe takie same, kąty 90 stopni
                0,1 2,3 w usersides muszą być takie same, 0,1,2,3 w userangles muszą równać się 90

                Romb - boki takie same, kąty przeciwległe takie same
                0,1,2,3 w usersides muszą być takie same, 0,2 1,3 w userangles muszą być takie same

                Równoległobok - boki naprzeciw siebie są takie same, kąty przeciwległe takie sane.
                0,1 2,3 w usersides muszą być takie same, 0,3 1,2 w userangles muszą być takie same.

                Trapez - suma miar kątów leżących przy tym samym boku wynosi 180.
                0,1 0,2 1,3 2,3 W userangles muszą równać się 180 każdy

                Deltoid - pary sąsiednich boków są takie same
                0,2 1,3 ALBO 0,3 1,2 w usersides muszą być takie same.

                Kolejność sprawdzania:
                Kwadrat
                Prostokąt
                Romb
                Równoległobok
                Trapez
                Deltoid
                
                Sprawdzanie musi być na odwrót

            */
            // Sprawdzanie jaki to kształt
            int shape = 6;
            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0: //Deltoid
                        if (userSides[0] == userSides [2] && userSides[1] == userSides[3] || userSides[0] == userSides[3] && userSides[1] == userSides[2]) shape = i;
                    break;
                    
                    case 1: //Trapez
                        if (userAngles[0] + userAngles[1] == 180 && userAngles[2] + userAngles[3] == 180 || userAngles[1] + userAngles[3] == 180 && userAngles[0] + userAngles[2] == 180) shape = i;
                    break;
                    
                    case 2: //Równoległobok
                        if (userSides[0] == userSides[1] && userSides[2] == userSides[3] && userAngles[0] == userAngles[3] && userAngles[1] == userAngles[2]) shape = i;
                    break;
                    
                    case 3: //Romb
                        if (userSides[0] == userSides[1] && userSides[2] == userSides[3] && userSides[1] == userSides[3] && userAngles[0] == userAngles[3] && userAngles[1] == userAngles[2]) shape = i;
                    break;
                    
                    case 4: //Prostokąt
                        if (userSides[0] == userSides[1] && userSides[2] == userSides[3] && userAngles[0] == 90 && userAngles[1] == 90 && userAngles[2] == 90 && userAngles[3] == 90) shape = i;
                    break;
                    
                    case 5: //Kwadrat
                        if (userSides[0] == userSides[1] && userSides[2] == userSides[3] && userSides[1] == userSides[3] && userAngles[0] == 90 && userAngles[1] == 90 && userAngles[2] == 90 && userAngles[3] == 90) shape = i;
                    break;
                    
                    default:
                    // do nothing
                    break;
                }
            }

            switch (shape)
            {
                case 6:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Podany czworokąt nie spełnia założeń znanych czworokątów.");
                break;
                
                case 5:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Podany czworokąt to kwadrat.");
                    math = userSides[0]*userSides[0];
                    Console.WriteLine("");
                    Console.WriteLine("Jego pole to {0}.", math);
                break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Podany czworokąt to prostokąt.");
                    math = userSides[0]*userSides[1];
                    Console.WriteLine("");
                    Console.WriteLine("Jego pole to {0}.", math);
                break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Podany czworokąt to romb.");
                    math = (userAngles[0] * (Math.PI)) / 180;
                    math = Math.Sin(math);
                    math = 
                    math2 = userSides[0]* userSides[0]*math;
                    Console.WriteLine("");
                    Console.WriteLine("Jego pole to {0}.", math2);
                break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Podany czworokąt to równoległobok.");
                    math = (userAngles[1] * (Math.PI)) / 180;
                    math = Math.Sin(math);
                    math2 = userSides[0]* userSides[2]*math;
                    Console.WriteLine("");
                    Console.WriteLine("Jego pole to {0}.", math2);
                break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Podany czworokąt to trapez.");
                    // To jest chore bo tu jakiegoś sinusa trzeba liczyć
                    math = (userAngles[0] * (Math.PI)) / 180;
                    math = Math.Sin(math);
                    math2 = userSides[3]/math;
                    math = userSides[0]+userSides[1];
                    math3 = 0.5*math*math2;
                    Console.WriteLine("");
                    Console.WriteLine("Jego pole to {0}.", math3);
                break;

                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Podany czworokąt to deltoid.");
                    if (userAngles[1] == userAngles[2])
                    {    
                    math = (userAngles[1] * (Math.PI)) / 180;
                    math = Math.Sin(math);
                    math2 = userSides[0]* userSides[1]*math;
                    Console.WriteLine("");
                    Console.WriteLine("Jego pole to {0}.", math2);
                    }
                    else
                    {
                    math = (userAngles[0] * (Math.PI)) / 180;
                    math = Math.Sin(math);
                    math2 = userSides[0] * userSides[3] * math;
                    Console.WriteLine("");
                    Console.WriteLine("Jego pole to {0}.", math2);
                    }
                break;

                default:
               // do nothing
                break; 
            }

        }
    }
}