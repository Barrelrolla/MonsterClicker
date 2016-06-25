namespace MonsterClicker
{
    // TODO: IUnit, Abstract Unit, separate class for each unit type
    using System.Numerics;
    using MonsterClicker.Interfaces;

    abstract class Unit : IUnit
    {
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
