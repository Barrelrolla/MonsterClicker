namespace MonsterClicker
{
    using System;
    using System.Linq;
    using System.Numerics;
    using Interfaces;

    public abstract class Creature : ICreature
    {
        private static readonly BigInteger StartHealth = 10;
        private BigInteger health;
        private BigInteger nextLevelHealth = StartHealth;
        private MonsterInventory inventory;
        private BigInteger killCount;
        private string name;
        private MonsterNames monsterNames;

        protected Creature()
        {
            this.Health = StartHealth;
            this.inventory = new MonsterInventory(1, 5);
        }

        public BigInteger Experience
        {
            get { return this.inventory.Experience; }
            set { this.inventory.Experience = value; }
        }

        public BigInteger Money
        {
            get { return this.inventory.Money; }
            set { this.inventory.Money = value; }
        }

        public BigInteger Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public static string GetRandomName()
        {
            ////Convert enum to List
            var listOfNames = Enum.GetValues(typeof(MonsterNames))
                .Cast<MonsterNames>()
                .Select(v => v.ToString())
                .ToList();
            var index = Random.Next(listOfNames.Count);
            return listOfNames[index];
        }

        public void TakeDamage(BigInteger damage)
        {
            ////TODO: Move the health == 0  check from Form.cs to this method
            this.Health -= damage;
        }

        public abstract void GenerateInventory();

        public abstract void GenerateHealth();
    }
}