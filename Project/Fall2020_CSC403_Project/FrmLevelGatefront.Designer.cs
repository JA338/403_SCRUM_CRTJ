namespace Fall2020_CSC403_Project
{
    partial class FrmLevelGatefront
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevelGatefront));
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
            this.picEnemy0 = new System.Windows.Forms.PictureBox();
            this.picEnemy1 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picOpenGate = new System.Windows.Forms.PictureBox();
            this.picLever = new System.Windows.Forms.PictureBox();
            this.picExitColl = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyBowizard)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.picLever)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExitColl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
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
            // picEnemyBowizard
            // 
            this.picEnemyBowizard.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyBowizard.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_bowizard;
            this.picEnemyBowizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyBowizard.Location = new System.Drawing.Point(0, 0);
            this.picEnemyBowizard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.picPlayer.Location = new System.Drawing.Point(614, 631);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(144, 253);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // deathscreen
            // 
            this.deathscreen.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.deathscreen.BackColor = System.Drawing.Color.Transparent;
            this.deathscreen.Cursor = System.Windows.Forms.Cursors.No;
            this.deathscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deathscreen.Location = new System.Drawing.Point(0, 0);
            this.deathscreen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.deathscreen.Name = "deathscreen";
            this.deathscreen.Size = new System.Drawing.Size(1370, 749);
            this.deathscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deathscreen.TabIndex = 18;
            this.deathscreen.TabStop = false;
            this.deathscreen.Visible = false;
            // 
            // picEnemy0
            // 
            this.picEnemy0.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy0.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy0.Image")));
            this.picEnemy0.Location = new System.Drawing.Point(548, 289);
            this.picEnemy0.Name = "picEnemy0";
            this.picEnemy0.Size = new System.Drawing.Size(78, 125);
            this.picEnemy0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy0.TabIndex = 21;
            this.picEnemy0.TabStop = false;
            // 
            // picEnemy1
            // 
            this.picEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("picEnemy1.Image")));
            this.picEnemy1.Location = new System.Drawing.Point(772, 289);
            this.picEnemy1.Name = "picEnemy1";
            this.picEnemy1.Size = new System.Drawing.Size(208, 298);
            this.picEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemy1.TabIndex = 22;
            this.picEnemy1.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.Location = new System.Drawing.Point(0, 30);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(638, 253);
            this.picWall0.TabIndex = 23;
            this.picWall0.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.Location = new System.Drawing.Point(772, 30);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(635, 253);
            this.picWall1.TabIndex = 24;
            this.picWall1.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.Location = new System.Drawing.Point(400, 30);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(622, 103);
            this.picWall2.TabIndex = 25;
            this.picWall2.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.Location = new System.Drawing.Point(-10, 30);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(34, 719);
            this.picWall4.TabIndex = 26;
            this.picWall4.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.Location = new System.Drawing.Point(1356, 9);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(34, 740);
            this.picWall3.TabIndex = 27;
            this.picWall3.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.Location = new System.Drawing.Point(1, 739);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(1369, 10);
            this.picWall5.TabIndex = 28;
            this.picWall5.TabStop = false;
            // 
            // picOpenGate
            // 
            this.picOpenGate.Image = ((System.Drawing.Image)(resources.GetObject("picOpenGate.Image")));
            this.picOpenGate.Location = new System.Drawing.Point(32, 9);
            this.picOpenGate.Name = "picOpenGate";
            this.picOpenGate.Size = new System.Drawing.Size(26, 18);
            this.picOpenGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOpenGate.TabIndex = 45;
            this.picOpenGate.TabStop = false;
            // 
            // picLever
            // 
            this.picLever.BackColor = System.Drawing.Color.Transparent;
            this.picLever.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLever.Image = ((System.Drawing.Image)(resources.GetObject("picLever.Image")));
            this.picLever.Location = new System.Drawing.Point(475, 289);
            this.picLever.Name = "picLever";
            this.picLever.Size = new System.Drawing.Size(53, 54);
            this.picLever.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLever.TabIndex = 46;
            this.picLever.TabStop = false;
            // 
            // picExitColl
            // 
            this.picExitColl.BackColor = System.Drawing.Color.Transparent;
            this.picExitColl.Location = new System.Drawing.Point(658, 127);
            this.picExitColl.Name = "picExitColl";
            this.picExitColl.Size = new System.Drawing.Size(97, 60);
            this.picExitColl.TabIndex = 47;
            this.picExitColl.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWall9.Image = ((System.Drawing.Image)(resources.GetObject("picWall9.Image")));
            this.picWall9.Location = new System.Drawing.Point(-57, 470);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(380, 306);
            this.picWall9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall9.TabIndex = 48;
            this.picWall9.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWall10.Image = ((System.Drawing.Image)(resources.GetObject("picWall10.Image")));
            this.picWall10.Location = new System.Drawing.Point(240, 433);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(104, 93);
            this.picWall10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall10.TabIndex = 49;
            this.picWall10.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWall7.Image = ((System.Drawing.Image)(resources.GetObject("picWall7.Image")));
            this.picWall7.Location = new System.Drawing.Point(1027, 443);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(380, 306);
            this.picWall7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall7.TabIndex = 50;
            this.picWall7.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.Image = ((System.Drawing.Image)(resources.GetObject("picWall8.Image")));
            this.picWall8.Location = new System.Drawing.Point(987, 388);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(127, 138);
            this.picWall8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall8.TabIndex = 51;
            this.picWall8.TabStop = false;
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.Image = ((System.Drawing.Image)(resources.GetObject("picWall11.Image")));
            this.picWall11.Location = new System.Drawing.Point(928, 521);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(127, 138);
            this.picWall11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall11.TabIndex = 52;
            this.picWall11.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.Image = ((System.Drawing.Image)(resources.GetObject("picWall6.Image")));
            this.picWall6.Location = new System.Drawing.Point(300, 662);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(82, 75);
            this.picWall6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall6.TabIndex = 53;
            this.picWall6.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.Image = ((System.Drawing.Image)(resources.GetObject("picWall12.Image")));
            this.picWall12.Location = new System.Drawing.Point(987, 658);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(127, 138);
            this.picWall12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWall12.TabIndex = 54;
            this.picWall12.TabStop = false;
            // 
            // FrmLevelGatefront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picExitColl);
            this.Controls.Add(this.picLever);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picEnemy1);
            this.Controls.Add(this.picEnemy0);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picEnemyBowizard);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.deathscreen);
            this.Controls.Add(this.picOpenGate);
            this.DoubleBuffered = true;
            this.Name = "FrmLevelGatefront";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyBowizard)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.picLever)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExitColl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
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
        private System.Windows.Forms.PictureBox picEnemy0;
        private System.Windows.Forms.PictureBox picEnemy1;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picOpenGate;
        private System.Windows.Forms.PictureBox picLever;
        private System.Windows.Forms.PictureBox picExitColl;
        private System.Windows.Forms.PictureBox picWall9;
        private System.Windows.Forms.PictureBox picWall10;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.PictureBox picWall8;
        private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.PictureBox picWall12;
    }
}

