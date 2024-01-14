using System;

namespace dz
{
    public class Player
    {
        private static int health = 100;
        private static Species species;
        private static string name;
        private static int level = 1;
        private static int maxHealth = 100;
        public static int damage = 5;
        public static int gold = 99999;
        public static int armor = 0;
        public static int armorQuality = 0;

        public static int Health { get => health; set => health = value; }
        public static Species Species { get => species; set => species = value; }
        public static string Name { get => name; set => name = value; }
        public static int Level { get => level; set => level = value; }
        public static int MaxHealth { get => maxHealth; set => maxHealth = value; }

        public static void WriteInfo()
        {
            Console.WriteLine("Ваш персонаж");
            Console.WriteLine($"Имя: {Name}\n" +
                $"Класс: {species.name}\n" +
                $"УР: {Level}\n" +
                $"АТК: {damage}\n" +
                $"МАКС ОЗ: {MaxHealth}\n" +
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
            Health = MaxHealth + armor;
        }

        public static void IncreaseLevel()
        {
            Level++;
            damage += 5;
            MaxHealth += 5;
        }

        public static void TakeDamage(int takenDamage, bool isMissed)
        {
            if (isMissed)
            {
                Console.WriteLine("Противник промахнулся!");
                Console.WriteLine($"У вас осталось {Health} здоровья");
            }
            else
            {
                int blockedDamage = UseArmor(takenDamage);
                takenDamage -= blockedDamage;
                if (Health > 0)
                {
                    Console.WriteLine("Вас атаковали!");
                    Health -= takenDamage;
                    Console.WriteLine($"Вы потеряли {takenDamage} здоровья");
                    Console.WriteLine($"У вас осталось {Health} здоровья");
                }
            }
        }

        public static void SetLevel(int _level) => Level = _level;

        public static int GetHealth() => Health;

        public static int GetLevel() => Level;
    }
}