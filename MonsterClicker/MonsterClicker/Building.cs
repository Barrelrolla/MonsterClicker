namespace MonsterClicker
{
    using Interfaces;
    using System.Numerics;
    using System;

    public abstract class Building : IBuilding
    {
        private BigInteger price;
        private Unit heldUnit;
        private bool purchasedState;

        public BigInteger Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Unit HeldUnit
        {
            get { return this.heldUnit; }
            set { this.heldUnit = value; }
        }

        public bool PurchasedState
        {
            get { return this.purchasedState; }
            set { this.purchasedState = value; }
        }
    }
}
