namespace MonsterClicker.Interfaces
{
    using System.Numerics;

    public interface ICreature
    {
        BigInteger Experience { get; set; }

        BigInteger Money { get; set; }

        BigInteger Health { get; set; }

        string Name { get; set; }

        void TakeDamage(BigInteger damage);

        void GenerateInventory();
    }
}