namespace dz
{
    public class Human : Species
    {
        public Human() 
        {
            name = "Человек";
            description = "Обычный класс, все по стандарту";
            damageModifier = 0;
            healthModifier = 0;
            itemClass = Item.ItemClass.Human;
        }
    }
}
