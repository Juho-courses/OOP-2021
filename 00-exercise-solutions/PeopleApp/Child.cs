namespace PeopleApp
{
    public class Child : Person
    {
        public string Bike { get; set; }

        public Child(string name, int age)
        {
            Name = name;
            Age = age;
            Type = "child";
        }

        public override string ToString()
        {
            return base.ToString() + $", fav bike is {Bike}";
        }
    }
}