using System;


namespace ChessInterfacesProject
{
    public class Pawn : IChessPiece
    {
        public Location Location { get; set; }
        public string Color { get; set; }

        public Pawn(Location location, string color)
        {
            Location = location;
            Color = color;
        }

        public void Move(Location target)
        {
            Location = target;
            Console.WriteLine($"{Color} pawn moved to {Location}");
        }

        public override string ToString()
        {
            return $"{Color} pawn at {Location}";
        }
    }
}