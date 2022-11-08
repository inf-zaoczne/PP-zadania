using System;
namespace Exercise
{
    class Program
    {
        static double[] GetStartedValues()
        {
            /*
            0,1,2 - długości boków, (a b c)
            3,4,5 - miary kątów wewnętrznych, (ab ac cb)
            6 - promień okręgu wpisanego,
            7 - promień okręgu opisanego
            */
            double[] returnedValues = new double[8];
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Program obliczający pole trójkąta z podanych danych.");

            string[] sideLetters = { "a", "b", "c" };
            string[] anglesLetters = { "|AB|", "|AC|", "|CB|" };

            // zmienne do sprawdzania
            string? userInput;
            double userInputCheck;
            // zmienna do zatrzymania pętli poniżej
            bool whileStuff = true;
            while (whileStuff == true)
            {
                Console.WriteLine("Wybierz, które dane chcesz wprowadzić:");
                Console.WriteLine("Wybierz pojedyńczo, program zapyta czy chcesz podać kolejne dane.");
                Console.WriteLine("1 - długości boków,");
                Console.WriteLine("2 - miary kątów wewnętrznych,");
                Console.WriteLine("3 - promień okręgu wpisanego,");
                Console.WriteLine("4 - promień okręgu opisanego");
                Console.WriteLine("5 - Koniec wprowadzania danych");
                // sprawdzanie
                userInput = Console.ReadLine();
                double.TryParse(userInput, out userInputCheck);
                if (userInputCheck <= 0) userInputCheck = 0;

                if (userInputCheck >= 1 && userInputCheck <= 5)
                {
                    switch (userInputCheck)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Wybrano wpisywanie długości boków. Jeżeli chcesz pominąć bok, wpisz 0");
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine("Podaj długość {0}", sideLetters[i]);
                                userInput = Console.ReadLine();
                                double.TryParse(userInput, out userInputCheck);
                                if (userInputCheck >0)
                                {
                                    returnedValues[i] = userInputCheck;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Podano wartość nieliczbową, ujemną, bądź zerową. Program pominie to w obliczeniach. Jeżeli popełniłeś błąd, możesz wrócić później do tych danych i wprowadzić je ponownie.");
                                    Console.WriteLine("");
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Wybrano wpisywanie miar kątów wewnętrznych. Jeżeli chcesz pominąć bok, wpisz 0");
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine("Podaj miarę {0}", anglesLetters[i]);
                                userInput = Console.ReadLine();
                                double.TryParse(userInput, out userInputCheck);
                                if (userInputCheck > 0)
                                {
                                    returnedValues[i+3] = userInputCheck;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Podano wartość nieliczbową, ujemną, bądź zerową. Program pominie to w obliczeniach. Jeżeli popełniłeś błąd, możesz wrócić później do tych danych i wprowadzić je ponownie.");
                                    Console.WriteLine("");
                                }
                            }
                                if (returnedValues[3] + returnedValues[4] + returnedValues[5] != 180 && returnedValues[3] > 0 && returnedValues[4] > 0 && returnedValues[5] > 0)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Podano wszystkie miary kątów, ale łącznie nie dają one 180 stopni. Program pominie to w obliczeniach. Jeżeli popełniłeś błąd, możesz wrócić później do tych danych i wprowadzić je ponownie.");
                                    Console.WriteLine("");
                                    returnedValues[3] = 0;
                                    returnedValues[4] = 0;
                                    returnedValues[5] = 0;
                                }
                            break;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("Wybrano wpisywanie promienia okręgu opisanego na tym trójkącie. Jeżeli chcesz pominąć, wpisz 0");
                                Console.WriteLine("Podaj promień");
                                userInput = Console.ReadLine();
                                double.TryParse(userInput, out userInputCheck);
                                if (userInputCheck > 0)
                                {
                                    returnedValues[6] = userInputCheck;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Podano wartość nieliczbową, ujemną, bądź zerową. Program pominie to w obliczeniach. Jeżeli popełniłeś błąd, możesz wrócić później do tych danych i wprowadzić je ponownie.");
                                    Console.WriteLine("");
                                }
                            break;
                        case 4:
                            Console.WriteLine("");
                            Console.WriteLine("Wybrano wpisywanie promienia okręgu wpisanego na tym trójkącie. Jeżeli chcesz pominąć, wpisz 0");
                            Console.WriteLine("Podaj promień");
                            userInput = Console.ReadLine();
                            double.TryParse(userInput, out userInputCheck);
                            if (userInputCheck > 0)
                            {
                                returnedValues[7] = userInputCheck;
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Podano wartość nieliczbową, ujemną, bądź zerową. Program pominie to w obliczeniach. Jeżeli popełniłeś błąd, możesz wrócić później do tych danych i wprowadzić je ponownie.");
                                Console.WriteLine("");
                            }
                            break;
                        case 5:
                            whileStuff = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Podano opcję spoza zakresu. Wybierz opcję z zakresu 1-4.");
                    Console.WriteLine("");
                }
            }
            return returnedValues;
        }
        static int[] CheckFormula(double[] userInput)
        {
            // DANE Z TABLIC
            /*
            0,1,2 - długości boków, (a b c)
            3,4,5 - miary kątów wewnętrznych, (ab ac cb)
            6 - promień okręgu wpisanego,
            7 - promień okręgu opisanego

            1. Długość boków i kąt między tymi bokami
                1: 0 1 3,
                2: 1 2 5,
                3: 0 2 4
            2. Wszystkie boki trójkąta
                4: 0 1 2
            3. Kąty wewnętrzne i długość promienia okręgu opisanego na trójkącie
                5: 3 4 5 7
            */
            // Miejsca danych wymaganych do użycia wzoru
            int[,] formulas = {{0,1,3,10}, {1,2,5,10}, {0,2,4,10}, {0,1,2,10}, {3,4,5,7}};
            // Pasujący wzór jest 5, czyli spoza tablicy wzorów
            int matchedFormula = 5;
            int[] matchedFormulaArray = {0,0,0,0};
            for (int i = 0; i <= 4; i++)
            {
                int isFormulaMatch = 0;
                for (int j = 0; j < 4; j++) 
                // 0 1 3 - 15 20 45
                {
                    // if (formulas[i,j] != 10) if (userInput[formulas[i, j]] > 0) isFormulaMatch++;
                    // else isFormulaMatch++;
                    if (formulas[i,j] != 10)
                    {
                        if (userInput[formulas[i, j]] > 0) isFormulaMatch++;
                    } 
                    else isFormulaMatch++;
                }
                // if (isFormulaMatch == 4) matchedFormula = i;
                if (isFormulaMatch == 4)
                {
                    matchedFormula = i;
                }

                if (matchedFormula<5)
                {
                    matchedFormulaArray = new int[] {formulas[matchedFormula, 0], formulas[matchedFormula, 1], formulas[matchedFormula, 2], formulas[matchedFormula, 3]};
                    break;
                }
            }

            // deklarujemy zwracaną tablicę
            int[] returnedArray;
            if (matchedFormula == 5) returnedArray = new int[] { matchedFormula, 0, 0, 0, 0 };
            else returnedArray = new int[] {matchedFormula, matchedFormulaArray[0], matchedFormulaArray[1], matchedFormulaArray[2], matchedFormulaArray[3]};

            return returnedArray;
        }
        static string MathThis(double[] userValues, int[] formulaAndData)
        {
            if (formulaAndData[0] == 5)
            {
                return "Podane dane nie wystarczą do obliczenia pola trójkąta.";
            }
            else
            {
                double math;
                double math2;
                double result;
                switch (formulaAndData[0])
                {
                    case 0:
                    case 1:
                    case 2:
                        // dwa boki i kąt.
                        math = 0.5 * userValues[formulaAndData[1]] * userValues[formulaAndData[2]];
                        math2 = (userValues[formulaAndData[3]] * (Math.PI)) / 180;
                        math2 = Math.Sin(math2);
                        result = math * math2;
                        return "Odpowiedź to "+result;
                        break;
                    case 3:
                        // trzy boki
                        math = userValues[formulaAndData[1]] + userValues[formulaAndData[2]] + userValues[formulaAndData[3]];
                        math /= 2;
                        math2 = math * (math - userValues[formulaAndData[1]]) * (math - userValues[formulaAndData[2]]) * (math - userValues[formulaAndData[3]]);
                        result = Math.Sqrt(math2);
                        return "Odpowiedź to " + result;
                        break;
                    case 4:
                        // kąty i promień okręgu opisanego
                        double a = (userValues[formulaAndData[1]] * (Math.PI)) / 180;
                        a = Math.Sin(a);
                        double b = (userValues[formulaAndData[2]] * (Math.PI)) / 180;
                        b = Math.Sin(b);
                        double c = (userValues[formulaAndData[3]] * (Math.PI)) / 180;
                        c = Math.Sin(c);
                        math = userValues[formulaAndData[4]] * userValues[formulaAndData[4]];
                        result = 2 * math * a * b * c;
                        return "Odpowiedź to " + result;
                        break;
                    default:
                        return "To się nigdy nie zwróci, ale inaczej kompilator robi problemy :(";
                    break;
                }
            }
        }
        public static void Main(string[] args)
        {

            double[] userValues = GetStartedValues();
            int[] formulaAndData = CheckFormula(userValues);
            Console.WriteLine(MathThis(userValues, formulaAndData));

        }
    }
}