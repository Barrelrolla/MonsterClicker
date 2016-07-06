namespace MonsterClicker
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using MonsterClicker.Interfaces;

    public abstract class Weapon : IWeapon, ISaveable
    {
        protected BigInteger damagePerClick;
        protected BigInteger cost;

        public Weapon()
        {
        }

        public BigInteger Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

        public BigInteger Damage
        {
            get { return this.damagePerClick; }
            set { this.damagePerClick = value; }
        }

        public string SaveState()
        {
            var save = new StringBuilder();
            save.AppendLine($"WeaponInStoreDamage: {this.damagePerClick}");
            save.AppendLine($"WeaponInStoreCost: {this.cost}");
            return save.ToString();
        }

        public void LoadState(string text)
        {
            var save = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var line = save[19].Split(' ').ToArray();
            this.damagePerClick = BigInteger.Parse(line[1]);
            line = save[20].Split(' ').ToArray();
            this.cost = BigInteger.Parse(line[1]);
        }

        public abstract BigInteger CostIncrease();

        public abstract BigInteger DamageIncrease();
    }
}
