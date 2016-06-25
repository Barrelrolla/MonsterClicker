using System.Collections.Generic;
using System.Linq;

namespace MonsterClicker
{
    using System;
    using System.Numerics;
    using Interfaces;
    public abstract class Creature : ICreature
    {
        private BigInteger health;
        private static readonly BigInteger startHealth = 10;
        private BigInteger nextLevelHealth = startHealth;
        //private Random randomGenerator;
        //private int currentNumber = 0;
        private MonsterInventory inventory;
        private BigInteger killCount;
        private string name;
        private MonsterNames monsterNames;

        protected Creature()
        {
            this.Health = startHealth;
            //this.randomGenerator = new System.Random();
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

        public void TakeDamage(BigInteger damage)
        {
            //TODO: Move the health == 0  check from Form.cs to this method
            this.Health -= damage;
        }

        public abstract void GenerateInventory();

        public abstract void GenerateHealth();

        //public static int GetRandomNumber(int inputNumber)
        //{
        //    var number = randomGenerator.Next(0, inputNumber);
        //    if (number == this.currentNumber)
        //    {
        //        while (number == this.currentNumber)
        //        {
        //            number = randomGenerator.Next(0, 5);
        //        }
        //    }
        //    else
        //    {
        //        this.currentNumber = number;
        //    }
        //    return number;
        //}

        public static string GetRandomName()
        {
            //Convert enum to List
            var listOfNames = Enum.GetValues(typeof(MonsterNames))
                .Cast<MonsterNames>()
                .Select(v => v.ToString())
                .ToList();
            var index = Random.Next(listOfNames.Count);
            return listOfNames[index];
        }
    }
}