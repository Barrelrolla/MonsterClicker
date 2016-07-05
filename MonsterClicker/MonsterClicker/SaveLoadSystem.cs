namespace MonsterClicker
{
    using System;
    using System.IO;
    using System.Text;

    public static class SaveLoadSystem
    {
        public static void SaveGame(string toSave)
        {
            string filename = @"..\..\save.txt";
            var writer = new StreamWriter(filename);
            using (writer)
            {
                writer.WriteLine(toSave);
            }
        }

        public static string LoadGame()
        {
            string filename = @"..\..\save.txt";
            var reader = new StreamReader(filename);
            var line = reader.ReadLine();
            var save = new StringBuilder();
            using (reader)
            {
                while (line != null)
                {
                    save.AppendLine(line);
                    line = reader.ReadLine();
                }
            }

            return save.ToString();
        }
    }
}
