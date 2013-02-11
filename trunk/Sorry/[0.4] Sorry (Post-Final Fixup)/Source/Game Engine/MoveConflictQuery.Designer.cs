namespace Sorry {
    partial class FormMoveQuery {
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.RadBtnChc1 = new System.Windows.Forms.RadioButton();
            this.RadBtnChc2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to...";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(72, 79);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // RadBtnChc1
            // 
            this.RadBtnChc1.AutoSize = true;
            this.RadBtnChc1.Location = new System.Drawing.Point(36, 48);
            this.RadBtnChc1.Name = "RadBtnChc1";
            this.RadBtnChc1.Size = new System.Drawing.Size(108, 17);
            this.RadBtnChc1.TabIndex = 2;
            this.RadBtnChc1.Text = "Switch with pawn";
            this.RadBtnChc1.UseVisualStyleBackColor = true;
            this.RadBtnChc1.CheckedChanged += new System.EventHandler(this.RadBtn_Chc1_CheckedChanged);
            // 
            // RadBtnChc2
            // 
            this.RadBtnChc2.AutoSize = true;
            this.RadBtnChc2.Checked = true;
            this.RadBtnChc2.Location = new System.Drawing.Point(36, 25);
            this.RadBtnChc2.Name = "RadBtnChc2";
            this.RadBtnChc2.Size = new System.Drawing.Size(143, 17);
            this.RadBtnChc2.TabIndex = 3;
            this.RadBtnChc2.TabStop = true;
            this.RadBtnChc2.Text = "Bump pawn back to start";
            this.RadBtnChc2.UseVisualStyleBackColor = true;
            this.RadBtnChc2.CheckedChanged += new System.EventHandler(this.RadBtn_Chc2_CheckedChanged);
            // 
            // FormMoveQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 114);
            this.Controls.Add(this.RadBtnChc2);
            this.Controls.Add(this.RadBtnChc1);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMoveQuery";
            this.Text = "Move Conflict";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.RadioButton RadBtnChc1;
        private System.Windows.Forms.RadioButton RadBtnChc2;
    }
}