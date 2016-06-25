using System;
using System.Collections.Generic;
using System.Linq;

namespace MonsterClicker
{
    using System.Numerics;

    public class Monster : Creature
    {
        private static readonly BigInteger  startHealth = 10;
        private BigInteger nextLevelHealth = startHealth;
        private BigInteger killCount = 1;
        
        public override void GenerateHealth()
        {
            nextLevelHealth += (nextLevelHealth / 8);
            this.Health = nextLevelHealth;
            this.killCount++;
        }

        public override void GenerateInventory()
        {
            this.Money += this.Money / 10 < 1 ? 1 : this.Money / 10;
            this.Experience += this.Experience / 20 < 1 ? 1 : this.Experience / 20;
        }

        
    }
}