namespace MonsterClicker.Interfaces
{
    using System.Numerics;

    public interface IUnit
    {
        BigInteger Price { get; }

        BigInteger Damage { get; }

        BigInteger Count { get; }
    }
}
