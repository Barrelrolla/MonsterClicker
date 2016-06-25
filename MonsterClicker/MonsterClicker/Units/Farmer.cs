namespace MonsterClicker.Units
{
    class Farmer : Unit
    {
        public Farmer() : base()
        {
            this.damage = 5;
            this.price = 1;
            this.count = 0;
        }

        public override void PriceIncrease()
        {
            var priceToAdd = this.price / 10 < 2 ? 2 : this.price / 10;
            priceToAdd = priceToAdd < 1 ? 1 : priceToAdd;
            this.price += priceToAdd; ;
        }
    }
}
