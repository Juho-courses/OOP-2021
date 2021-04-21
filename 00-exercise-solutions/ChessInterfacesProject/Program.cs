using System;

namespace ChessInterfacesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Pawn p1 = new Pawn(new Location("A", 2), "white");
            Console.WriteLine(p1.ToString());
            p1.Move(new Location("A", 4));
            Console.WriteLine(p1);

            Location king_loc = new Location("D", 1);
            King k1 = new King(king_loc, "white");
            k1.Move(new Location("E", 2));
            Console.WriteLine(k1.Location.Col);

            // Console.WriteLine("E2".Substring(0, 1));
            // Console.WriteLine("E2".Substring(1, 1));
        }
    }
}
