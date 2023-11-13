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

namespace Fall2020_CSC403_Project
{
    public partial class FrmInv : Form
    {

        public static FrmInv instance = null;
        public FrmInv()
        {
            InitializeComponent();
            
        }
        // will be used to display items names in game
        private void InvSlot1_MouseHover(object sender, EventArgs e)
        {
        }

        private void FrmInv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.I:
                    this.Hide();
                    break;

                default:
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveGame.Save(Game.player);
        }
    }
}
