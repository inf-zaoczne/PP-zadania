using System;
namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            Napisz program do gry w kółko i krzyżyk. Plansza ma wymiary 3x3. Na
            początku każde pole jest puste. Program pyta na przemian dwóch graczy (gracza X i gracza
            O) o to, w którym miejscu ma wstawić symbol. Gracz podaje miejsce, a program wstawia w
            to miejsce (niezależnie, czy jest zajęte czy nie) i wyświetla aktualny stan planszy. Program
            kończy działanie w momencie, gdy wszystkie miejsca będą zajęte.
            */

            string[] board = new string[] {"[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]"};

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
                playerchoice = playerchoice-1;
                board[playerchoice] = "[X]";
                playerNumber = false;
                }
                else
                {
                Console.WriteLine("Gracz 2, podaj gdzie wstawić O");
                int playerchoice = Convert.ToInt32(Console.ReadLine());
                playerchoice = playerchoice-1;
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