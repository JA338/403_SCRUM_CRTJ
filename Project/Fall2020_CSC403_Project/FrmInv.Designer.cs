namespace Fall2020_CSC403_Project
{
    partial class FrmInv
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
            this.InvBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InvBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 284);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInv";
            this.Text = "FrmInv";
            //
            // Inv Box 1
            //
            this.InvBox.BackColor = System.Drawing.Color.Transparent;
            this.InvBox.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.InvBox;
            this.InvBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InvBox.Location = new System.Drawing.Point(266, 154);
            this.InvBox.Name = "InvBox1";
            this.InvBox.Size = new System.Drawing.Size(197, 118);
            this.InvBox.TabIndex = 10;
            this.InvBox.TabStop = false;
            this.Click += new System.EventHandler(this.FrmInv_Click);
            this.MouseHover += new System.EventHandler(this.FrmInv_MouseHover);


            ((System.ComponentModel.ISupportInitialize)(this.InvBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();



        }

        #endregion
        private System.Windows.Forms.PictureBox picInvBox1;

    }
}