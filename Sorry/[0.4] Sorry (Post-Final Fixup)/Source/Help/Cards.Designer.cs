namespace Sorry {
    partial class Cards {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblCardInfo = new System.Windows.Forms.Label();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(160, 33);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "The Cards";
            // 
            // LblCardInfo
            // 
            this.LblCardInfo.AutoSize = true;
            this.LblCardInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardInfo.Location = new System.Drawing.Point(18, 46);
            this.LblCardInfo.Name = "LblCardInfo";
            this.LblCardInfo.Size = new System.Drawing.Size(846, 304);
            this.LblCardInfo.TabIndex = 1;
            this.LblCardInfo.Text = resources.GetString("LblCardInfo.Text");
            // 
            // pictureBox1
            // 
            this.PicBoxLogo.BackgroundImage = global::Sorry.Properties.Resources.LogoSorry;
            this.PicBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxLogo.Location = new System.Drawing.Point(775, 320);
            this.PicBoxLogo.Name = "pictureBox1";
            this.PicBoxLogo.Size = new System.Drawing.Size(176, 59);
            this.PicBoxLogo.TabIndex = 2;
            this.PicBoxLogo.TabStop = false;
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 391);
            this.Controls.Add(this.LblCardInfo);
            this.Controls.Add(this.PicBoxLogo);
            this.Controls.Add(this.LblTitle);
            this.Name = "Cards";
            this.Text = "Cards";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblCardInfo;
        private System.Windows.Forms.PictureBox PicBoxLogo;
    }
}