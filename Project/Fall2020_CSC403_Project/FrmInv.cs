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
        public static FrmInv instance = null;
        private bool showButtons = false;
        public string invslot;
        string[] slots = { "one", "two", "three", "four", "five", "six", "seven", "eight" };

        public FrmInv()
        {
            InitializeComponent();
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
            openslot.Visible = true;
            openslot.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.samehada;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EquipClick(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void DiscClick(object sender, EventArgs e)
        {
            PictureBox blankSlot = ConvertToPictureBox(invslot);
            blankSlot.BackgroundImage = null;
            showButtons = false;
            DisplayWep.Visible = false;
            DisplayButtons();

        }


        private void one_Click(object sender, EventArgs e)
        {
            DisplayWep.Visible = true;
            showButtons = true;
            DisplayButtons();
            DisplayWep.BackgroundImage = one.BackgroundImage;
            invslot = "one";
        }
        private void two_Click(object sender, EventArgs e)
        {
            DisplayWep.Visible = true;
            showButtons = true;
            DisplayButtons();
            DisplayWep.BackgroundImage = two.BackgroundImage;
            invslot = "two";
        }
        private void three_Click(object sender, EventArgs e)
        {
            DisplayWep.Visible = true;
            showButtons = true;
            DisplayButtons();
            DisplayWep.BackgroundImage = three.BackgroundImage;
            invslot = "three";

        }

        private void four_Click(object sender, EventArgs e)
        {
            DisplayWep.Visible = true;
            showButtons = true;
            DisplayButtons();
            DisplayWep.BackgroundImage = four.BackgroundImage;
            invslot = "four";
        }

        private void five_Click(object sender, EventArgs e)
        {
            DisplayWep.Visible = true;
            showButtons = true;
            DisplayButtons();
            DisplayWep.BackgroundImage = five.BackgroundImage;
            invslot = "five";
        }

        private void six_Click(object sender, EventArgs e)
        {
            DisplayWep.Visible = true;
            showButtons = true;
            DisplayButtons();
            DisplayWep.BackgroundImage = six.BackgroundImage;
            invslot = "six";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            DisplayWep.Visible = true;
            showButtons = true;
            DisplayButtons();
            DisplayWep.BackgroundImage = seven.BackgroundImage;
            invslot = "seven";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            DisplayWep.Visible = true;
            showButtons = true;
            DisplayButtons();
            DisplayWep.BackgroundImage = eight.BackgroundImage;
            invslot = "eight";
        }

        private void DisplayButtons()
        {
            if (showButtons == true)
            {
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

        private PictureBox checkSpots(string[] slots)
        {
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

            return null;
        }


    }
}

