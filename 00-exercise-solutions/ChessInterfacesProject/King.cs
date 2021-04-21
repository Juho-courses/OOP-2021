using System;


namespace ChessInterfacesProject
{
    public class King : IChessPiece
    {
        public Location Location { get; set; }
        public string Color { get; set; }

        public King(Location location, string color)
        {
            Location = location;
            Color = color;
        }

        public void Move(Location target)
        {
            Location = target;
            Console.WriteLine($"{Color} king moved to {Location}");
        }
    }
}