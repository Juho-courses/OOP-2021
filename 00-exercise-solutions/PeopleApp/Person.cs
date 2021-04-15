namespace PeopleApp
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; protected set; }

        public override string ToString()
        {
            return $"{Name}, age {Age}";
        }

    }
}