namespace MonsterClicker.Buildings
{
    using Units;

    public class Dojo : Building
    {
        public Dojo()
        {
            this.Price = 1000;
            this.HeldUnit = new Ninja();
            this.PurchasedState = false;
        }
    }
}
