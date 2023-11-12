using Fall2020_CSC403_Project.code;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Fall2020_CSC403_Project.code
{
    public class SaveGame
    {
        public Player player { get; set; }
        //public SaveGame() { }
        public static void Save(Player player)
        {
            string docPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            using (StreamWriter saveFile = new StreamWriter(Path.Combine(docPath, "SaveFile.txt")))
            {
                saveFile.WriteLine(player.Health);
                saveFile.WriteLine(player.Position.x);
                saveFile.WriteLine(player.Position.y);
            }
        }

        public static void Load(Player player)
        {
            using (var sr = new StreamReader("SaveFile.txt"))
            {
                // Read the stream as a string, and write the string to the console.
                player.Health = Int32.Parse(sr.ReadLine());
                player.Position = new Vector2(Int32.Parse(sr.ReadLine()), Int32.Parse(sr.ReadLine()));
            }
        }
    
    }
}
