namespace dz
{
    public class Elf : Species
    {
        public Elf() 
        {
            name = "Эльф";
            description = "Класс карлик со смешными ушами и повышенным здоровьем\n(Здоровье увеличено," +
                " урон незначительно снижен)";
            damageModifier = -3;
            healthModifier = 20;
        }
    }
}
