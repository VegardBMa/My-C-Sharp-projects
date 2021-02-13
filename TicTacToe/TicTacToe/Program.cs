using System;
using System.Diagnostics.CodeAnalysis;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Print();
            Rules rules = new Rules();
            Console.WriteLine("Enter position : ");


            for (var i = 0; i < 9; i++)
            {

                Board.State pos = Board.State.Invalid;
                int position = 0;
                while (pos != Board.State.Empty)
                {

                    char c = Console.ReadKey().KeyChar;
                    string inputPosition = c.ToString();
                     position = Convert.ToInt32(inputPosition);
                    pos = rules.CheckValidNumber(position, board);
                }
                var state = ((i % 2) == 0) ? Board.State.X : Board.State.O;
                board.SetState(state, position);
                Console.Clear();
                board.Print();


            }
            Console.ReadKey();
        }
    }
}
