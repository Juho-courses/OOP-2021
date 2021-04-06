namespace InheritanceAnimals
{
    public class GermanShepherd : Dog
    {
        public string Breed { get; private set; }

        public GermanShepherd(string name)
        {
            Breed = "German Shepherd";
            Name = name;
        }

        public override void Bark()
        {
            System.Console.WriteLine("WOOF WOOF!");
        }

        public override string ToString()
        {
            return $"A {Breed} named {Name}";
            // return base.ToString();
        }
    }
}