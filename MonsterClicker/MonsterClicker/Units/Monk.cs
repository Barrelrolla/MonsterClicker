namespace MonsterClicker.Units
{
    public class Monk : Unit
    {
        public Monk() : base()
        {
            this.damage = 120;
            this.price = 20;
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
