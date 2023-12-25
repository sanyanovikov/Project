using System.Collections.Generic;

namespace dz
{
    public class EquippedSlots
    {
        public static Dictionary<Item.ItemType, bool> slots = new Dictionary<Item.ItemType, bool>
        {
            { Item.ItemType.Armor, false },
            { Item.ItemType.Weapon, false },
            { Item.ItemType.Accessory, false }
        };

        public static bool CheckAvaibleSlot(Item item)
        {
            foreach (var slot in slots)
            {
                if (item.itemType == slot.Key)
                {
                    if (!slot.Value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    } 
}
