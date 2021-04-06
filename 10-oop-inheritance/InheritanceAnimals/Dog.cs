namespace InheritanceAnimals
{
    public abstract class Dog : Animal
    {

        public string Name { get; set; } = "No name set!";
        public Dog()
        {
            this.EyeCount = 2;
            this.LegCount = 4;
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Woof woof!");
            // base.MakeSound();
        }

        public abstract void Bark();
    }
}