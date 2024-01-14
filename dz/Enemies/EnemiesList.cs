using System;
using System.Collections.Generic;

namespace dz
{
    public class EnemiesList
    {
        public static List<Enemy> list = new List<Enemy>
            {
                new Enemy("Zombie"),
                new Enemy("Orc"),
                new Enemy("Goblin"),
                new Enemy("Giant"),
            };

        public static void Update(Random rand)
        {
            int newLevel;
            string tempName;

            for (int i = 0; i < list.Count; i++)
            {
                tempName = list[i].GetName();
                newLevel = rand.Next(Player.Level, Player.Level + 1);
                list[i].SetLevel(newLevel);
                list[i].SetName(tempName);
            }
        }
    }
}
