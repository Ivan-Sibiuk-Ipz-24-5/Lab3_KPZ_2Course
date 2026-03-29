using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Decorator
{
    public class Sword : HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription() => _hero.GetDescription() + " + Sword";
        public override int GetPower() => _hero.GetPower() + 5; // бонус сили
    }

    public class Armor : HeroDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetDescription() => _hero.GetDescription() + " + Armor";
        public override int GetPower() => _hero.GetPower() + 3;
    }

    public class Artifact : HeroDecorator
    {
        public Artifact(IHero hero) : base(hero) { }

        public override string GetDescription() => _hero.GetDescription() + " + Artifact";
        public override int GetPower() => _hero.GetPower() + 7;
    }
}
