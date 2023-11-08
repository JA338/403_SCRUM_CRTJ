namespace Fall2020_CSC403_Project
{
    partial class FrmLevelForest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevelForest));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.picEnemyBowizard = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.deathscreen = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picEnemy1 = new System.Windows.Forms.PictureBox();
            this.picEnemy2 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picEnemy3 = new System.Windows.Forms.PictureBox();
            this.picEnemy4 = new System.Windows.Forms.PictureBox();
            this.picPath1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyBowizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
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
            // picEnemyBowizard
            // 
            this.picEnemyBowizard.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyBowizard.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_bowizard;
            this.picEnemyBowizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyBowizard.Location = new System.Drawing.Point(0, 0);
            this.picEnemyBowizard.Margin = new System.Windows.Forms.Padding(1);
            this.picEnemyBowizard.Name = "picEnemyBowizard";
            this.picEnemyBowizard.Size = new System.Drawing.Size(0, 0);
            this.picEnemyBowizard.TabIndex = 18;
            this.picEnemyBowizard.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(71, 509);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // deathscreen
            // 
            this.deathscreen.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.deathscreen.BackColor = System.Drawing.Color.Transparent;
            this.deathscreen.Cursor = System.Windows.Forms.Cursors.No;
            this.deathscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deathscreen.Image = global::Fall2020_CSC403_Project.Properties.Resources.deathscreen;
            this.deathscreen.Location = new System.Drawing.Point(0, 0);
            this.deathscreen.Name = "deathscreen";
            this.deathscreen.Size = new System.Drawing.Size(1370, 749);
            this.deathscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deathscreen.TabIndex = 18;
            this.deathscreen.TabStop = false;
            this.deathscreen.Visible = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.Image = ((System.Drawing.Image)(resources.GetObject("picWall0.Image")));
            this.picWall0.Location = new System.Drawing.Point(569, 196);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(140, 152);
            this.picWall0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall0.TabIndex = 19;
            this.picWall0.TabStop = false;
            // 
            // picEnemy1
            // 
            this.picEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy1.Image")));
            this.picEnemy1.Location = new System.Drawing.Point(202, 495);
            this.picEnemy1.Name = "picEnemy1";
            this.picEnemy1.Size = new System.Drawing.Size(103, 140);
            this.picEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy1.TabIndex = 20;
            this.picEnemy1.TabStop = false;
            // 
            // picEnemy2
            // 
            this.picEnemy2.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy2.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy2.Image")));
            this.picEnemy2.Location = new System.Drawing.Point(357, 116);
            this.picEnemy2.Name = "picEnemy2";
            this.picEnemy2.Size = new System.Drawing.Size(103, 124);
            this.picEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy2.TabIndex = 21;
            this.picEnemy2.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.Location = new System.Drawing.Point(-7, 0);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(13, 759);
            this.picWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall1.TabIndex = 22;
            this.picWall1.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.Location = new System.Drawing.Point(1366, -10);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(13, 769);
            this.picWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall2.TabIndex = 23;
            this.picWall2.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.Location = new System.Drawing.Point(-7, -4);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(1380, 10);
            this.picWall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall4.TabIndex = 25;
            this.picWall4.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.Location = new System.Drawing.Point(-7, 739);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(1380, 10);
            this.picWall5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall5.TabIndex = 26;
            this.picWall5.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.Image = ((System.Drawing.Image)(resources.GetObject("picWall3.Image")));
            this.picWall3.Location = new System.Drawing.Point(26, 374);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(89, 93);
            this.picWall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall3.TabIndex = 27;
            this.picWall3.TabStop = false;
            // 
            // picEnemy3
            // 
            this.picEnemy3.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy3.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy3.Image")));
            this.picEnemy3.Location = new System.Drawing.Point(756, 425);
            this.picEnemy3.Name = "picEnemy3";
            this.picEnemy3.Size = new System.Drawing.Size(103, 140);
            this.picEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy3.TabIndex = 29;
            this.picEnemy3.TabStop = false;
            // 
            // picEnemy4
            // 
            this.picEnemy4.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy4.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy4.Image")));
            this.picEnemy4.Location = new System.Drawing.Point(1082, 556);
            this.picEnemy4.Name = "picEnemy4";
            this.picEnemy4.Size = new System.Drawing.Size(103, 140);
            this.picEnemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy4.TabIndex = 30;
            this.picEnemy4.TabStop = false;
            // 
            // picPath1
            // 
            this.picPath1.BackColor = System.Drawing.Color.Transparent;
            this.picPath1.Image = ((System.Drawing.Image)(resources.GetObject("picPath1.Image")));
            this.picPath1.Location = new System.Drawing.Point(-67, 495);
            this.picPath1.Name = "picPath1";
            this.picPath1.Size = new System.Drawing.Size(294, 155);
            this.picPath1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPath1.TabIndex = 31;
            this.picPath1.TabStop = false;
            // 
            // FrmLevelForest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picPath1);
            this.Controls.Add(this.picEnemy4);
            this.Controls.Add(this.picEnemy3);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picEnemy2);
            this.Controls.Add(this.picEnemy1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picEnemyBowizard);
            this.Controls.Add(this.deathscreen);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLevelForest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevelForest_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyBowizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.PictureBox picEnemyBowizard;
        private System.Windows.Forms.PictureBox deathscreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picEnemy1;
        private System.Windows.Forms.PictureBox picEnemy2;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picEnemy3;
        private System.Windows.Forms.PictureBox picEnemy4;
        private System.Windows.Forms.PictureBox picPath1;
    }
}

