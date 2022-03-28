namespace RPG.src.Entities
{
    public class Ninja: Hero
    {
        public Ninja(string Name, int Level, int HealthPoints, int MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
            this.Class = "Ninja";
        }

        public override string ToString()
        {
            return "Class: " + Class + "; " + "Name: " + Name + "; " + "Lvl: " + Level + "; " + "HP: " + HealthPoints + "; " + "MP: " + MagicPoints ;
        
            
        }
    }
}