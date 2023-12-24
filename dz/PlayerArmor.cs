using System;

namespace dz
{
    public class PlayerArmor : Player
    {
        public static int armor = 0;
        public static int armorQuality = 0;

        public PlayerArmor(string _name) : base(_name) { }

        public static int UseArmor(int takenDamage)
        {
            int blockedDamage = takenDamage * armorQuality / 100;
            return blockedDamage;
        }
    }
}
