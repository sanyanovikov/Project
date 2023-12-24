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

        public static void UnequipItem(Item item)
        {
            if (equipped.Contains(item))
            {
                items.Add(item);
                equipped.Remove(item);
                Console.Clear();
                Console.WriteLine("Предмет успешно снят");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Данный предмет не экипирован или его не существует");
            }
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

                    default:
                        Console.WriteLine("Данный предмет нельзя экипировать");
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
            Console.Clear();
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

            Console.WriteLine("\n1 - Надеть предмет");
            Console.WriteLine("2 - Снять предмет");
            Console.WriteLine("0 - Вернуться");

            string input = Console.ReadLine();
            if (input.Contains("1"))
            {
                Console.WriteLine("Введите номер предмета, который вы хотите экипировать");
                input = Console.ReadLine();
                try
                {
                    EquipItem(items[int.Parse(input) - 1]);
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Такого предмета не существует либо он уже экипирован *_*");
                    Console.ReadKey();
                }
            }
            else if (input.Contains("2"))
            {
                Console.WriteLine("Введите номер предмета, который вы хотите cнять");
                input = Console.ReadLine();
                try
                {
                    UnequipItem(items[int.Parse(input) - 1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Такого предмета не существует либо он уже экипирован *_*");
                }
            }
        }
    }
}
