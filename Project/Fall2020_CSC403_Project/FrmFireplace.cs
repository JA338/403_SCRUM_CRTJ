using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Security.Cryptography;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project{
    public partial class FrmFireplace : Form{
        public static FrmBattle instance = null;
        private Player player;
        public FrmFireplace(){
            InitializeComponent();
            player = Game.player;
        }

        private void FrmFireplace_Load(object sender, EventArgs e){

        }

        private void BtnRest_Click(object sender, EventArgs e){
            player.AlterHealth(99);
            player.AlterStamina(99);
            player.AlterMana(99);
            this.Hide();
        }
    }
}
