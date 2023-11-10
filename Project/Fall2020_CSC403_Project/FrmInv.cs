using Fall2020_CSC403_Project.code;
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
    public partial class FrmInv : Form
    {
        private Weapon weapon;
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

        public void AddSamehada()
        {
            Invslot1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.samehada;
        }
        public void RemoveSamehada()
        {

        }

        private void Invslot1_Click(object sender, EventArgs e)
        {
            Discard.Visible = true;
            Equip.Visible = true;
            Close.Visible = true;
            Description.Visible = true;
            DisplayWep.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.samehada;
            DisplayWep.Visible = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EquipClick(object sender, EventArgs e)
        {

        }

        private void DiscClick(object sender, EventArgs e)
        {
            Invslot1.BackgroundImage = null;
        }

        private void Description_Click(object sender, EventArgs e)
        {
            SamehadaText.Visible = true;
        }

    }
}
