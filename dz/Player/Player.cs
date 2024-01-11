using System;

namespace dz
{
    public class Player
    {
        public static int damage = 5;
        private static int health = 100;
        private static int maxHealth = 100;
        public static int gold = 99999;
        private static int level = 1;
        private static string name;

        public static int armor = 0;
        public static int armorQuality = 0;

        public static string Name { get => name; set => name = value; }

        public static void WriteInfo()
        {
            Console.WriteLine("Ваш персонаж");
            Console.WriteLine($"Имя: {Name}\n" +
                $"УР: {level}\n" +
                $"АТК: {damage}\n" +
                $"МАКС ОЗ: {maxHealth}\n" +
                $"Золота в кошельке: {gold}\n" +
                $"ЗАЩ: {armor}\n" +
                $"КАЧ ЗАЩ: {armorQuality}%");
        }

        public static int UseArmor(int takenDamage)
        {
            int blockedDamage = takenDamage * armorQuality / 100;
            return blockedDamage;
        }

        public static void SetHealthToMax()
        {
            health = maxHealth + armor;
        }

        public static void IncreaseLevel()
        {
            level++;
            damage += 5;
            maxHealth += 5;
        }

        public static void TakeDamage(int takenDamage, bool isMissed)
        {
            if (isMissed)
            {
                Console.WriteLine("Противник промахнулся!");
                Console.WriteLine($"У вас осталось {health} здоровья");
            }
            else
            {
                int blockedDamage = UseArmor(takenDamage);
                takenDamage -= blockedDamage;
                if (health > 0)
                {
                    Console.WriteLine("Вас атаковали!");
                    health -= takenDamage;
                    Console.WriteLine($"Вы потеряли {takenDamage} здоровья");
                    Console.WriteLine($"У вас осталось {health} здоровья");
                }
            }
        }

        public static void SetLevel(int _level) => level = _level;

        public static int GetHealth() => health;

        public static int GetLevel() => level;

        public static int GetDamage() => damage;
    }
}