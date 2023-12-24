using System;

namespace dz
{
    internal class Program
    {
        private static Random rand = new Random();

        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Как зовут вашего персонажа?");
            Player player = new Player(Console.ReadLine());

            while (true)
            {
                Console.Clear();
                player.WriteInfo();

                Console.WriteLine("\nВыберите один из пунктов ниже:");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1 - Вызвать на бой соперника");
                Console.WriteLine("2 - Ваш инвентарь и экипировка");
                Console.WriteLine("3 - Покупка предметов");

                input = Console.ReadLine();

                if (input.Contains("1"))
                {
                    EnemiesList.Update(rand, player);

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
                                Fight.Conduct(player, EnemiesList.list[i]);
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
                    Console.ReadKey();
                }
                else if (input.Contains("3"))
                {
                    Store.Show();
                }
                else if (input.Contains("0"))
                {
                    break;
                }

                foreach (Enemy enemy in EnemiesList.list)
                {
                    enemy.SetHealthToMax();
                }
                player.SetHealthToMax();
            }
        }
    }
}