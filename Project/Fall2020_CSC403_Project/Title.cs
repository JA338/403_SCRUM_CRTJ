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
        private void FrmLevel_Load(object sender, EventArgs e)
        {
        }
        // closes the title winform when button is clicked
        // opens FrmLevel winform upon closing
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmLevel = new FrmLevel();
            frmLevel.Closed += (s, args) => this.Close();
            frmLevel.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
