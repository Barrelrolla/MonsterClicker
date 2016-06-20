namespace MonsterClicker
{
    using System.Numerics;

    public class Player
    {
        // TODO: Placeholder text, remove after getting a monster
        public BigInteger initialMonsterHealth = 10;
        public BigInteger monsterHealth = 10;

        private BigInteger damagePerClick;
        private BigInteger baseClickDamge;
        private BigInteger damagePerSecond;
        private BigInteger experiencePoints;
        private BigInteger level;
        private Weapon weapon;
        private BigInteger money;

        public Player()
        {
            this.baseClickDamge = 1;
            this.weapon = new Weapon(0, 0);
            this.damagePerClick = this.baseClickDamge + this.WeaponDamage;
            this.money = 0;
            this.level = 1;
        }

        public BigInteger DamagePerClick
        {
            get { return this.damagePerClick; }
        }

        public BigInteger DamagePerSecond
        {
            get { return this.damagePerSecond; }
        }

        public BigInteger Level
        {
            get { return this.level; }
        }

        public BigInteger ExperiencePoints
        {
            get { return this.experiencePoints; }
            set { this.experiencePoints = value; }
        }

        public BigInteger Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public BigInteger WeaponDamage
        {
            get { return this.weapon.Damage; }
        }

        public void DealDamage()
        {
            // TODO: Placehodler text, fix to deal damage to monster after getting one
            this.monsterHealth -= this.damagePerClick;
        }

        public Weapon BuyWeapon(Weapon weaponInStore)
        {
            this.money = this.money - weaponInStore.Cost;
            this.weapon = new Weapon(weaponInStore.Damage, weaponInStore.Cost);
            var damageToAdd = this.WeaponDamage / 10;
            damageToAdd = damageToAdd < 1 ? 1 : damageToAdd;
            var newWeapon = this.WeaponDamage + damageToAdd;
            this.damagePerClick = this.baseClickDamge + weaponInStore.Damage;
            return new Weapon(newWeapon, this.weapon.CostIncrease());
        }

        public void LevelUp()
        {
            this.level++;
            var damageToAdd = this.baseClickDamge / 10;
            damageToAdd = damageToAdd < 1 ? 1 : damageToAdd;
            this.baseClickDamge += damageToAdd;
            this.damagePerClick = this.baseClickDamge + this.WeaponDamage;
            this.experiencePoints = 0;
        }
    }
}
