namespace MonsterClicker
{
    using System.Numerics;
    using Interfaces;

    public abstract class Unit : IUnit, ISaveable
    {
        private BigInteger price;
        private BigInteger damage;
        private BigInteger count;

        public Unit()
        {
        }        

        public BigInteger Price
        {
            get { return this.price; }
            protected set { this.price = value; }
        }

        public BigInteger Damage
        {
            get { return this.damage * this.count; }
            protected set { this.damage = value; }
        }

        public BigInteger Count
        {
            get { return this.count; }
            protected set { this.count = value; }
        }

        public BigInteger DealDamage(BigInteger playerDamage)
        {
            var multiplier = playerDamage / 10 < 1 ? 1 : playerDamage / 10;
            return this.Damage * multiplier;
        }

        public BigInteger ShowDamage(BigInteger playerDamage)
        {
            var multiplier = playerDamage / 10 < 1 ? 1 : playerDamage / 10;
            return this.damage * multiplier;
        }

        public abstract void PriceIncrease();

        public void IncreaseCount()
        {
            this.Count++;
        }

        public abstract string SaveState();

        public abstract void LoadState(string text);
    }
}
