namespace InheritanceAnimals
{
    static class AnimalStats
    {
        // doesn't work, because instance member
        // private int count = 0;
        public static float CalculateEyesToLegsRatio(Animal animal)
        {
            return (float)animal.EyeCount / animal.LegCount;
        }
    }
}