namespace MonsterClicker
{
    using System.Numerics;

    public class Weapon
    {
        //TODO: IWeapon, Abstract class Weapon, classes sword, axe... and whatever
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
            var costToAdd = this.cost / 10 < 2 ? 2 : this.cost / 10;
            costToAdd = costToAdd < 1 ? 1 : costToAdd;
            return this.cost + costToAdd;
        }

        public BigInteger DamageIncrease(BigInteger currentDamage)
        {
            var damageToAdd = currentDamage / 10;
            damageToAdd = damageToAdd < 1 ? 1 : damageToAdd;
            return currentDamage + damageToAdd;
        }
    }
}
