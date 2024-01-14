using System;

namespace dz
{
    internal class Program
    {
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