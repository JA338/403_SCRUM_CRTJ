namespace Fall2020_CSC403_Project
{
    partial class FrmLevelCastle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevelCastle));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.secret = new System.Windows.Forms.Label();
            this.picEnemy4 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.deathscreen = new System.Windows.Forms.PictureBox();
            this.picEnemy0 = new System.Windows.Forms.PictureBox();
            this.picEnemy1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picOpenGate = new System.Windows.Forms.PictureBox();
            this.picExitColl = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picEnemy2 = new System.Windows.Forms.PictureBox();
            this.picEnemy3 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenGate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExitColl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(32, 21);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(122, 44);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.PNG");
            this.imageList1.Images.SetKeyName(1, "2.PNG");
            this.imageList1.Images.SetKeyName(2, "3.PNG");
            this.imageList1.Images.SetKeyName(3, "4.PNG");
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "5.PNG");
            this.imageList2.Images.SetKeyName(1, "6.PNG");
            this.imageList2.Images.SetKeyName(2, "7.PNG");
            this.imageList2.Images.SetKeyName(3, "8.PNG");
            // 
            // secret
            // 
            this.secret.AutoSize = true;
            this.secret.BackColor = System.Drawing.Color.Transparent;
            this.secret.Location = new System.Drawing.Point(240, 887);
            this.secret.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(34, 32);
            this.secret.TabIndex = 19;
            this.secret.Text = "B";
            // 
            // picEnemy4
            // 
            this.picEnemy4.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_bowizard;
            this.picEnemy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy4.Image = global::Fall2020_CSC403_Project.Properties.Resources.enemy_bowizard;
            this.picEnemy4.Location = new System.Drawing.Point(1693, 50);
            this.picEnemy4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEnemy4.Name = "picEnemy4";
            this.picEnemy4.Size = new System.Drawing.Size(296, 331);
            this.picEnemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy4.TabIndex = 18;
            this.picEnemy4.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(1741, 1505);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(144, 253);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // deathscreen
            // 
            this.deathscreen.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.deathscreen.BackColor = System.Drawing.Color.Transparent;
            this.deathscreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deathscreen.BackgroundImage")));
            this.deathscreen.Cursor = System.Windows.Forms.Cursors.No;
            this.deathscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deathscreen.Image = global::Fall2020_CSC403_Project.Properties.Resources.deathscreen;
            this.deathscreen.Location = new System.Drawing.Point(0, 0);
            this.deathscreen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.deathscreen.Name = "deathscreen";
            this.deathscreen.Size = new System.Drawing.Size(3653, 1786);
            this.deathscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deathscreen.TabIndex = 18;
            this.deathscreen.TabStop = false;
            this.deathscreen.Visible = false;
            // 
            // picEnemy0
            // 
            this.picEnemy0.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy0.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy0.Image")));
            this.picEnemy0.Location = new System.Drawing.Point(1384, 689);
            this.picEnemy0.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picEnemy0.Name = "picEnemy0";
            this.picEnemy0.Size = new System.Drawing.Size(208, 298);
            this.picEnemy0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy0.TabIndex = 21;
            this.picEnemy0.TabStop = false;
            // 
            // picEnemy1
            // 
            this.picEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy1.Image")));
            this.picEnemy1.Location = new System.Drawing.Point(2059, 689);
            this.picEnemy1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picEnemy1.Name = "picEnemy1";
            this.picEnemy1.Size = new System.Drawing.Size(208, 298);
            this.picEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy1.TabIndex = 22;
            this.picEnemy1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.Location = new System.Drawing.Point(-27, -29);
            this.picWall0.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(3733, 236);
            this.picWall0.TabIndex = 23;
            this.picWall0.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall1.BackgroundImage")));
            this.picWall1.Image = ((System.Drawing.Image)(resources.GetObject("picWall1.Image")));
            this.picWall1.Location = new System.Drawing.Point(2285, 1462);
            this.picWall1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(379, 155);
            this.picWall1.TabIndex = 24;
            this.picWall1.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall2.BackgroundImage")));
            this.picWall2.Image = ((System.Drawing.Image)(resources.GetObject("picWall2.Image")));
            this.picWall2.Location = new System.Drawing.Point(984, 1462);
            this.picWall2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(371, 155);
            this.picWall2.TabIndex = 25;
            this.picWall2.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.Location = new System.Drawing.Point(-27, 72);
            this.picWall4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(91, 1715);
            this.picWall4.TabIndex = 26;
            this.picWall4.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.Location = new System.Drawing.Point(3616, 21);
            this.picWall3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(91, 1765);
            this.picWall3.TabIndex = 27;
            this.picWall3.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.Location = new System.Drawing.Point(3, 1762);
            this.picWall5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(3651, 24);
            this.picWall5.TabIndex = 28;
            this.picWall5.TabStop = false;
            // 
            // picOpenGate
            // 
            this.picOpenGate.Image = ((System.Drawing.Image)(resources.GetObject("picOpenGate.Image")));
            this.picOpenGate.Location = new System.Drawing.Point(85, 21);
            this.picOpenGate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picOpenGate.Name = "picOpenGate";
            this.picOpenGate.Size = new System.Drawing.Size(69, 43);
            this.picOpenGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOpenGate.TabIndex = 45;
            this.picOpenGate.TabStop = false;
            // 
            // picExitColl
            // 
            this.picExitColl.BackColor = System.Drawing.Color.Transparent;
            this.picExitColl.Location = new System.Drawing.Point(1693, 122);
            this.picExitColl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picExitColl.Name = "picExitColl";
            this.picExitColl.Size = new System.Drawing.Size(259, 143);
            this.picExitColl.TabIndex = 47;
            this.picExitColl.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1037, 887);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 577);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2344, 887);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 577);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall6.BackgroundImage")));
            this.picWall6.Image = ((System.Drawing.Image)(resources.GetObject("picWall6.Image")));
            this.picWall6.Location = new System.Drawing.Point(0, 861);
            this.picWall6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(371, 155);
            this.picWall6.TabIndex = 50;
            this.picWall6.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWall7.BackgroundImage")));
            this.picWall7.Image = ((System.Drawing.Image)(resources.GetObject("picWall7.Image")));
            this.picWall7.Location = new System.Drawing.Point(3299, 887);
            this.picWall7.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(371, 155);
            this.picWall7.TabIndex = 51;
            this.picWall7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3355, 286);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(263, 629);
            this.pictureBox5.TabIndex = 52;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(40, 248);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(263, 629);
            this.pictureBox6.TabIndex = 53;
            this.pictureBox6.TabStop = false;
            // 
            // picEnemy2
            // 
            this.picEnemy2.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy2.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy2.Image")));
            this.picEnemy2.Location = new System.Drawing.Point(1384, 1099);
            this.picEnemy2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picEnemy2.Name = "picEnemy2";
            this.picEnemy2.Size = new System.Drawing.Size(208, 298);
            this.picEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy2.TabIndex = 54;
            this.picEnemy2.TabStop = false;
            // 
            // picEnemy3
            // 
            this.picEnemy3.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy3.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy3.Image")));
            this.picEnemy3.Location = new System.Drawing.Point(2059, 1099);
            this.picEnemy3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.picEnemy3.Name = "picEnemy3";
            this.picEnemy3.Size = new System.Drawing.Size(208, 298);
            this.picEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy3.TabIndex = 55;
            this.picEnemy3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(984, 763);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(371, 155);
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(2293, 763);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(371, 155);
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 145);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(371, 155);
            this.pictureBox7.TabIndex = 58;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(3299, 145);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(371, 155);
            this.pictureBox8.TabIndex = 59;
            this.pictureBox8.TabStop = false;
            // 
            // label1
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(34, 86);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(277, 57);
            this.scoreLabel.TabIndex = 49;
            this.scoreLabel.Text = "scoreLabel";
            // 
            // FrmLevelCastle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(3653, 1786);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.deathscreen);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picEnemy4);
            this.Controls.Add(this.picEnemy3);
            this.Controls.Add(this.picEnemy2);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picExitColl);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picEnemy1);
            this.Controls.Add(this.picEnemy0);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picOpenGate);
            this.Controls.Add(this.deathscreen);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmLevelCastle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenGate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExitColl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.PictureBox picEnemy4;
        private System.Windows.Forms.PictureBox deathscreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label secret;
        private System.Windows.Forms.PictureBox picEnemy0;
        private System.Windows.Forms.PictureBox picEnemy1;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picOpenGate;
        private System.Windows.Forms.PictureBox picExitColl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picEnemy2;
        private System.Windows.Forms.PictureBox picEnemy3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label scoreLabel;
    }
}

