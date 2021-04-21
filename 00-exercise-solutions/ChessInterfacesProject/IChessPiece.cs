namespace ChessInterfacesProject
{
    public interface IChessPiece
    {
        Location Location { get; set; }
        string Color { get; set; }

        public void Move(Location target);
    }
}