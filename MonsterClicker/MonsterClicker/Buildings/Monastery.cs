namespace MonsterClicker.Buildings
{
    using System;
    using System.Linq;
    using System.Text;
    using Units;

    public class Monastery : Building
    {
        private const int InitialPrice = 100;

        public Monastery()
        {
            this.Price = InitialPrice;
            this.HeldUnit = new Monk();
            this.PurchasedState = false;
        }

        public override void LoadState(string text)
        {
            var save = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var line = save[28].Split(' ').ToArray();
            this.PurchasedState = Convert.ToBoolean(line[1]);
        }

        public override string SaveState()
        {
            var save = new StringBuilder();
            save.AppendLine($"MonasteryBuilt: {this.PurchasedState.ToString()}");
            return save.ToString();
        }
    }
}
