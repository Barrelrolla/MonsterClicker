﻿namespace MonsterClicker.Units
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Ninja : Unit
    {
        public Ninja() : base()
        {
            this.Damage = 200;
            this.Price = 100;
            this.Count = 0;
        }
        
        public override void PriceIncrease()
        {
            var priceToAdd = this.Price / 10 < 2 ? 2 : this.Price / 10;
            priceToAdd = priceToAdd < 1 ? 1 : priceToAdd;
            this.Price += priceToAdd;
        }

        public override string SaveState()
        {
            var save = new StringBuilder();
            save.AppendLine($"NinjasCount: {this.Count}");
            save.AppendLine($"NinjasPrice: {this.Price}");
            return save.ToString();
        }

        public override void LoadState(string text)
        {
            var save = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var line = save[25].Split(' ').ToArray();
            this.Count = BigInteger.Parse(line[1]);
            line = save[26].Split(' ').ToArray();
            this.Price = BigInteger.Parse(line[1]);
        }
    }
}
