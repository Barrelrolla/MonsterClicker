namespace MonsterClicker.Interfaces
{
    using System.Numerics;

    public interface IMonster
    {
        BigInteger Health { get; set; }

        void TakeDamage(BigInteger damage);

        void GenerateHealth();
    }
}