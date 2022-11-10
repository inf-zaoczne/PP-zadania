using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] board = new string[]
            {
                "[ ]",
                "[ ]",
                "[ ]",
                "[ ]",
                "[ ]",
                "[ ]",
                "[ ]",
                "[ ]",
                "[ ]",
                "Hidden"
            };
            string checkingMark = "";
            int correctMarks = 0;
            bool result = false;
            bool boardIsEmpty = false;
            bool playerNumber = true;
            int boardStatus = 0;
            int playerchoice = 9;
            int[, ] winOptions = new int[8, 3]{ { 0, 1, 2 }, 
            { 3, 4, 5 }, 
            { 6, 7, 8 }, 
            { 0, 3, 6 }, 
            { 1, 4, 7 }, 
            { 2, 5, 8 }, 
            { 0, 4, 8 }, 
            { 2, 4, 6 } };
            // winOptions[0, 0], winOptions[0, 1], winOptions[0, 2]
            while (boardIsEmpty == false)
            {
                // Pierwsze wypisaine planszy
                Console.WriteLine("");
                Console.WriteLine("Plansza do gry wygląda tak:");
                Console.WriteLine("{0} {1} {2}", board[0], board[1], board[2]);
                Console.WriteLine("{0} {1} {2}", board[3], board[4], board[5]);
                Console.WriteLine("{0} {1} {2}", board[6], board[7], board[8]);
                Console.WriteLine("");
                // Zamiana graczy
                if (playerNumber == true)
                {
                    while (board[playerchoice] == "[X]" || board[playerchoice] == "[O]")
                    {
                        Console.WriteLine("Gracz 2, podaj gdzie wstawić X");
                        playerchoice = Convert.ToInt32(Console.ReadLine());
                        playerchoice = playerchoice - 1;
                        // Sprawdzanie czy nie chciał zająć zajętego pola
                        if (board[playerchoice] == "[X]" || board[playerchoice] == "[O]")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("To miejsce jest już zajęte, wpisz inne miejsce.");
                            Console.WriteLine("{0} {1} {2}", board[0], board[1], board[2]);
                            Console.WriteLine("{0} {1} {2}", board[3], board[4], board[5]);
                            Console.WriteLine("{0} {1} {2}", board[6], board[7], board[8]);
                            Console.WriteLine("");
                            playerchoice = 9;
                        }
                    }
                    board[playerchoice] = "[X]";
                    playerNumber = false;
                }
                else
                {
                    while (board[playerchoice] == "[X]" || board[playerchoice] == "[O]")
                    {
                        Console.WriteLine("Gracz 1, podaj gdzie wstawić O");
                        playerchoice = Convert.ToInt32(Console.ReadLine());
                        playerchoice = playerchoice - 1;
                        // Sprawdzanie czy nie chciał zająć zajętego pola
                        if (board[playerchoice] == "[X]" || board[playerchoice] == "[O]")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("To miejsce jest już zajęte, wpisz inne miejsce.");
                            Console.WriteLine("{0} {1} {2}", board[0], board[1], board[2]);
                            Console.WriteLine("{0} {1} {2}", board[3], board[4], board[5]);
                            Console.WriteLine("{0} {1} {2}", board[6], board[7], board[8]);
                            Console.WriteLine("");
                            playerchoice = 9;
                        }
                    }
                    board[playerchoice] = "[O]";
                    playerNumber = true;
                }
                /* Sprawdzanie czy wygrana
                pierwszy for robi kod 8 razy, dla każdego przypadku w winOptions. if ogracznia ilość opcji OR w 
                sprawdzaniu kolejnych opcji, bo samemu sprawdzi czy wartości są równe dla X jak i dla O.

                na kazde rozwiazanie mamy jedna petle. w srodku druga petla sprawdzajaca dla X i dla O.
                */
                for (int i = 0; i <= 7; i++)
                {
                    for (int j = 0; j <= 1; j++)
                    {
                        if (j == 0) checkingMark = "[X]";
                        else if (j == 1) checkingMark = "[O]";
                        for (int k = 0; k <= 2; k++)
                        {
                            if (board[winOptions[i, k]] == checkingMark) correctMarks++;
                            if (correctMarks == 3) result = true;
                        }
                        // SPRAWDZANIE
                        if (result == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Gra zakończona wygraną {0}, plansza do gry wygląda tak:", checkingMark);
                            Console.WriteLine("{0} {1} {2}", board[0], board[1], board[2]);
                            Console.WriteLine("{0} {1} {2}", board[3], board[4], board[5]);
                            Console.WriteLine("{0} {1} {2}", board[6], board[7], board[8]);
                            Console.WriteLine("");
                            boardIsEmpty = true;
                        }
                        else correctMarks = 0;
                    }
                }
                // Sprawdzanie czy zajęte są wszystkie pola
                if (boardIsEmpty == false)
                {
                    for (int i = 0; i < board.Length; i++)
                    {
                        if (board[i] == "[O]" || board[i] == "[X]")
                        {
                            boardStatus += 1;
                        }
                    }
                    if (boardStatus == 10)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Gra zakończona remisem, plansza do gry wygląda tak:");
                        Console.WriteLine("{0} {1} {2}", board[0], board[1], board[2]);
                        Console.WriteLine("{0} {1} {2}", board[3], board[4], board[5]);
                        Console.WriteLine("{0} {1} {2}", board[6], board[7], board[8]);
                        Console.WriteLine("");
                        boardIsEmpty = true;
                    }
                    else boardStatus = 0;
                }
            }
        }
    }
}