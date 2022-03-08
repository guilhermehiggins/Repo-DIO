namespace JogoRPG.Entities
{
    public abstract class Hero
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public string HeroType { get; private set; }
        public int HitPoint { get; private set; }
        public int ManaPoint { get; private set; }

        public Hero()
        {
        }

        public Hero(string name, int level, string heroType, int hitPoint, int manaPoint)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            HitPoint = hitPoint;
            ManaPoint = manaPoint;
        }

        public override string ToString()
        {
            return Name + " " + Level + " " + HeroType;
        }

        public virtual string Attack(int dano)
        {
            if (dano > 0 && dano <= 10)
            {
                return $"O ataque teve {dano} de dano\n";
            }
            else if (dano > 10)
            {
                double bonus = dano * 0.20;
                return $"O ataque foi super efetivo! Teve {dano} de dano e mais {((int)bonus)} de bonus\n";
            }

            return $"{Name} errou o ataque!\n";
        }
    }
}
