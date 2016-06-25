namespace MonsterClicker.Interfaces
{
    using System.Numerics;

    public interface IBuilding
    {
        BigInteger Price { get; set; }

        Unit HeldUnit { get; set; }

        bool PurchasedState { get; set; }
    }
}
