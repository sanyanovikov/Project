using System;
using System.Collections.Generic;

namespace dz
{
    public class EnemiesList
    {
        public static List<Enemy> list = new List<Enemy>
            {
                new Enemy("Человек паук"),
                new Enemy("Дэдпул"),
                new Enemy("Халк"),
                new Enemy("Железный человек"),
                new Enemy("Доктор стрендж")
            };

        public static void Update(Random rand, Player player)
        {
            int newLevel;
            string tempName;

            for (int i = 0; i < list.Count; i++)
            {
                tempName = list[i].GetName();
                newLevel = rand.Next(player.GetLevel(), player.GetLevel() + 1);
                list[i].SetLevel(newLevel);
                list[i].SetName(tempName);
            }
        }
    }
}
