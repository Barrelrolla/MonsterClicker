using System;
using System.Collections.Generic;

namespace MonsterClicker
{
    using Interfaces;
    using System.Numerics;
    public class Monster : IMonster
    {
        private BigInteger health;
        private static BigInteger startHealth = 10;
        private BigInteger nextLevelHealth = startHealth;
        private List<string> photosPaths;
        private Random randomGenerator;

        public Monster()
        {
            this.Health = startHealth;
            this.photosPaths = new List<string>();
            this.randomGenerator = new Random();
        }

        public BigInteger Health
        {
            get { return this.health; }
            set { this.health = value; }
        }


        public void TakeDamage(BigInteger damage)
        {
            this.Health -= damage;            
        }

        public void GenerateHealth()
        {
            nextLevelHealth += (nextLevelHealth / 10);
            this.health = nextLevelHealth;
        }

        public string GetPhotoPath()
        {
            photosPaths.Add("monster1");
            photosPaths.Add("monster2");
            photosPaths.Add("monster3");
            photosPaths.Add("monster4");
            photosPaths.Add("monster5");
            var number = randomGenerator.Next(0, 5);
            return photosPaths[number];
        }

        
    }
}