using System;

namespace dz
{
    public class Character
    {
        public static void Create()
        {
            Console.WriteLine("Введите имя персонажа");
            string name = Console.ReadLine();
            Player.Name = name;
            Console.WriteLine("Выберите класс");
            Species.Show();
        }
    }
}