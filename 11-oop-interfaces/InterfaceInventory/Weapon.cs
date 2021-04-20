using System;

namespace InterfaceInventory
{
    public class Weapon : IInventoryItem
    {
        public string Name { get; set; }

        public string Type { get; private set; }

        public Weapon(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void Use()
        {
            Console.WriteLine("The weapon equipped!");
        }
    }
}