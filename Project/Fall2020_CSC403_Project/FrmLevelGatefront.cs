using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
    public partial class FrmLevelGatefront : Form {
    private Player player;

    private FrmInv FrmInv;
    private Character[] walls;
    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private Point offScreen = new Point(-100, -100);
    private Character exitCollider;
    private bool exitCheck = false;
    private Enemy[] enemies;
    const int PADDING = 7;
    private Character lever; 

        // initialize variables for animation
    private int imgNum;
    private bool dFlag = false;


    public FrmLevelGatefront() {
        InitializeComponent();
        player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            //BackgroundImage = picOpenGate.Image;
            Game.levelData = "Level 2";
    }

    public FrmLevelGatefront(Player oldPlayer, FrmInv inventory) {
        InitializeComponent();
        player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING)) { Health = oldPlayer.Health };
        FrmInv = inventory;
        //this.player = player;
        //this.FrmInv = inventory;
    }


    private void FrmLevel_Load(object sender, EventArgs e) {
        const int NUM_WALLS = 13;

        
        GenerateEnemies(0, 2, 0);
        // sets player image at loadtime
        picPlayer.Image = Properties.Resources.player;
        lever = new Character(CreatePosition(picLever), CreateCollider(picLever, PADDING));
        exitCollider = new Character(CreatePosition(picExitColl), CreateCollider(picExitColl, PADDING));

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
            //label2.Text = "Score " + Game.scoreData.ToString();
        }

    //method for generating enemies in the level
    //WARNING: Enemy pictures have to be ordered in series based on their tiers, from low to high, based on this implementation
    private void GenerateEnemies(int numLowEnemies, int numMedEnemies, int numHighEnemies)
    {
        const int PADDING = 7;
        enemies = new Enemy[numLowEnemies + numMedEnemies + numHighEnemies];

        for (int enemy = 0; enemy < enemies.Length; enemy++)
        {
            PictureBox pictureBox = Controls.Find("picEnemy" + (enemy).ToString(), true)[0] as PictureBox;

            if (enemy < numLowEnemies)
            {
                enemies[enemy] = new Enemy.LowEnemySubclass(CreatePosition(pictureBox), CreateCollider(pictureBox, PADDING)) { Img = pictureBox.Image };
            }
            else if (enemy < numLowEnemies + numMedEnemies)
            {
                enemies[enemy] = new Enemy.MedEnemySubclass(CreatePosition(pictureBox), CreateCollider(pictureBox, PADDING)) { Img = pictureBox.Image };
            }
            else
            {
                // Assuming the remaining enemies are HighEnemySubclass
                enemies[enemy] = new Enemy.HighEnemySubclass(CreatePosition(pictureBox), CreateCollider(pictureBox, PADDING)) { Img = pictureBox.Image };
            }
        }
    }
    private void tmrPlayerMove_Tick(object sender, EventArgs e)
    {
        // check for player death event
        CheckForDeath();
        // move player
        player.Move();

        // check collision with walls
        if (HitAWall(player))
        {
            player.MoveBack();
        }

        for (int enemy = 0; enemy < enemies.Length; enemy++)
        {
            if (HitAChar(player, enemies[enemy]) && enemies[enemy].Health > 0)
            {
                Fight(enemies[enemy]);

            }

            if (enemies[enemy].Health <= 0)
            {
                PictureBox pic = Controls.Find("picEnemy" + ((enemy).ToString()), true)[0] as PictureBox;
                pic.Location = offScreen;
            }
            
        }
        if( HitAChar(player, lever))
            {
                exitCheck = true;
                BackgroundImage = picOpenGate.Image;
            }
        if ( HitAChar(player, exitCollider) && exitCheck)
        {
            exitCheck = false;
            this.Hide();
            var frmLevel = new FrmLevelCastle(player, FrmInv);
            frmLevel.Closed += (s, args) => this.Close();
            //this.Dispose();
            frmLevel.Show();
            //this.Close();
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

            case Keys.I:
                // display inventory upon pressing "I"
                FrmInv = new FrmInv();
                FrmInv.Show();
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
