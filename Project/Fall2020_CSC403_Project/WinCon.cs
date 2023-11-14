using System;
using System.Media;
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
    public partial class WinCon : Form
    {
        public WinCon()
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.epicwin);
            simpleSound.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
