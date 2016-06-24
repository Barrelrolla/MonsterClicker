using System;
using System.Collections.Generic;

namespace MonsterClicker
{
    using Interfaces;
    using System.Numerics;
    using System.Windows.Forms;
    public class Monster : Creature
    {
        private static readonly BigInteger  startHealth = 10;
        private BigInteger nextLevelHealth = startHealth;
        private BigInteger killCount = 1;

        //TODO: exp and money - every next monster must have more money and exp
        //TODO: enum with names of monster and show it
        

        public override void GenerateHealth()
        {
            nextLevelHealth += (nextLevelHealth / 4);
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