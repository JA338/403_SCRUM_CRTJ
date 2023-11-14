﻿namespace Fall2020_CSC403_Project {
  partial class FrmBattle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnemyHealthFull = new System.Windows.Forms.Label();
            this.picBossBattle = new System.Windows.Forms.PictureBox();
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.tmrFinalBattle = new System.Windows.Forms.Timer(this.components);
            this.BtnFlee = new System.Windows.Forms.Button();
            this.BtnDefend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerStaminaFull = new System.Windows.Forms.Label();
            this.lblPlayerManaFull = new System.Windows.Forms.Label();
            this.BtnFireball = new System.Windows.Forms.Button();
            this.BtnHeal = new System.Windows.Forms.Button();
            this.picholdSam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picholdSam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(56, 467);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(110, 43);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Red;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(73, 60);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(226, 20);
            this.lblPlayerHealthFull.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(70, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(515, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 5;
            // 
            // lblEnemyHealthFull
            // 
            this.lblEnemyHealthFull.BackColor = System.Drawing.Color.Red;
            this.lblEnemyHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblEnemyHealthFull.Location = new System.Drawing.Point(516, 60);
            this.lblEnemyHealthFull.Name = "lblEnemyHealthFull";
            this.lblEnemyHealthFull.Size = new System.Drawing.Size(226, 20);
            this.lblEnemyHealthFull.TabIndex = 6;
            // 
            // picBossBattle
            // 
            this.picBossBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.title_screen;
            this.picBossBattle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossBattle.Location = new System.Drawing.Point(780, 563);
            this.picBossBattle.Name = "picBossBattle";
            this.picBossBattle.Size = new System.Drawing.Size(30, 28);
            this.picBossBattle.TabIndex = 7;
            this.picBossBattle.TabStop = false;
            this.picBossBattle.Visible = false;
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_koolaid;
            this.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEnemy.Location = new System.Drawing.Point(515, 98);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(229, 267);
            this.picEnemy.TabIndex = 1;
            this.picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPlayer.Location = new System.Drawing.Point(70, 98);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(229, 267);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            this.picPlayer.Visible = false;
            // 
            // tmrFinalBattle
            // 
            this.tmrFinalBattle.Interval = 5600;
            this.tmrFinalBattle.Tick += new System.EventHandler(this.tmrFinalBattle_Tick);
            // 
            // BtnFlee
            // 
            this.BtnFlee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnFlee.Location = new System.Drawing.Point(172, 467);
            this.BtnFlee.Name = "BtnFlee";
            this.BtnFlee.Size = new System.Drawing.Size(110, 43);
            this.BtnFlee.TabIndex = 8;
            this.BtnFlee.Text = "Flee";
            this.BtnFlee.UseVisualStyleBackColor = true;
            this.BtnFlee.Click += new System.EventHandler(this.BtnFlee_Click);
            // 
            // BtnDefend
            // 
            this.BtnDefend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnDefend.Location = new System.Drawing.Point(172, 516);
            this.BtnDefend.Name = "BtnDefend";
            this.BtnDefend.Size = new System.Drawing.Size(110, 43);
            this.BtnDefend.TabIndex = 9;
            this.BtnDefend.Text = "Defend";
            this.BtnDefend.UseVisualStyleBackColor = true;
            this.BtnDefend.Click += new System.EventHandler(this.BtnDefend_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(70, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 23);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(70, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 23);
            this.label4.TabIndex = 11;
            // 
            // lblPlayerStaminaFull
            // 
            this.lblPlayerStaminaFull.BackColor = System.Drawing.Color.Gold;
            this.lblPlayerStaminaFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStaminaFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerStaminaFull.Location = new System.Drawing.Point(73, 387);
            this.lblPlayerStaminaFull.Name = "lblPlayerStaminaFull";
            this.lblPlayerStaminaFull.Size = new System.Drawing.Size(226, 20);
            this.lblPlayerStaminaFull.TabIndex = 12;
            // 
            // lblPlayerManaFull
            // 
            this.lblPlayerManaFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerManaFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerManaFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerManaFull.Location = new System.Drawing.Point(73, 430);
            this.lblPlayerManaFull.Name = "lblPlayerManaFull";
            this.lblPlayerManaFull.Size = new System.Drawing.Size(226, 20);
            this.lblPlayerManaFull.TabIndex = 13;
            // 
            // BtnFireball
            // 
            this.BtnFireball.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnFireball.Location = new System.Drawing.Point(56, 516);
            this.BtnFireball.Name = "BtnFireball";
            this.BtnFireball.Size = new System.Drawing.Size(110, 43);
            this.BtnFireball.TabIndex = 14;
            this.BtnFireball.Text = "Fire Ball";
            this.BtnFireball.UseVisualStyleBackColor = true;
            this.BtnFireball.Click += new System.EventHandler(this.BtnFireball_Click);
            // 
            // BtnHeal
            // 
            this.BtnHeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnHeal.Location = new System.Drawing.Point(288, 478);
            this.BtnHeal.Name = "BtnHeal";
            this.BtnHeal.Size = new System.Drawing.Size(80, 70);
            this.BtnHeal.TabIndex = 15;
            this.BtnHeal.Text = "Heal Spell";
            this.BtnHeal.UseVisualStyleBackColor = true;
            this.BtnHeal.Click += new System.EventHandler(this.BtnHeal_Click);
            // 
            // picholdSam
            // 
            this.picholdSam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picholdSam.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.holdSamehada;
            this.picholdSam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picholdSam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picholdSam.Location = new System.Drawing.Point(70, 98);
            this.picholdSam.Name = "picholdSam";
            this.picholdSam.Size = new System.Drawing.Size(229, 267);
            this.picholdSam.TabIndex = 0;
            this.picholdSam.TabStop = false;
            // 
            // FrmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 603);
            this.Controls.Add(this.BtnHeal);
            this.Controls.Add(this.BtnFireball);
            this.Controls.Add(this.picBossBattle);
            this.Controls.Add(this.lblPlayerManaFull);
            this.Controls.Add(this.lblPlayerStaminaFull);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDefend);
            this.Controls.Add(this.BtnFlee);
            this.Controls.Add(this.lblEnemyHealthFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.picholdSam);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight!";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picBossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picholdSam)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picholdSam;
    private System.Windows.Forms.PictureBox picEnemy;
    private System.Windows.Forms.Button btnAttack;
    private System.Windows.Forms.Label lblPlayerHealthFull;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblEnemyHealthFull;
    private System.Windows.Forms.PictureBox picBossBattle;
    private System.Windows.Forms.Timer tmrFinalBattle;
        private System.Windows.Forms.Button BtnFlee;
        private System.Windows.Forms.Button BtnDefend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerStaminaFull;
        private System.Windows.Forms.Label lblPlayerManaFull;
        private System.Windows.Forms.Button BtnFireball;
        private System.Windows.Forms.Button BtnHeal;
    }
}