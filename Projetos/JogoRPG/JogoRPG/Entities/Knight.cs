using System;

namespace JogoRPG.Entities
{
    class Knight : Hero
    {
        public Knight()
        {
        }

        public Knight(string name, int level, string heroType, int hitPoint, int manaPoint)
            : base(name, level, heroType, hitPoint, manaPoint)
        {
        }

        public override string Attack(int dano)
        {
            Console.WriteLine($"{Name} atacou com a sua espada!");
            return base.Attack(dano);
        }
    }
}
