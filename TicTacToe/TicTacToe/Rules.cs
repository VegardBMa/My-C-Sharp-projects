using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TicTacToe
{
    public class Rules
    {

        public Board.State CheckValidNumber(int position, Board board)
        {


            if (position < 1 || position > 9)
            {
                Console.WriteLine("Invalid number.");
                return Board.State.Invalid;
            }
            else
            {
                var pos = (Board.PositionsOnTheBoard)position;
                return board.GetState(pos);

            }

        }

        public bool PlayerHasWon(Board board, Board.State state)
        {

            Board.State[] row = new Board.State[3];
            row[0] = board.GetState(Board.PositionsOnTheBoard.BottomLeft);
            row[1] = board.GetState(Board.PositionsOnTheBoard.BottomMiddle);    //#1
            row[2] = board.GetState(Board.PositionsOnTheBoard.BottomRight);
            if (CheckRow(row, state))           
                return true;

            row[0] = board.GetState(Board.PositionsOnTheBoard.MiddleLeft);
            row[1] = board.GetState(Board.PositionsOnTheBoard.Middle);          //#2
            row[2] = board.GetState(Board.PositionsOnTheBoard.MiddleRight);
            if (CheckRow(row, state))
                return true;

            row[0] = board.GetState(Board.PositionsOnTheBoard.TopLeft);
            row[1] = board.GetState(Board.PositionsOnTheBoard.TopMiddle);       //#3
            row[2] = board.GetState(Board.PositionsOnTheBoard.TopRight);
            if (CheckRow(row, state))
                return true;

            row[0] = board.GetState(Board.PositionsOnTheBoard.BottomLeft);
            row[1] = board.GetState(Board.PositionsOnTheBoard.MiddleLeft);      //#4
            row[2] = board.GetState(Board.PositionsOnTheBoard.TopLeft);
            if (CheckRow(row, state))
                return true;

            row[0] = board.GetState(Board.PositionsOnTheBoard.BottomMiddle);
            row[1] = board.GetState(Board.PositionsOnTheBoard.Middle);          //#5
            row[2] = board.GetState(Board.PositionsOnTheBoard.TopMiddle);
            if (CheckRow(row, state))
                return true;

            row[0] = board.GetState(Board.PositionsOnTheBoard.BottomRight);
            row[1] = board.GetState(Board.PositionsOnTheBoard.MiddleRight);     //#6
            row[2] = board.GetState(Board.PositionsOnTheBoard.TopRight);
            if (CheckRow(row, state))
                return true;

            row[0] = board.GetState(Board.PositionsOnTheBoard.BottomLeft);
            row[1] = board.GetState(Board.PositionsOnTheBoard.Middle);          //#7
            row[2] = board.GetState(Board.PositionsOnTheBoard.TopRight);
            if (CheckRow(row, state))
                return true;

            row[0] = board.GetState(Board.PositionsOnTheBoard.BottomRight);
            row[1] = board.GetState(Board.PositionsOnTheBoard.Middle);          //#8
            row[2] = board.GetState(Board.PositionsOnTheBoard.TopLeft);
            if (CheckRow(row, state))

                return true;


            return false;
        
        }

        private bool CheckRow(Board.State[] row, Board.State state)
        {
            return row[0] == state && row[1] == state && row[2] == state;
        }
    }
}
