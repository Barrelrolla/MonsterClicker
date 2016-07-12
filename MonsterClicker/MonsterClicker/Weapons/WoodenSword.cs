namespace MonsterClicker.Weapons
{
    using System.Numerics;

    public class WoodenSword : Weapon
    {
        private const int DamageModifier = 15;
        private const int CostModifier = 10;

        public WoodenSword(BigInteger damage, BigInteger cost)
        {
            this.Damage = damage;
            this.Cost = cost;
        }

        public override BigInteger CostIncrease()
        {
            var costToAdd = this.Cost / CostModifier;
            costToAdd = costToAdd < 2 ? 2 : costToAdd;
            return this.Cost + costToAdd;
        }

        public override BigInteger DamageIncrease()
        {
            var damageToAdd = this.Damage / DamageModifier;
            damageToAdd = damageToAdd < 2 ? 2 : damageToAdd;
            return this.Damage + damageToAdd;
        }
    }
}
