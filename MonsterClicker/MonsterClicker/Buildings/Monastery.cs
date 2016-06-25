namespace MonsterClicker.Buildings
{
    using Units;

    public class Monastery : Building
    {
        public Monastery()
        {
            this.Price = 100;
            this.HeldUnit = new Monk();
            this.PurchasedState = false;
        }
    }
}
