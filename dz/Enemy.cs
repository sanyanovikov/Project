using System;

namespace dz
{
    public class Enemy
    {
        private int damage = 5;
        private int health = 95;
        private int maxHealth = 95;
        private string name;
        private int level = 1;

        public Enemy(string _name)
        {
            name = _name;
        }

        public void WriteInfo(int number)
        {
            Console.WriteLine($"\n{number}. Имя: {name}\n" +
                $"Уровень: {level}\n" +
                $"Урон от атаки: {damage}");
        }

        public void TakeDamage(int takenDamage, bool isMissed)
        {
            if (isMissed)
            {
                Console.WriteLine("Вы промахнулись!");
                Console.WriteLine($"У вас осталось {health} здоровья");
            }
            else if (health > 0)
            {
                Console.WriteLine("Враг атакован!");
                health -= takenDamage;
                Console.WriteLine($"Враг потерял {takenDamage} здоровья");
                Console.WriteLine($"У врага {health} здоровья");
            }
        }

        public void SetLevel(int _level)
        {
            level = _level;
            maxHealth += 5 * level;
            damage = 5 * level;
        }


        public int GetHealth() => health;

        public string GetName() => name;

        public int GetDamage() => damage;

        public void SetName(string tempName) => name = tempName;

        public void SetHealthToMax() => health = maxHealth;
    }
}
