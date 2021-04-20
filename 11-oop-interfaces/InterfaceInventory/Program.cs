using System;
using System.Collections.Generic;

namespace InterfaceInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            // inventory = []
            List<IInventoryItem> inventory = new List<IInventoryItem>();

            // insert weapon
            Weapon w1 = new Weapon("Excalibur", "sword");
            inventory.Add(w1);

            // insert health potion
            HealthPotion h1 = new HealthPotion("Great HP POTION", 100);
            inventory.Add(h1);

            // inventory[0].Name
            foreach (var item in inventory)
            {
                Console.WriteLine(item.Name);
            }

            // use the items in the invetory
            inventory[0].Use();
            inventory[1].Use();

            // Console.WriteLine(inventory[0].HPGain);
            HealthPotion htmp = (HealthPotion)inventory[1];
            Console.WriteLine(htmp.HPGain);
        }
    }
}
