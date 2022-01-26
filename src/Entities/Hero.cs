namespace DIO.POO.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return $"{this.Name} {this.Level} {this.HeroType}";
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
}
