namespace MonsterClicker.Weapons
{
    using System;
    using System.Numerics;

    public class PlayerWeapon : Weapon
    {
        public PlayerWeapon()
        {
            this.Damage = 0;
            this.Cost = 0;
        }

        public override BigInteger CostIncrease()
        {
            throw new InvalidOperationException("Player's starting weapon should not be increased!");
        }

        public override BigInteger DamageIncrease()
        {
            throw new InvalidOperationException("Player's starting weapon should not be increased!");
        }
    }
}
