namespace ChessInterfacesProject
{
    public class Location
    {
        public int Row { get; set; }
        public string Col { get; set; }

        public Location(string col, int row)
        {
            Row = row;
            Col = col;
        }

        public override string ToString()
        {
            return $"{Col}{Row}";
        }
    }
}