using System;
namespace Exercise
{
    class Program
    {
        /* Różne potrzebne/przytane opisy.

            TABELA WYMIAN:
            1 owca = 6 królików
            1 świnia = 2 owce
            1 krowa = 3 świnie
            1 koń = 2 krowy
            1 mały pies = 1 owca
            1 duży pies = 1 krowa

            OPIS GRACZA: 
            0 - Królik
            1 - Owca
            2 - Świnia
            3 - Krowa
            4 - Koń
            5 - mały pies
            6 - duży pies

            KOSTKI:
            [0]             [1]
            0-5 królik      0-5 królik
            6-8 owca        6-7 owca
            9 świnia        8-9 świnia
            10 krowa        10 koń
            11 wilk         11 lis

            KONWERTOWANY RZUT:
            0 - Królik
            1 - Owca
            2 - Świnia
            3 - Krowa
            4 - Koń
            5 - Wilk
            6 - Lis

        */
        public static string AnimalName(int AnimalNumber)
        /*
            Funkcja dekodująca numer zwierzęcia na stringa. Ułatwia wypisywanie.
            Zwraca stringa z nazwą zwierzęcia.
        */
        {
            string returnedValue = "";
            switch (AnimalNumber)
            {
                case 0:
                    returnedValue = "Królik";
                break;
                case 1:
                    returnedValue = "Owca";
                break;
                case 2:
                    returnedValue = "Świnia";
                break;
                case 3:
                    returnedValue = "Krowa";
                break;
                case 4:
                    returnedValue = "Koń";
                break;
                case 5:
                    returnedValue = "Mały pies";
                break;
                case 6:
                    returnedValue = "Duży pies";
                break;
                case 7:
                    returnedValue = "Wilk";
                break;
                case 8:
                    returnedValue = "Lis";
                break;
                default:
                    returnedValue = "Nieznany typ zwierzęcia";
                break;
            }
            return returnedValue;
        }
        public static int[] ConvertRollToAnimalNumber(int[] roll)
        /*
            Funkcja konwertująca rzut kostką na numer zwierzęcia. Ułatwia pracę na kostkach o różnych wartościach.
            Zwraca dwuelementową tablicę intów, odpowiednio pierwszy i drugi rzut.
        */
        {
            int rolledAnimal0 = 10;
            int rolledAnimal1 = 10;
            switch (roll[0]) 
            {
                case 0: case 1: case 2: case 3: case 4: case 5: rolledAnimal0 = 0; break;
                case 6: case 7: case 8: rolledAnimal0 = 1; break;
                case 9: rolledAnimal0 = 2; break;
                case 10: rolledAnimal0 = 3; break;
                case 11: rolledAnimal0 = 7; break;
                default: break;

            }
            switch (roll[1])
            {
                case 0: case 1: case 2: case 3: case 4: case 5: rolledAnimal1 = 0; break;
                case 6: case 7: rolledAnimal1 = 1; break;
                case 8: case 9: rolledAnimal1 = 2; break;
                case 10: rolledAnimal1 = 4; break;
                case 11: rolledAnimal1 = 8; break;
                default: break;
            }
            int[] returnedInt = new int[2] {rolledAnimal0, rolledAnimal1};
            return returnedInt;
        }
        public static int[] DiceRoll()
        /*
            Funkcja losująca dwa rzuty kostką dwunastościenną.
            Zwraca dwuelementową tablicę intów, odpowiednio pierwszy i drugi rzut.
        */
        {

            var random1 = new Random();
            var random2 = new Random();

            double number1 = Math.Floor(Convert.ToDouble(random1.Next(0, 12)));
            double number2 = Math.Floor(Convert.ToDouble(random2.Next(0, 12)));
            int number1int = Convert.ToInt32(number1);
            int number2int = Convert.ToInt32(number2);

            int[] returnarray = new int[] { number1int, number2int };

            return returnarray;

        }

        public static int[] HerdUpdate(int[] player, int[] diceRoll)
        /*
            Funkcja aktualizująca farmę gracza na podstawie aktualnej farmy oraz rzutu.
            Na podstawie wyrzuconych zwierząt ustala czy i jakie zwierzęta graczowi zabrać bądź dać.
            Zwraca zaktualizowaną tablicę gracza.
        */
        {

            int[] rolledAnimals = ConvertRollToAnimalNumber(diceRoll);
            if (rolledAnimals[0] == 7 || rolledAnimals[1] == 8) // Jeżeli wylosujemy wilka lub lisa...
            {
                if (rolledAnimals[0] == 7)
                {
                    if (player[6] > 0) // Jeżeli gracz ma jakieś duże psy
                    {
                        player[6]--;
                    }
                    else
                    {
                        // Zostawiamy konie, króliki i małe psy
                        player[1] = 0;
                        player[2] = 0;
                        player[3] = 0;
                    }
                }
                if (rolledAnimals[1] == 8)
                {
                    if (player[5] > 0) // Jeżeli gracz ma jakieś małe psy
                    {
                        player[5]--;
                    }
                    else
                    {
                        // Bierzemy wszystkie króliki poza jednym
                        if (player[0] > 0)
                        {
                            player[0] = 1;
                        }
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Wyrzucone zwierzęta to: {0} i {1}", AnimalName(rolledAnimals[0]), AnimalName(rolledAnimals[1]));
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else // Każdy inny przypadek
            {
                    int whileStuff = 0;
                    int whileStuff1 = 0;
                    if (rolledAnimals[0] == rolledAnimals[1])
                    {
                        whileStuff = player[rolledAnimals[0]] + 2;
                        int howManyAnimalsGiveToPlayer = 0;
                        while (true)
                        {
                            whileStuff /= 2;
                            if (whileStuff >= 1)
                            {
                                // player[i]++;
                                howManyAnimalsGiveToPlayer++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        player[rolledAnimals[0]] += howManyAnimalsGiveToPlayer;
                    }
                    else
                    {
                        whileStuff = player[rolledAnimals[0]] + 1;
                        whileStuff1 = player[rolledAnimals[1]] + 1;
                        int howManyAnimalsGiveToPlayer = 0;
                        while (true)
                        {
                            whileStuff /= 2;
                            if (whileStuff >= 1)
                            {
                                // player[i]++;
                                howManyAnimalsGiveToPlayer++;
                            }
                            else
                            {
                                player[rolledAnimals[0]] += howManyAnimalsGiveToPlayer;
                                howManyAnimalsGiveToPlayer = 0;
                                break;
                            } 
                        }
                        while (true)
                        {
                            whileStuff1 /= 2;
                            if (whileStuff1 >= 1)
                            {
                                // player[i]++;
                                howManyAnimalsGiveToPlayer++;
                            }
                            else
                            {
                                player[rolledAnimals[1]] += howManyAnimalsGiveToPlayer;
                                howManyAnimalsGiveToPlayer = 0;
                                break;
                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Wyrzucone zwierzęta to: {0} i {1}", AnimalName(rolledAnimals[0]), AnimalName(rolledAnimals[1]));
                    Console.WriteLine("");
                    Console.WriteLine("");

            }



            return player;
        }
        public static bool IsGameWon(int[] player)
        /*
            Funkcja wymian zwierząt między graczem a stadem. Na podstawie tabeli wymian przeprowadza wymianę.
            Jeżeli spełnione są warunki określone w tabeli wymian, gra przeprowadza wymianę i wypisuje
            komunikat o powodzeniu, w przeciwnym razie o niepowodzeniu.
        */
        {
            int isAnimal = 0;
            for (int i = 0; i < 5; i++)
            {
                if (player[i] > 0)
                {
                    isAnimal++;
                }
                if (isAnimal == 5)
                {
                    return true;
                }
            }
            return false;
        }
        public static int[] HerdTrade(int[] player, int animalType, int animalAmount)
        {
            bool TradeSuccess = false;
            switch (animalType)
            {
                case 1:
                    if (6 * animalAmount <= player[0])
                    {
                        player[0] -= 6 * animalAmount;
                        player[1] = animalAmount;
                        TradeSuccess = true;
                    }
                break;

                case 2:
                    if (2 * animalAmount <= player[1])
                    {
                        player[1] -= 2 * animalAmount;
                        player[2] = animalAmount;
                        TradeSuccess = true;
                    }
                break;
                
                case 3:
                    if (3 * animalAmount <= player[2])
                    {
                        player[2] -= 3 * animalAmount;
                        player[3] = animalAmount;
                        TradeSuccess = true;
                    }
                break;
                
                case 4:
                    if (2 * animalAmount <= player[3])
                    {
                        player[3] -= 2 * animalAmount;
                        player[4] = animalAmount;
                        TradeSuccess = true;
                    }
                break;
                
                case 5:
                    if (1 * animalAmount <= player[1])
                    {
                        player[1] -= 1 * animalAmount;
                        player[5] = animalAmount;
                        TradeSuccess = true;
                    }
                break;
                
                case 6:
                    if (1 * animalAmount <= player[3])
                    {
                        player[3] -= 1 * animalAmount;
                        player[6] = animalAmount;
                        TradeSuccess = true;
                    }
                break;

                default:
                break;
            }
            Console.WriteLine("");
            if (TradeSuccess == true) Console.WriteLine("Wymiana udana.");
            else Console.WriteLine("Wymiana nieudana.");
            Console.WriteLine("");
            return player;
        }
        public static void Main(string[] args)
        {

            // int[] player1 = new int[7] { 0, 1, 1, 1, 1, 1, 1 };

            // while (true)
            // {
            //     int[] roll = DiceRoll();
            //     int[] herd = HerdUpdate(player1, roll);
            //     Console.WriteLine("");
            //     Console.WriteLine("");
            //     Console.WriteLine("Gracz player1 stan stada:");
            //     Console.WriteLine("Królików - {0}", player1[0]);
            //     Console.WriteLine("Owiec - {0}", player1[1]);
            //     Console.WriteLine("Świń - {0}", player1[2]);
            //     Console.WriteLine("Krów - {0}", player1[3]);
            //     Console.WriteLine("Koni - {0}", player1[4]);
            //     Console.WriteLine("Małych psów - {0}", player1[5]);
            //     Console.WriteLine("Dużych psów - {0}", player1[6]);
            //     Console.WriteLine("");
            //     Console.WriteLine("");
            //     if (IsGameWon(player1))
            //     {
            //         Console.WriteLine("Gra zakończona!");
            //         break;
            //     }
            //     else
            //     {
            //         Console.ReadLine();
            //     }
            // }

        }
    }
}