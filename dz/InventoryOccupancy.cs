using System;

namespace dz
{
    public class InventoryOccupancy
    {
        public static int inventoryLenght = 25;
        private static int currentLenght = 0;

        public static bool CheckInventoryOccupancy(Item item)
        {
            switch (item.itemLenght)
            {
                case Item.ItemLenght.Small:
                    if (currentLenght + 1 <= inventoryLenght)
                    {
                        currentLenght++;
                        return true;
                    }
                    break;

                case Item.ItemLenght.Medium:
                    if (currentLenght + 2 <= inventoryLenght)
                    {
                        currentLenght++;
                        return true;
                    }
                    break;

                case Item.ItemLenght.Large:
                    if (currentLenght + 3 <= inventoryLenght)
                    {
                        currentLenght++;
                        return true;
                    }
                    break;
            }

            Console.ReadKey();
            return false;
        }
    }
}
