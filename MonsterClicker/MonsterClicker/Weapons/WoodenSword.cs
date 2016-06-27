namespace MonsterClicker.Weapons
{
    using System.Numerics;

    public class WoodenSword : Weapon
    {
        public WoodenSword(BigInteger damage, BigInteger cost)
        {
            this.Damage = damage;
            this.Cost = cost;
        }

        public override BigInteger CostIncrease()
        {
            var costToAdd = this.Cost / 10;
            costToAdd = costToAdd < 2 ? 2 : costToAdd;
            return this.Cost + costToAdd;
        }

        public override BigInteger DamageIncrease()
        {
            var damageToAdd = this.Damage / 10;
            damageToAdd = damageToAdd < 2 ? 2 : damageToAdd;
            return this.Damage + damageToAdd;
        }
    }
}
