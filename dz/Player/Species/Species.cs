using System;
using System.Collections.Generic;

namespace dz
{
    public class Species
    {
        private static List<Species> speciesList = new List<Species>()
        {
            new Elf(),
            new Human()
        };

        public string name;
        protected string description;
        protected int damageModifier;
        protected int healthModifier;
        protected Item.ItemClass itemClass;

        public static void Show()
        {
            for (int i = 0; i < speciesList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {speciesList[i].name}\n{speciesList[i].description}");
            }
            Choice();
            Console.ReadKey();
        }

        private static void Choice()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < speciesList.Count; i++)
            {
                if (i + 1 == input)
                {
                    Player.itemClass = speciesList[i].itemClass;
                    Player.Species = speciesList[i];
                    Player.damage += speciesList[i].damageModifier;
                    Player.MaxHealth += speciesList[i].healthModifier;
                    break;
                }
            }
        }
    }
}
