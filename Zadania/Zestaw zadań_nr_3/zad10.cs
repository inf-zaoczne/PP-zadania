using System;
namespace Exercise
{
    class Program
    {
        public static int[] DiceRoll()
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

        // public int[] HerdUpdate(int[] userHerd, int[] diceRoll){
        //     /*
        //         Dicerolls
        //         kostka nr 0
        //         0-5 królik
        //         6-8 owca
        //         9 świnia
        //         10 krowa
        //         11 wilk

        //         kostka nr 1
        //         0-5 królik
        //         6-7 owca
        //         8-9 świnia
        //         10 koń
        //         11 lis
        //     */

        //     /*
        //         Napisz funkcję, która przetwarza informacje o aktualnie posiadanym przez
        //         gracza stadzie oraz wartościach wyrzuconych na kostkach i na tej podstawie zwraca nowy
        //         stan stada gracza. Tymczasowo zignoruj ograniczenia na łączą liczbę zwierząt w grze.

        //         Są dwie kostki, diceroll[0] i diceroll[1]. 

        //         gracz dostaje tyle zwierząt ile ma pełnych par (Łacznie z rzutem). Jeżeli ma 3 owce i uda mu
        //         się wyrzucić owce, to dostaje 2 owce, bo wyszło pełnych par (3+1=4 więc dwie pary.)
        //         Zwierze dostaje się ze stada głównego.

        //         Jeżeli gracz ma 5 królików i dwie owce, a wyrzuci świnie i krowe, nic nie dostaje.
        //         Jeżeli ma tylko 2 króliki a wyrzuci dwie świnie to dostaje właśnie świnie.

        //         Konie i krowy są nie do dostania z rzutu, ponieważ są tylko po jednej na kostkę, więc bez wymiany
        //         nie da się ich uzyskać.


        //     */
        //     if (diceRoll[0] == diceRoll[1] && diceRoll[0] != 11 && ) // Dwa takie same typy zwierząt
        //     {

        //     }   

        //     return;
        // }
        public static void Main(string[] args)
        {
            DiceRoll();
        }
    }
}