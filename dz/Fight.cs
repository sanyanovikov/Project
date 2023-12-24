﻿using System;

namespace dz
{
    public class Fight
    {
        static Random rand = new Random();

        public static void Conduct(Player player, Enemy enemy)
        {
            Console.Clear();
            while (player.GetHealth() > 0 & enemy.GetHealth() > 0)
            {
                enemy.TakeDamage(player.GetDamage());
                Console.WriteLine();
                if (enemy.GetHealth() > 0)
                {
                    player.TakeDamage(enemy.GetDamage());
                    Console.WriteLine();
                }
            }

            CheckWinner(player, enemy);
        }

        private static void CheckWinner(Player player, Enemy enemy)
        {
            if (enemy.GetHealth() > 0 & player.GetHealth() <= 0)
            {
                Console.WriteLine("Вы проиграли!");
                Console.WriteLine("Теперь вы снова слабы!");
                Console.WriteLine("Ваш уровень понижен до 1-го");
                player.SetLevel(1);
                Console.ReadKey();
            }
            else if (enemy.GetHealth() <= 0 & player.GetHealth() > 0)
            {
                player.IncreaseLevel();
                int receivedGold = rand.Next(25, 101);
                player.gold += receivedGold;
                Console.WriteLine("Вы победили! Ваш уровень увеличен на 1!");
                Console.WriteLine($"Вы получили {receivedGold} золота");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ничья!");
                Console.ReadKey();
            }
        }
    }
}