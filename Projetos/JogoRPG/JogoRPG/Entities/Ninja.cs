using System;

namespace JogoRPG.Entities
{
    class Ninja : Hero
    {
        public Ninja()
        {
        }

        public Ninja(string name, int level, string heroType, int hitPoint, int manaPoint)
            : base(name, level, heroType, hitPoint, manaPoint)
        {
        }

        public override string Attack(int dano)
        {
            Console.WriteLine($"{Name} atacou com a sua faca!");
            return base.Attack(dano);
        }
    }
}
