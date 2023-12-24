using System;

namespace dz
{
    public class Player
    {
        public static int damage = 5;
        private int health = 100;
        private int maxHealth = 100;
        public static int gold = 99999;
        private int level = 1;
        private string name;

        public Player(string _name)
        {
            name = _name;
        }

        public void WriteInfo()
        {
            Console.WriteLine("Ваш персонаж");
            Console.WriteLine($"Имя: {name}\n" +
                $"УР: {level}\n" +
                $"АТК: {damage}\n" +
                $"МАКС ОЗ: {maxHealth}\n" +
                $"Золота в кошельке: {gold}\n" +
                $"ЗАЩ: {PlayerArmor.armor}\n" +
                $"КАЧ ЗАЩ: {PlayerArmor.armorQuality}%");
        }

        public void SetHealthToMax()
        {
            maxHealth += PlayerArmor.armor;
            health = maxHealth;
        }

        public void IncreaseLevel()
        {
            level++;
            damage += 5;
            maxHealth += 5;
        }

        public void TakeDamage(int takenDamage)
        {
            int blockedDamage = PlayerArmor.UseArmor(takenDamage);
            takenDamage -= blockedDamage;
            if (health > 0)
            {
                Console.WriteLine("Вас атаковали!");
                health -= takenDamage;
                Console.WriteLine($"Вы потеряли {takenDamage} здоровья");
                Console.WriteLine($"У вас осталось {health} здоровья");
            }
        }

        public void SetLevel(int _level) => level = _level;

        public int GetHealth() => health;

        public int GetLevel() => level;

        public int GetDamage() => damage;
    }
}