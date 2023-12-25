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

        private static void UnequipItem(Item item)
        {
            if (equipped.Contains(item))
            {
                items.Add(item);
                equipped.Remove(item);
                SetProperty(item, item.effective * -1);

                Console.Clear();
                Console.WriteLine("Предмет успешно снят");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Данный предмет не экипирован или его не существует");
                Console.ReadKey();
            }
        }

        private static void EquipItem(Item item)
        {
            if (!equipped.Contains(item))
            {
                equipped.Add(item);
                items.Remove(item);
                SetProperty(item, item.effective);

                Console.Clear();
                Console.WriteLine("Предмет успешно экипирован");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Этот предмет уже экипирован");
                Console.ReadKey();
            }
        }

        private static void SetPropertyPlayer(ref int property, int itemEffective)
        {
            property += itemEffective;
        }

        private static void SetProperty(Item item, int itemEffective)
        {
            switch (item.itemType)
            {
                case Item.ItemType.Armor:
                    SetPropertyPlayer(ref Player.armor, item.effective);
                    break;

                case Item.ItemType.Weapon:
                    SetPropertyPlayer(ref Player.damage, item.effective);
                    break;

                case Item.ItemType.Accessory:
                    SetPropertyPlayer(ref Player.armorQuality, item.effective);
                    break;
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
            EquipmentAction();
        }

        private static void EquipmentAction()
        {
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
