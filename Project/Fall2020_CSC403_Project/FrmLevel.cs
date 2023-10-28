﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;

        // initialize variables for animation
        private int imgNum;
        private bool dFlag = false;
    public FrmLevel() {
      InitializeComponent();
    }

        private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
        bossKoolaid = new Enemy.HighEnemySubclass(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
        enemyPoisonPacket = new Enemy.MedEnemySubclass(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
        enemyCheeto = new Enemy.LowEnemySubclass(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

            // sets player image at loadtime
            picPlayer.Image = Properties.Resources.player;

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
        }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
            //shows that input has stopped for a particular direction
            dFlag = false;
            //stops animation timers
            timer1.Stop();
            timer2.Stop();
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
        // check for player death event
        CheckForDeath();
        // move player
        player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
      }
      if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

      
     }
    
    private void PlayDeathSound()
    {
        SoundPlayer deathAudio = new SoundPlayer(Resources.deathsound);
        deathAudio.Play();
    }

    private bool CheckForDeath() {

    if (player.Health <= 0 && deathscreen.Visible == false)
    {
        deathscreen.Visible = true;
        PlayDeathSound();            
        return true;
    }
    else { return false; }
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
            //stops animation when entering a fight
            timer1.Stop();
            timer2.Stop();
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();

      if (enemy == bossKoolaid) {
        frmBattle.SetupForBossBattle();
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
        //deletes original background image and sets player image
        picPlayer.BackgroundImage = null;
        picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
      //check if the player is dead
      if (CheckForDeath()){ return; }
      //check if the key has been pressed
      if(dFlag == true) { return; }
            dFlag = true;
            // starts timers based on the direction pressed
      switch (e.KeyCode) {
        case Keys.Left:
                    imgNum = 0;
                    timer2.Start();
          player.GoLeft();
          break;

        case Keys.Right:
                    imgNum = 0;
                    timer1.Start();
          player.GoRight();
          break;

        case Keys.Up:
                    imgNum = 0;
                    timer1.Start();
                    player.GoUp();
          break;

        case Keys.Down:
                    imgNum = 0;
                    timer2.Start();
                    player.GoDown();
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }
        // timers for animation start
        private void timer1_Tick(object sender, EventArgs e)
        {
            picPlayer.Image.Dispose();
            picPlayer.Image = imageList1.Images[imgNum];
            if (imgNum == imageList1.Images.Count - 1)
            {
                imgNum = 0;
            }
            else
            {
                imgNum++;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            picPlayer.Image.Dispose();
            picPlayer.Image = imageList2.Images[imgNum];
            if (imgNum == imageList2.Images.Count - 1)
            {
                imgNum = 0;
            }
            else
            {
                imgNum++;
            }
        }
    }
}
