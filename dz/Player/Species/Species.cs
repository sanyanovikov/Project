using System;
using System.Collections.Generic;

namespace dz
{
    public class Species
    {
        protected List<Species> speciesList = new List<Species>();

        protected string name;
        protected string description;
        protected int damageModifier;
        protected int healthModifier;

        public static void Show()
        {
            Console.WriteLine();
        }
    }
}
