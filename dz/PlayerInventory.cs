using System;
using System.Collections.Generic;

namespace dz
{
    public class PlayerInventory
    {
        public static List<Item> items = new List<Item>();
        public static List<Item> equipped = new List<Item>();

        public static void AddItem(Item item)
        {
            items.Add(item);
        }

        public static void EquipItem(Item item)
        {
            if (!equipped.Contains(item))
            {
                equipped.Add(item);
                items.Remove(item);
                switch (item.itemType)
                {
                    case Item.ItemType.Armor:
                        PlayerArmor.armor += item.effective;
                        break;

                    case Item.ItemType.Weapon:
                        Player.damage += item.effective;
                        break;

                    case Item.ItemType.Accessory:
                        if (PlayerArmor.armorQuality + item.effective <= 100)
                        {
                            PlayerArmor.armorQuality += item.effective;
                        }
                        break;
                }
                Console.WriteLine("Предмет успешно экипирован");
            }
            else
            {
                Console.WriteLine("Этот предмет уже экипирован");
            }
        }

        public static void Show()
        {
            Console.WriteLine("Экипированные предметы:");
            for (int i = 0; i < equipped.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {equipped[i].name}");
            }

            Console.WriteLine("\nИнвентарь:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].name}");
            }
        }
    }
}
