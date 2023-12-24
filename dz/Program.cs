using System;

namespace dz
{
    internal class Program
    {
        private static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Как зовут вашего персонажа?");
            Player player = new Player(Console.ReadLine());

            while (true)
            {
                Menu.Update(player);
                foreach (Enemy enemy in EnemiesList.list)
                {
                    enemy.SetHealthToMax();
                }
                player.SetHealthToMax();
            }
        }
    }
}