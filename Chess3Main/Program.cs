using System;
using Library;

namespace Chess3Main
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
}
