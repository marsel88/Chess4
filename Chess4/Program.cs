using System;

namespace Chess3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight f1 = new Knight(1, 1);
            Console.WriteLine(f1.Move(1, 4));

            Queen f2 = new Queen(1, 1);
            Console.WriteLine(f2.Move(2, 2));

            Bishop f3 = new Bishop(4, 4);
            Console.WriteLine(f3.Move(5, 5));

            Queen f4 = new Queen(1, 1);
            Console.WriteLine(f4.Move(2, 3));

            King f5 = new King(4, 4);
            Console.WriteLine(f5.Move(5, 5));

            Knight f6 = new Knight(1, 1);
            Console.WriteLine(f6.Move(8, 8));

            Rook f7 = new Rook(4, 4);
            Console.WriteLine(f7.Move(5, 5));

            Pawn f8 = new Pawn(2, 2);
            Console.WriteLine(f8.Move(2, 4));


        }
    }

    class Figure
    {
        public int x, y;

        public Figure(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public virtual bool Move(int newX, int newY)
        {
            return false;
        }
    }

    class King : Figure
    {
        public King(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
        }

        public override bool Move(int newX, int newY)
        {
            return (Math.Abs(x - newX) <= 1 && Math.Abs(y - newY) <= 1);
        }
    }

    class Queen : Figure
    {
        public Queen(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
        }

        public override bool Move(int newX, int newY)
        {
            return (x == newX || y == newY || Math.Abs(x - newX) == Math.Abs(y - newY));
        }
    }

    class Bishop : Figure
    {
        public Bishop(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
        }

        public override bool Move(int newX, int newY)
        {
            return (Math.Abs(x - newX) == Math.Abs(y - newY));
        }
    }

    class Knight : Figure
    {
        public Knight(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
        }

        public override bool Move(int newX, int newY)
        {
            return ((Math.Abs(x - newX) == 2 && Math.Abs(y - newY) == 1) || (Math.Abs(x - newX) == 1 && Math.Abs(y - newY) == 2));
        }
    }

    class Rook : Figure
    {
        public Rook(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
        }

        public override bool Move(int newX, int newY)
        {
            return (x == newX || y == newY);
        }
    }

    class Pawn : Figure
    {
        public Pawn(int newX, int newY) : base(newX, newY)
        {
            x = newX;
            y = newY;
        }

        public override bool Move(int newX, int newY)
        {
            return ((x == newX && y == 2 && y + 2 >= newY) || (x == newX && y + 1 == newY));
        }

    }
}
