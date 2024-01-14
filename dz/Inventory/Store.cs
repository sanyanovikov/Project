using System;
using System.Collections.Generic;

namespace dz
{
    public class Store
    {
        private static List<Item> store = new List<Item>
        {
            new Item(Item.ItemType.Armor, Item.ItemLenght.Large, Item.ItemClass.Any, "Золотая броня", 1000, 10),
            new Item(Item.ItemType.Weapon, Item.ItemLenght.Small, Item.ItemClass.Any, "Кинжал", 100, 5),
            new Item(Item.ItemType.Accessory, Item.ItemLenght.Small, Item.ItemClass.Elf, "Рубинчик (Класс эльф)", 200, 10)
        };

        private static void ValidateBuy(int index)
        {
            index -= 1;
            if (Player.gold >= store[index].cost)
            {
                if (store[index].itemClass == Item.ItemClass.Any)
                {
                    Buy(index);
                }
                else if (Player.itemClass == store[index].itemClass)
                {
                    Buy(index);
                }
                else
                {
                    Console.WriteLine("Ваш класс не может это носить");
                }
            }
            else
            {
                Console.WriteLine("Недостаточно золота");
            }
        }

        private static void Buy(int index)
        {
            PlayerInventory.items.Add(store[index]);
            Player.gold -= store[index].cost;
            Console.WriteLine($"Предмет {store[index].name} успешно приобретен");
        }

        public static void Show()
        {
            Console.Clear();
            Console.WriteLine($"Баланс: {Player.gold}");
            Console.WriteLine("Предметы для покупки");
            for (int i = 0; i < store.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {store[i].name} - {store[i].cost} золота");
            }

            Console.WriteLine("Ваш выбор:");
            string input = Console.ReadLine();
            try
            {
                if (int.Parse(input) <= store.Count)
                {
                    ValidateBuy(int.Parse(input));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Неверное число");
            }
            
            Console.ReadKey();
        }
    }
}
