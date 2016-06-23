using System.Numerics;

namespace MonsterClicker
{
    public class Boss : Creature
    {
        public Boss(Creature creature)
        {
            this.Health = creature.Health;
        }

        public override void GenerateInventory()
        {
            this.Money += this.Money / 2 < 1 ? 1 : this.Money / 2;
            this.Experience += this.Experience / 4 < 1 ? 1 : this.Experience / 4;
        }
    }
}