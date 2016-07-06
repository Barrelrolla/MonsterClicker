namespace MonsterClicker.Units
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Ninja : Unit
    {
        public Ninja() : base()
        {
            this.damage = 200;
            this.price = 100;
            this.count = 0;
        }
        
        public override void PriceIncrease()
        {
            var priceToAdd = this.price / 10 < 2 ? 2 : this.price / 10;
            priceToAdd = priceToAdd < 1 ? 1 : priceToAdd;
            this.price += priceToAdd;
        }

        public override string SaveState()
        {
            var save = new StringBuilder();
            save.AppendLine($"NinjasCount: {this.count}");
            save.AppendLine($"NinjasPrice: {this.price}");
            return save.ToString();
        }

        public override void LoadState(string text)
        {
            var save = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var line = save[25].Split(' ').ToArray();
            this.count = BigInteger.Parse(line[1]);
            line = save[26].Split(' ').ToArray();
            this.price = BigInteger.Parse(line[1]);
        }
    }
}
