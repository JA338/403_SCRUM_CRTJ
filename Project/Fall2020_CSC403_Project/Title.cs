using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        // Hide the title screen and new game button
        // Enable the level select buttons
        private void button1_Click(object sender, EventArgs e)
        {
            TitleImage.Hide();
            button1.Hide();
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
    }
}
