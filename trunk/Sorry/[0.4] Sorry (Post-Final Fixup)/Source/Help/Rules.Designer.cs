namespace Sorry {
    partial class FormRules {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRules));
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblRules = new System.Windows.Forms.Label();
            this.PicBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.Black;
            this.LblTitle.Location = new System.Drawing.Point(12, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(90, 33);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Rules";
            // 
            // LblRules
            // 
            this.LblRules.AutoSize = true;
            this.LblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRules.Location = new System.Drawing.Point(11, 55);
            this.LblRules.Name = "LblRules";
            this.LblRules.Size = new System.Drawing.Size(762, 306);
            this.LblRules.TabIndex = 3;
            this.LblRules.Text = resources.GetString("LblRules.Text");
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.BackgroundImage = global::Sorry.Properties.Resources.LogoSorry;
            this.PicBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxLogo.Location = new System.Drawing.Point(701, 342);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(183, 50);
            this.PicBoxLogo.TabIndex = 5;
            this.PicBoxLogo.TabStop = false;
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(896, 404);
            this.Controls.Add(this.PicBoxLogo);
            this.Controls.Add(this.LblRules);
            this.Controls.Add(this.LblTitle);
            this.DoubleBuffered = true;
            this.Name = "FormRules";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblRules;
        private System.Windows.Forms.PictureBox PicBoxLogo;
    }
}