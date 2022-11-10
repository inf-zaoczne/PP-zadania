using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] board = new string[]
            {
                "[]",
                "[]",
                "[]",
                "[]",
                "[]",
                "[]",
                "[]",
                "[]",
                "[]"
            };
            bool boardIsEmpty = false;
            bool playerNumber = true;
            int boardStatus = 0;
            while (boardIsEmpty == false)
            {
                Console.WriteLine("Plansza do gry wygląda tak:");
                Console.WriteLine("{0} {1} {2}", board[0], board[1], board[2]);
                Console.WriteLine("{0} {1} {2}", board[3], board[4], board[5]);
                Console.WriteLine("{0} {1} {2}", board[6], board[7], board[8]);
                Console.WriteLine("");
                if (playerNumber == true)
                {
                    Console.WriteLine("Gracz 1, podaj gdzie wstawić X");
                    int playerchoice = Convert.ToInt32(Console.ReadLine());
                    playerchoice = playerchoice - 1;
                    board[playerchoice] = "[X]";
                    playerNumber = false;
                }
                else
                {
                    Console.WriteLine("Gracz 2, podaj gdzie wstawić O");
                    int playerchoice = Convert.ToInt32(Console.ReadLine());
                    playerchoice = playerchoice - 1;
                    board[playerchoice] = "[O]";
                    playerNumber = true;
                }
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == "[O]" ^ board[i] == "[X]")
                    {
                        boardStatus += 1;
                    }
                }
                if (boardStatus == 9)
                {
                    Console.WriteLine("Koniec gry, plansza wygląda tak:");
                    Console.WriteLine("{0} {1} {2}", board[0], board[1], board[2]);
                    Console.WriteLine("{0} {1} {2}", board[3], board[4], board[5]);
                    Console.WriteLine("{0} {1} {2}", board[6], board[7], board[8]);
                    boardIsEmpty = true;
                }
                else boardStatus = 0;
            }
        }
    }
}