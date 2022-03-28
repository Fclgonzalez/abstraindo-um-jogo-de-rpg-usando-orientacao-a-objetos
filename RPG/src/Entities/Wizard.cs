namespace RPG.src.Entities
{
    public class Wizard: Hero
    {
        public Wizard(string Name, int Level, int HealthPoints, int MagicPoints, string Class)
        {
            this.Name = Name;
            this.Level = Level;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
            this.Class = Class + " Wizard";
        }

        public override string ToString()
        {
            return "Class: " + Class + "; " + "Name: " + Name + "; " + "Lvl: " + Level + "; " + "HP: " + HealthPoints + "; " + "MP: " + MagicPoints ;
        
        }
    }
}