using System;
using Fall2020_CSC403_Project.code;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fall2020_CSC403_Project
{
    public partial class Title : Form
    {
        
        public Title()
        {
            InitializeComponent();
        }
        //Hide the level select buttons on load
        private void Title_Load(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Hide();
            button4.Hide();
        }
        // closes the title winform when button is clicked
        // opens FrmLevel winform upon closing
        private void newGameButton_Click(object sender, EventArgs e)
        {
            TitleImage.Hide();
            newGameButton.Hide();
            loadButton.Hide();
            button2.Show();
            button3.Show();
            button4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            var frmLevel = new FrmLevelForest();
            
            frmLevel.Closed += (s, args) => this.Close();
            frmLevel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmLevel = new FrmLevelGatefront();
            
            frmLevel.Closed += (s, args) => this.Close();
            frmLevel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmLevel = new FrmLevelCastle();
            frmLevel.Closed += (s, args) => this.Close();
            frmLevel.Show();
        }

        private void loadButton_Click_1(object sender, EventArgs e)
        {
            using (var sr = new StreamReader("SaveFile.txt"))
            {
                string levelID = sr.ReadLine();
                Console.WriteLine(levelID);
                if(levelID == "Level 1")
                {
                    this.Hide();
                    //var frmLevel = new FrmLevelGatefront();
                    var frmLevel = new FrmLevelForest();
                    //var frmLevel = new FrmLevelCastle();
                    frmLevel.Closed += (s, args) => this.Close();
                    frmLevel.Show();
                }

                if(levelID == "Level 2")
                {
                    this.Hide();
                    var frmLevel = new FrmLevelGatefront();
                    //var frmLevel = new FrmLevelForest();
                    //var frmLevel = new FrmLevelCastle();
                    frmLevel.Closed += (s, args) => this.Close();
                    frmLevel.Show();
                }

                if(levelID == "Level 3")
                {
                    this.Hide();
                    //var frmLevel = new FrmLevelGatefront();
                    //var frmLevel = new FrmLevelForest();
                    var frmLevel = new FrmLevelCastle();
                    frmLevel.Closed += (s, args) => this.Close();
                    frmLevel.Show();
                }
                //sr.ReadLine();
                Game.player.Health = Int32.Parse(sr.ReadLine());
                Game.player.Position = new Vector2(Int32.Parse(sr.ReadLine()), Int32.Parse(sr.ReadLine()));
                Game.scoreData = Int32.Parse(sr.ReadLine());
            }
        }
    }
}
