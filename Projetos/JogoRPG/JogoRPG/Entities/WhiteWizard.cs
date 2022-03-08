using System;

namespace JogoRPG.Entities
{
    class WhiteWizard : Hero
    {
        public WhiteWizard()
        {
        }

        public WhiteWizard(string name, int level, string heroType, int hitPoint, int manaPoint)
            : base(name, level, heroType, hitPoint, manaPoint)
        {
        }

        public override string Attack(int dano)
        {
            Console.WriteLine($"{Name} atacou com a sua magia de água!");
            return base.Attack(dano);
        }
    }
}
