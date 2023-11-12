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
using System.Windows.Forms.VisualStyles;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInv : Form
    {
        private Weapon weapon;
        public static FrmInv instance = null;
        private bool showButtons = false;
        private string[] slots = ["one", "two", "three", "four", "five", "six", "seven", "eight"];
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
            PictureBox openslot = checkSpots(slots);
            openslot.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.samehada;
        }
        public void RemoveSamehada()
        {

        }

        private void Invslot1_Click(object sender, EventArgs e)
        {

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
            one.BackgroundImage = null;
            showButtons = false;
            DisplayWep = null;
            DisplayButtons();

        }


        private void one_Click(object sender, EventArgs e)
        {
            DisplayWep.Visible = true;
            showButtons = true;
            DisplayButtons();
            DisplayWep.BackgroundImage = one.BackgroundImage;
        }

        private void DisplayButtons()
        {
            if (showButtons == true) {
                Equip.Visible = true;
                Discard.Visible = true;
                Close.Visible = true;
            }
            if (showButtons == false)
            {
                Equip.Visible = false;
                Discard.Visible = false;
                Close.Visible = false;
            }
        }

        private PictureBox checkSpots(string[] slots) {
            foreach (string slot in slots)
            {
                PictureBox currslot = ConvertToPictureBox(slot);
                if (currslot.BackgroundImage == null)
                {
                    return (currslot);
                }
                
            }
            return null;

        }
        private PictureBox ConvertToPictureBox(string name)
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Name == name)
                {
                    return pictureBox;
                }
            }

            // PictureBox with the specified name was not found
            return null;
        }
    }
}

