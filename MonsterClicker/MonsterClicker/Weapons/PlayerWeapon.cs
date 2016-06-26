namespace MonsterClicker.Weapons
{
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
            var costToAdd = this.cost / 10 < 2 ? 2 : this.cost / 10;
            costToAdd = costToAdd < 1 ? 1 : costToAdd;
            return this.cost + costToAdd;
        }

        public override BigInteger DamageIncrease(BigInteger currentDamage)
        {
            var damageToAdd = currentDamage / 10;
            damageToAdd = damageToAdd < 1 ? 1 : damageToAdd;
            return currentDamage + damageToAdd;
        }
    }
}
