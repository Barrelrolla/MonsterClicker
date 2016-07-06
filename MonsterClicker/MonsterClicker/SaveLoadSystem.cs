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
            var save = new StringBuilder();
            if (File.Exists(filename))
            {
                var reader = new StreamReader(filename);
                var line = reader.ReadLine();
                using (reader)
                {
                    while (line != null)
                    {
                        save.AppendLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                File.Create(filename).Dispose();
            }

            return save.ToString();
        }
    }
}
