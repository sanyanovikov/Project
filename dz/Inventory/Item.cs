namespace dz
{
    public class Item
    {
        public string name;
        public int cost;
        public int effective;
        public ItemType itemType;
        public ItemLenght itemLenght;
        public ItemClass itemClass;

        public enum ItemClass
        {
            Any = 0,
            Human = 1,
            Elf = 2
        }

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

        public Item(ItemType _itemType, ItemLenght _itemLenght, ItemClass _itemClass, string _name, int _cost, int _effective)
        {
            itemType = _itemType;
            itemLenght = _itemLenght;
            itemClass = _itemClass;
            cost = _cost;
            name = _name;
            effective = _effective;
        }
    }
}
