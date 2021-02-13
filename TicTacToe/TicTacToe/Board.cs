using System;

namespace TicTacToe
{
    public class Board
    {
        public enum PositionsOnTheBoard : int { Invalid = 0, BottomLeft = 1, BottomMiddle = 2, BottomRight = 3, MiddleLeft = 4, Middle = 5, MiddleRight = 6, TopLeft = 7, TopMiddle = 8, TopRight = 9 }
        public enum State { Empty, X, O, Invalid }


        private State[,] _table = new State[3, 3];

        public Board()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _table[i, j] = State.Empty;
                }
            }

        }


        public void Print()
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    switch (_table[i, j])
                    {
                        case State.O:
                            Console.Write(" O ");
                            break;
                        case State.X:
                            Console.Write(" X ");
                            break;
                        default:
                            Console.Write("   ");
                            break;

                    }
                    if (j + 1 < 3)
                        Console.Write("|");


                }
                Console.WriteLine();
                if (i + 1 < 3)
                    Console.WriteLine("---+---+---");
            }
        }

        public void SetState(State state, int position)
        {
            var pos = (Board.PositionsOnTheBoard)position;
            switch (pos)
            {
                case PositionsOnTheBoard.BottomLeft:
                    _table[2, 0] = state;
                    break;

                case PositionsOnTheBoard.BottomMiddle:
                    _table[2, 1] = state;
                    break;

                case PositionsOnTheBoard.BottomRight:
                     _table[2, 2] = state;
                    break;

                case PositionsOnTheBoard.MiddleLeft:
                     _table[1, 0] = state;
                    break;

                case PositionsOnTheBoard.Middle:
                     _table[1, 1] = state;
                    break;

                case PositionsOnTheBoard.MiddleRight:
                     _table[1, 2] = state;
                    break;

                case PositionsOnTheBoard.TopLeft:
                     _table[0, 0] = state;
                    break;

                case PositionsOnTheBoard.TopMiddle:
                     _table[0, 1] = state ;
                    break;

                case PositionsOnTheBoard.TopRight:
                     _table[0, 2] = state;
                    break;

                default:
                    break;

            }
        }

        public State GetState(Board.PositionsOnTheBoard pos)
        {

            switch (pos)
            {
                case PositionsOnTheBoard.BottomLeft:
                    return _table[2, 0];

                case PositionsOnTheBoard.BottomMiddle:
                    return _table[2, 1];

                case PositionsOnTheBoard.BottomRight:
                    return _table[2, 2];

                case PositionsOnTheBoard.MiddleLeft:
                    return _table[1, 0];

                case PositionsOnTheBoard.Middle:
                    return _table[1, 1];

                case PositionsOnTheBoard.MiddleRight:
                    return _table[1, 2];

                case PositionsOnTheBoard.TopLeft:
                    return _table[0, 0];

                case PositionsOnTheBoard.TopMiddle:
                    return _table[0, 1];

                case PositionsOnTheBoard.TopRight:
                    return _table[0, 2];

                default:
                    break;

            }

            return State.Invalid;
        }
    }
}
