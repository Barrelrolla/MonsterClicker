namespace MonsterClicker.Units
{
    class Ninja : Unit
    {
        public Ninja() : base()
        {
            this.damage = 700;
            this.price = 100;
            this.count = 0;
        }

        public override void PriceIncrease()
        {
            var priceToAdd = this.price / 10 < 2 ? 2 : this.price / 10;
            priceToAdd = priceToAdd < 1 ? 1 : priceToAdd;
            this.price += priceToAdd;
        }
    }
}
