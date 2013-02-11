namespace Sorry {
    partial class About {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Lbl_History = new System.Windows.Forms.Label();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_History
            // 
            this.Lbl_History.AutoSize = true;
            this.Lbl_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_History.Location = new System.Drawing.Point(14, 87);
            this.Lbl_History.Name = "LblHistory";
            this.Lbl_History.Size = new System.Drawing.Size(785, 168);
            this.Lbl_History.TabIndex = 1;
            this.Lbl_History.Text = resources.GetString("LblHistory.Text");
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(12, 26);
            this.Lbl_Title.Name = "LblTitle";
            this.Lbl_Title.Size = new System.Drawing.Size(176, 33);
            this.Lbl_Title.TabIndex = 2;
            this.Lbl_Title.Text = "About Sorry!";
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.BackgroundImage = global::Sorry.Properties.Resources.LogoSorry;
            this.PicBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxLogo.Location = new System.Drawing.Point(619, 298);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(176, 50);
            this.PicBoxLogo.TabIndex = 0;
            this.PicBoxLogo.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 360);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Lbl_History);
            this.Controls.Add(this.PicBoxLogo);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxLogo;
        private System.Windows.Forms.Label Lbl_History;
        private System.Windows.Forms.Label Lbl_Title;
    }
}