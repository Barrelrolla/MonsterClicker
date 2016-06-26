namespace MonsterClicker
{
    using System.Numerics;
    using MonsterClicker.Interfaces;

    public abstract class Weapon : IWeapon
    {
        protected BigInteger damagePerClick;
        protected BigInteger cost;

        public Weapon()
        {
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

        public abstract BigInteger CostIncrease();

        public abstract BigInteger DamageIncrease(BigInteger currentDamage);
    }
}
