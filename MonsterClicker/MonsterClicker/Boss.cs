namespace MonsterClicker
{
    using System.Numerics;

    public class Boss : Creature
    {
        public Boss(Creature creature)
        {
            this.Health = creature.Health;
        }

        public override void GenerateHealth()
        {
            this.Health *= 5;
        }

        public override void GenerateInventory()
        {
            this.Money += this.Money / 2;
            this.Experience += this.Experience / 4;
        }
    }
}