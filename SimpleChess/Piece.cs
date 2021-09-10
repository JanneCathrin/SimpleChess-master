using System;

namespace SimpleChess
{
    abstract class Piece
    {
        public string Symbol { get; }

        public Piece(string symbol)
        {
            Symbol = symbol;
        }

        public abstract bool Move(string fromPosition, string toPosition);
    }

    class Bishop : Piece
    {

        public Bishop() : base("LPR")
        {

        }
        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }
    }



        class Rook : Piece
        {

            public Rook() : base("TRN")
            {

            }

            public override bool Move(string fromPosition, string toPosition)
            {
                return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
            }


        }
    }


