namespace MonsterClicker
{
    using System.Numerics;

    public class Weapon
    {
        private BigInteger damagePerClick;
        private BigInteger cost;

        public Weapon(BigInteger damage, BigInteger cost)
        {
            this.damagePerClick = damage;
            this.cost = cost;
        }

        public BigInteger Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

        public BigInteger Damage
        {
            get { return this.damagePerClick; }
            set { this.damagePerClick = value; }
        }

        public BigInteger CostIncrease()
        {
            var costToAdd = this.cost / 10;
            costToAdd = costToAdd < 1 ? 1 : costToAdd;
            return this.cost + costToAdd;
        }
    }
}
