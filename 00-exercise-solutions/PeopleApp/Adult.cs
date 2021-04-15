namespace PeopleApp
{
    public class Adult : Person
    {
        public string Car { get; set; }

        public Adult(string name, int age)
        {
            Name = name;
            Age = age;
            Type = "adult";
        }

        public override string ToString()
        {
            return base.ToString() + $", fav car is {Car}";
        }
    }
}