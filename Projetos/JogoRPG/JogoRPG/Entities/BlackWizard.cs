using System;

namespace JogoRPG.Entities
{
    class BlackWizard : Hero
    {
        public BlackWizard()
        {
        }

        public BlackWizard(string name, int level, string heroType, int hitPoint, int manaPoint)
            : base(name, level, heroType, hitPoint, manaPoint)
        {
        }

        public override string Attack(int dano)
        {
            Console.WriteLine($"{Name} atacou com a sua magia sombria!");
            return base.Attack(dano);
        }
    }
}
