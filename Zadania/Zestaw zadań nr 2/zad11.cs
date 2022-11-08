using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Zmodyfikuj program z poprzedniego zadania w taki sposób, by nie można
            było wstawić znaczka na miejscu już zajętym. Próba zajęcia miejsca już zajętego powoduje
            upomnienie gracza oraz prośbę o wskazanie innego miejsca.
            */

            string[] board = new string[] { "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "Hidden" };

            bool boardIsEmpty = false;
            bool playerNumber = true;
            int boardStatus = 0;
            int playerchoice = 9;

            while (boardIsEmpty == false)
            {
                Console.WriteLine("");
                Console.WriteLine("Plansza do gry wygląda tak:");
                Console.WriteLine("{0} {1} {2}", board[0], board[1], board[2]);
                Console.WriteLine("{0} {1} {2}", board[3], board[4], board[5]);
                Console.WriteLine("{0} {1} {2}", board[6], board[7], board[8]);
                Console.WriteLine("");

                if (playerNumber == true)
                {
                    while (board[playerchoice] != "[X]" ^ board[playerchoice] != "[O]")
                    {
                        Console.WriteLine("Gracz 2, podaj gdzie wstawić X");
                        playerchoice = Convert.ToInt32(Console.ReadLine());
                        playerchoice = playerchoice - 1;
                        if (board[playerchoice] == "[X]" ^ board[playerchoice] == "[O]")
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
                    while (board[playerchoice] != "[X]" ^ board[playerchoice] != "[O]")
                    {
                        Console.WriteLine("Gracz 1, podaj gdzie wstawić O");
                        playerchoice = Convert.ToInt32(Console.ReadLine());
                        playerchoice = playerchoice - 1;
                        if (board[playerchoice] == "[X]" ^ board[playerchoice] == "[O]")
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

                // Sprawdzane czy zajęte są wszystkie pola

                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == "[O]" ^ board[i] == "[X]")
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