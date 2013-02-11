namespace Sorry {
    partial class FormInstructions {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstructions));
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblInstructions = new System.Windows.Forms.Label();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitle.Location = new System.Drawing.Point(12, 21);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(284, 33);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "How To Play Sorry!";
            // 
            // LblInstructions
            // 
            this.LblInstructions.AutoSize = true;
            this.LblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstructions.Location = new System.Drawing.Point(12, 76);
            this.LblInstructions.Name = "LblInstructions";
            this.LblInstructions.Size = new System.Drawing.Size(728, 203);
            this.LblInstructions.TabIndex = 3;
            this.LblInstructions.Text = resources.GetString("LblInstructions.Text");
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.BackgroundImage = global::Sorry.Properties.Resources.LogoSorry;
            this.PicBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxLogo.Location = new System.Drawing.Point(559, 263);
            this.PicBoxLogo.Name = "pictureBox1";
            this.PicBoxLogo.Size = new System.Drawing.Size(183, 50);
            this.PicBoxLogo.TabIndex = 4;
            this.PicBoxLogo.TabStop = false;
            // 
            // FormInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 325);
            this.Controls.Add(this.PicBoxLogo);
            this.Controls.Add(this.LblInstructions);
            this.Controls.Add(this.LblTitle);
            this.DoubleBuffered = true;
            this.Name = "FormInstructions";
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblInstructions;
        private System.Windows.Forms.PictureBox PicBoxLogo;
    }
}