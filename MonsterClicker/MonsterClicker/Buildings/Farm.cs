namespace MonsterClicker.Buildings
{
    using Units;

    public class Farm : Building
    {
        public Farm()
        {
            this.Price = 10;
            this.HeldUnit = new Farmer();
            this.PurchasedState = false;
        }
    }
}
