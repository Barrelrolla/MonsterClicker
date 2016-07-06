namespace MonsterClicker.Buildings
{
    using System;
    using System.Linq;
    using System.Text;
    using Units;

    public class Dojo : Building
    {
        public Dojo()
        {
            this.Price = 1000;
            this.HeldUnit = new Ninja();
            this.PurchasedState = false;
        }

        public override void LoadState(string text)
        {
            var save = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var line = save[29].Split(' ').ToArray();
            this.PurchasedState = Convert.ToBoolean(line[1]);
        }

        public override string SaveState()
        {
            var save = new StringBuilder();
            save.AppendLine($"DojoBuilt: {this.PurchasedState.ToString()}");
            return save.ToString();
        }
    }
}
