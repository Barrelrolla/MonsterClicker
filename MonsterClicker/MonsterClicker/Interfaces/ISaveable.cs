namespace MonsterClicker.Interfaces
{
    public interface ISaveable
    {
        string SaveState();

        void LoadState(string text);
    }
}
