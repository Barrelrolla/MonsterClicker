namespace MonsterClicker.Interfaces
{
    using System.Numerics;

    public interface IWeapon
    {
        BigInteger Cost { get; set; }

        BigInteger Damage { get; set; }

        BigInteger CostIncrease();

        BigInteger DamageIncrease(BigInteger currentDamage);
    }
}
