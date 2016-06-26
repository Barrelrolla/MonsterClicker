namespace MonsterClicker
{
    using System.Numerics;
    using Interfaces;

    public abstract class Unit : IUnit
    {
        protected BigInteger price;
        protected BigInteger damage;
        protected BigInteger count;

        public Unit()
        {
        }

        public BigInteger Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }

        public BigInteger Damage
        {
            get { return this.damage * this.count; }
        }

        public BigInteger Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        public abstract void PriceIncrease();

        public void IncreaseCount()
        {
            this.Count++;
        }
    }
}
