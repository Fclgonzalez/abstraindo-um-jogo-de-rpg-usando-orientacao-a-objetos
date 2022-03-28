namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int MagicPoints { get; set; }
        public string Class { get; set; }
       
    }
}