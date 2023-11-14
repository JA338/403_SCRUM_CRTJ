namespace Fall2020_CSC403_Project
{
    partial class FrmFireplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFireplace));
            this.BtnRest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRest
            // 
            this.BtnRest.BackColor = System.Drawing.Color.Transparent;
            this.BtnRest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRest.Location = new System.Drawing.Point(185, 186);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(131, 58);
            this.BtnRest.TabIndex = 0;
            this.BtnRest.Text = "Rest weary Traveler. Place your hand upon me and be releaved";
            this.BtnRest.UseMnemonic = false;
            this.BtnRest.UseVisualStyleBackColor = false;
            this.BtnRest.Click += new System.EventHandler(this.BtnRest_Click);
            // 
            // FrmFireplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(499, 275);
            this.Controls.Add(this.BtnRest);
            this.Name = "FrmFireplace";
            this.Text = "Fireplace";
            this.Load += new System.EventHandler(this.FrmFireplace_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRest;
    }
}