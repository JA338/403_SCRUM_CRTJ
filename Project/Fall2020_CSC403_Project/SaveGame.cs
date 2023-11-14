using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project;
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
                //Console.WriteLine(docPath);
                saveFile.WriteLine(Game.samehada);
                saveFile.WriteLine(Game.levelData);
                saveFile.WriteLine(player.Health);
                saveFile.WriteLine(player.Position.x);
                saveFile.WriteLine(player.Position.y);
                saveFile.WriteLine(Game.scoreData);
                
                
            }
        }

    }
}