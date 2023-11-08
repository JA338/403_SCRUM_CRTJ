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
            this.picMedEnemy1 = new System.Windows.Forms.PictureBox();
            this.picMidEnemy2 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picMidEnemy3 = new System.Windows.Forms.PictureBox();
            this.picLowEnemy1 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyBowizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMidEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMidEnemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
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
            this.picWall0.Location = new System.Drawing.Point(520, 201);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(140, 152);
            this.picWall0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall0.TabIndex = 19;
            this.picWall0.TabStop = false;
            // 
            // picMedEnemy1
            // 
            this.picMedEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.picMedEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("picMedEnemy1.Image")));
            this.picMedEnemy1.Location = new System.Drawing.Point(202, 495);
            this.picMedEnemy1.Name = "picMedEnemy1";
            this.picMedEnemy1.Size = new System.Drawing.Size(103, 140);
            this.picMedEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMedEnemy1.TabIndex = 20;
            this.picMedEnemy1.TabStop = false;
            // 
            // picMidEnemy2
            // 
            this.picMidEnemy2.BackColor = System.Drawing.Color.Transparent;
            this.picMidEnemy2.Image = ((System.Drawing.Image)(resources.GetObject("picMidEnemy2.Image")));
            this.picMidEnemy2.Location = new System.Drawing.Point(357, 116);
            this.picMidEnemy2.Name = "picMidEnemy2";
            this.picMidEnemy2.Size = new System.Drawing.Size(103, 124);
            this.picMidEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMidEnemy2.TabIndex = 21;
            this.picMidEnemy2.TabStop = false;
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
            this.picWall3.Location = new System.Drawing.Point(15, 260);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(89, 93);
            this.picWall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall3.TabIndex = 27;
            this.picWall3.TabStop = false;
            // 
            // picMidEnemy3
            // 
            this.picMidEnemy3.BackColor = System.Drawing.Color.Transparent;
            this.picMidEnemy3.Image = ((System.Drawing.Image)(resources.GetObject("picMidEnemy3.Image")));
            this.picMidEnemy3.Location = new System.Drawing.Point(756, 425);
            this.picMidEnemy3.Name = "picMidEnemy3";
            this.picMidEnemy3.Size = new System.Drawing.Size(103, 140);
            this.picMidEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMidEnemy3.TabIndex = 29;
            this.picMidEnemy3.TabStop = false;
            // 
            // picLowEnemy1
            // 
            this.picLowEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.picLowEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("picLowEnemy1.Image")));
            this.picLowEnemy1.Location = new System.Drawing.Point(1082, 556);
            this.picLowEnemy1.Name = "picLowEnemy1";
            this.picLowEnemy1.Size = new System.Drawing.Size(103, 140);
            this.picLowEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLowEnemy1.TabIndex = 30;
            this.picLowEnemy1.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.Image = ((System.Drawing.Image)(resources.GetObject("picWall6.Image")));
            this.picWall6.Location = new System.Drawing.Point(634, 175);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(59, 65);
            this.picWall6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall6.TabIndex = 32;
            this.picWall6.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.Image = ((System.Drawing.Image)(resources.GetObject("picWall7.Image")));
            this.picWall7.Location = new System.Drawing.Point(656, 342);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(59, 65);
            this.picWall7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall7.TabIndex = 33;
            this.picWall7.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.Image = ((System.Drawing.Image)(resources.GetObject("picWall8.Image")));
            this.picWall8.Location = new System.Drawing.Point(-51, -63);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(176, 182);
            this.picWall8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall8.TabIndex = 34;
            this.picWall8.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWall9.Image = ((System.Drawing.Image)(resources.GetObject("picWall9.Image")));
            this.picWall9.Location = new System.Drawing.Point(1146, 0);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(227, 205);
            this.picWall9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall9.TabIndex = 35;
            this.picWall9.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWall10.Image = ((System.Drawing.Image)(resources.GetObject("picWall10.Image")));
            this.picWall10.Location = new System.Drawing.Point(176, 0);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(104, 93);
            this.picWall10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall10.TabIndex = 36;
            this.picWall10.TabStop = false;
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWall11.Image = ((System.Drawing.Image)(resources.GetObject("picWall11.Image")));
            this.picWall11.Location = new System.Drawing.Point(756, 52);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(93, 80);
            this.picWall11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall11.TabIndex = 37;
            this.picWall11.TabStop = false;
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
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picLowEnemy1);
            this.Controls.Add(this.picMidEnemy3);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picMidEnemy2);
            this.Controls.Add(this.picMedEnemy1);
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
            ((System.ComponentModel.ISupportInitialize)(this.picMedEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMidEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMidEnemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
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
        private System.Windows.Forms.PictureBox picMedEnemy1;
        private System.Windows.Forms.PictureBox picMidEnemy2;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picMidEnemy3;
        private System.Windows.Forms.PictureBox picLowEnemy1;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.PictureBox picWall8;
        private System.Windows.Forms.PictureBox picWall9;
        private System.Windows.Forms.PictureBox picWall10;
        private System.Windows.Forms.PictureBox picWall11;
    }
}

