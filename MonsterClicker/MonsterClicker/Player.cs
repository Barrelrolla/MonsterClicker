namespace MonsterClicker
{
    using System.Numerics;
    using Weapons;

    public class Player
    {
        private BigInteger damagePerClick;
        private BigInteger baseClickDamge;
        private BigInteger damagePerSecond;
        private BigInteger level;
        private Weapon weapon;
        private PlayerInventory inventory;
        private BigInteger InitialExperience = 10;

        public Player()
        {
            this.baseClickDamge = 1;
            this.weapon = new PlayerWeapon();
            this.damagePerClick = this.baseClickDamge + this.WeaponDamage;
            this.level = 1;
            this.inventory = new PlayerInventory(0, 10);
        }

        public BigInteger DamagePerClick
        {
            get { return this.damagePerClick; }
        }

        public BigInteger DamagePerSecond
        {
            get { return this.damagePerSecond; }
            set { this.damagePerSecond = value; }
        }

        public BigInteger Level
        {
            get { return this.level; }
        }

        public BigInteger ExperiencePointsNeeded
        {
            get { return this.inventory.Experience; }
            set { this.inventory.Experience = value; }
        }

        public BigInteger Money
        {
            get { return this.inventory.Money; }
            set { this.inventory.Money = value; }
        }

        public BigInteger WeaponDamage
        {
            get { return this.weapon.Damage; }
            set { this.weapon.Damage = value; }
        }

        public BigInteger DealDamage()
        {
            return this.damagePerClick;
        }

        public Weapon BuyWeapon(Weapon weaponInStore)
        {
            this.Money -= weaponInStore.Cost;
            this.WeaponDamage += weaponInStore.Damage;
            var newWeapon = new WoodenSword(weapon.DamageIncrease(weaponInStore.Damage), weaponInStore.CostIncrease());
            this.damagePerClick = this.baseClickDamge + this.WeaponDamage;
            return newWeapon;
        }

        public void LevelUp()
        {
            this.level++;
            var damageToAdd = this.baseClickDamge / 20;
            damageToAdd = damageToAdd < 1 ? 1 : damageToAdd;
            this.baseClickDamge += damageToAdd;
            this.damagePerClick = this.baseClickDamge + this.WeaponDamage;
            var experienceToAdd = InitialExperience + InitialExperience / 10 < 1 ? 1 : InitialExperience / 10;
            this.ExperiencePointsNeeded = InitialExperience + experienceToAdd;
            this.InitialExperience = this.inventory.Experience;
        }

        public void GetMoneyAndXP(BigInteger monsterMoney, BigInteger monsterXP)
        {
            this.Money += monsterMoney;
            this.ExperiencePointsNeeded -= monsterXP;
            if (ExperiencePointsNeeded <= 0)
            {
                this.LevelUp();
            }
        }
    }
}
