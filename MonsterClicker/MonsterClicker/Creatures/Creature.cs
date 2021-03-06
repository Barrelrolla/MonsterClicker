﻿namespace MonsterClicker.Creatures
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using Interfaces;

    public abstract class Creature : ICreature, ISaveable
    {
        private static readonly BigInteger StartHealth = 10;
        private BigInteger nextLevelHealth = StartHealth;
        private BigInteger killCount;
        private BigInteger health;
        private MonsterInventory inventory;
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

        protected BigInteger NextLevelHealth
        {
            get { return this.nextLevelHealth; }
            set { this.nextLevelHealth = value; }
        }

        protected BigInteger KillCount
        {
            get { return this.killCount; }
            set { this.killCount = value; }
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

        public string SaveState()
        {
            var save = new StringBuilder();
            save.AppendLine($"CreatureHP: {this.health}");
            save.AppendLine($"CreatureMoney: {this.inventory.Money}");
            save.AppendLine($"CreatureXP: {this.inventory.Experience}");
            save.AppendLine($"CreatureName: {this.name}");
            save.AppendLine($"CreatureKillCount: {this.killCount}");
            save.AppendLine($"CreatureNextLevelHealth: {this.nextLevelHealth}");
            return save.ToString();
        }

        public abstract void LoadState(string text);

        public abstract void GenerateInventory();

        public abstract void GenerateHealth();
    }
}