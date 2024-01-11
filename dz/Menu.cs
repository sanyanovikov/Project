using System;

namespace dz
{
    public class Menu
    {
        private static Random rand = new Random();
        private static string input;

        public static void Update()
        {
            Console.Clear();
            Player.WriteInfo();

            Console.WriteLine("\nВыберите один из пунктов ниже:");
            Console.WriteLine("0 - Выход");
            Console.WriteLine("1 - Вызвать на бой соперника");
            Console.WriteLine("2 - Ваш инвентарь и экипировка");
            Console.WriteLine("3 - Покупка предметов");

            input = Console.ReadLine();

            if (input.Contains("1"))
            {
                EnemiesList.Update(rand);

                Console.Clear();
                Console.WriteLine("Выбор соперника:");

                for (int i = 0; i < EnemiesList.list.Count; i++)
                {
                    EnemiesList.list[i].WriteInfo(i + 1);
                }

                input = Console.ReadLine();

                for (int i = 0; i < EnemiesList.list.Count; i++)
                {
                    try
                    {
                        if (i + 1 == int.Parse(input))
                        {
                            Fight.Conduct(EnemiesList.list[i]);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неверная строка!");
                    }
                }
            }
            else if (input.Contains("2"))
            {
                PlayerInventory.Show();
            }
            else if (input.Contains("3"))
            {
                Store.Show();
            }
            else if (input.Contains("0"))
            {
                Environment.Exit(0);
            }
        }
    }
}
