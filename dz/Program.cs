using System;

namespace dz
{
    internal class Program
    {
        private static Random rand = new Random();

        static void Main(string[] args)
        {
            Character.Create();

            while (true)
            {
                Menu.Update();
                foreach (Enemy enemy in EnemiesList.list)
                {
                    enemy.SetHealthToMax();
                }
                Player.SetHealthToMax();
            }
        }
    }
}