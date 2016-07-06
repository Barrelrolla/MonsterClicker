namespace MonsterClicker.Buildings
{
    using System;
    using System.Linq;
    using System.Text;
    using Units;

    public class Farm : Building
    {
        public Farm()
        {
            this.Price = 10;
            this.HeldUnit = new Farmer();
            this.PurchasedState = false;
        }

        public override void LoadState(string text)
        {
            var save = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var line = save[27].Split(' ').ToArray();
            this.PurchasedState = Convert.ToBoolean(line[1]);
        }

        public override string SaveState()
        {
            var save = new StringBuilder();
            save.AppendLine($"FarmBuilt: {this.PurchasedState.ToString()}");
            return save.ToString();
        }
    }
}
