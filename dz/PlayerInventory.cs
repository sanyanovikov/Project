using System;
using System.Collections.Generic;

namespace dz
{
    public class PlayerInventory
    {
        public static List<Item> items = new List<Item>();
        public static List<Item> equippedItems = new List<Item>();

        public static void AddItem(Item item)
        {
            items.Add(item);
        }

        public static void EquipItem(Item item)
        {
            equippedItems.Add(item);
        }

        public static void Show()
        {
            Console.WriteLine("Экипированные предметы:");
            for (int i = 0; i < equippedItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {equippedItems[i].name}");
            }

            Console.WriteLine("\nИнвентарь:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].name}");
            }
        }
    }
}
