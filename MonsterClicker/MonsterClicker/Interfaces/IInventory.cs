namespace MonsterClicker.Interfaces
{
    using System.Numerics;

    public interface IInventory
    {
        BigInteger Money { get; set; }
        BigInteger Experience { get; set; }
    }
}
