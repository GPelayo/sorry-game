namespace Sorry {
    partial class MainGame {
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
            this.Lbl_CardName = new System.Windows.Forms.Label();
            this.Btn_Skip = new System.Windows.Forms.Button();
            this.Btn_CancelMove = new System.Windows.Forms.Button();
            this.Lbl_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_CardName
            // 
            this.Lbl_CardName.AutoSize = true;
            this.Lbl_CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CardName.Location = new System.Drawing.Point(138, 265);
            this.Lbl_CardName.MaximumSize = new System.Drawing.Size(350, 0);
            this.Lbl_CardName.Name = "Lbl_CardName";
            this.Lbl_CardName.Size = new System.Drawing.Size(117, 20);
            this.Lbl_CardName.TabIndex = 0;
            this.Lbl_CardName.Text = "No Card Drawn";
            // 
            // Btn_Skip
            // 
            this.Btn_Skip.Location = new System.Drawing.Point(12, 623);
            this.Btn_Skip.Name = "Btn_Skip";
            this.Btn_Skip.Size = new System.Drawing.Size(67, 40);
            this.Btn_Skip.TabIndex = 1;
            this.Btn_Skip.Text = "Skip";
            this.Btn_Skip.UseVisualStyleBackColor = true;
            this.Btn_Skip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // Btn_CancelMove
            // 
            this.Btn_CancelMove.Enabled = false;
            this.Btn_CancelMove.Location = new System.Drawing.Point(85, 623);
            this.Btn_CancelMove.Name = "Btn_CancelMove";
            this.Btn_CancelMove.Size = new System.Drawing.Size(73, 40);
            this.Btn_CancelMove.TabIndex = 2;
            this.Btn_CancelMove.Text = "Cancel Move";
            this.Btn_CancelMove.UseVisualStyleBackColor = true;
            this.Btn_CancelMove.Click += new System.EventHandler(this.BtnCancelMove_Click);
            // 
            // Lbl_Message
            // 
            this.Lbl_Message.AutoSize = true;
            this.Lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message.Location = new System.Drawing.Point(137, 190);
            this.Lbl_Message.MaximumSize = new System.Drawing.Size(0, 350);
            this.Lbl_Message.MinimumSize = new System.Drawing.Size(350, 10);
            this.Lbl_Message.Name = "Lbl_Message";
            this.Lbl_Message.Size = new System.Drawing.Size(350, 29);
            this.Lbl_Message.TabIndex = 5;
            this.Lbl_Message.Text = "Message";
            this.Lbl_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 675);
            this.Controls.Add(this.Lbl_Message);
            this.Controls.Add(this.Btn_CancelMove);
            this.Controls.Add(this.Btn_Skip);
            this.Controls.Add(this.Lbl_CardName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sorry!: The Game";
            this.Activated += new System.EventHandler(this.MainGame_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainGame_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardShorcuts);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CardName;
        private System.Windows.Forms.Button Btn_Skip;
        private System.Windows.Forms.Button Btn_CancelMove;
        private System.Windows.Forms.Label Lbl_Message;
    }
}

