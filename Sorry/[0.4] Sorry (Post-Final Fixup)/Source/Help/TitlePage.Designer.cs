namespace Sorry {
    partial class TitlePage {
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
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackgroundImage = global::Sorry.Properties.Resources.PlayButtton;
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlay.Location = new System.Drawing.Point(12, 262);
            this.BtnPlay.Name = "button1";
            this.BtnPlay.Size = new System.Drawing.Size(146, 42);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackgroundImage = global::Sorry.Properties.Resources.QuitButton;
            this.BtnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnQuit.Location = new System.Drawing.Point(12, 310);
            this.BtnQuit.Name = "button2";
            this.BtnQuit.Size = new System.Drawing.Size(80, 42);
            this.BtnQuit.TabIndex = 1;
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.button2_Click);
            // 
            // TitlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sorry.Properties.Resources.Title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 364);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "TitlePage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sorry: The Game - A Villanueva  and Pelayo Collaboration";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TitlePage_KeyDown);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnQuit;
    }
}