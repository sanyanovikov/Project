using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz
{
    public class Item
    {
        public string name;
        public int cost;
        public int effective;
        public ItemType itemType;
        ItemLenght itemLenght;

        public enum ItemType
        {
            Armor = 0,
            Weapon = 1,
            Accessory = 2
        }

        public enum ItemLenght
        {
            Small = 0,
            Medium = 1,
            Large = 2
        }

        public Item(ItemType _itemType, ItemLenght _itemLenght, string _name, int _cost, int _effective)
        {
            itemType = _itemType;
            itemLenght = _itemLenght;
            cost = _cost;
            name = _name;
            effective = _effective;
        }
    }
}
