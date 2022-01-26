namespace DIO.POO.src.Entities
{
    public class Mage : Hero
    {
        public Mage(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        } 
    }
}
