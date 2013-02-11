namespace Sorry {
    partial class DialogPawnIntializeType {
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
            this.RadBtnGate = new System.Windows.Forms.RadioButton();
            this.RadBtnStart = new System.Windows.Forms.RadioButton();
            this.RadBtnSafe = new System.Windows.Forms.RadioButton();
            this.LblInstruct = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadBtnGate
            // 
            this.RadBtnGate.AutoSize = true;
            this.RadBtnGate.Location = new System.Drawing.Point(63, 42);
            this.RadBtnGate.Margin = new System.Windows.Forms.Padding(1);
            this.RadBtnGate.Name = "radBtnGate";
            this.RadBtnGate.Size = new System.Drawing.Size(73, 17);
            this.RadBtnGate.TabIndex = 0;
            this.RadBtnGate.Text = "Start Gate";
            this.RadBtnGate.UseVisualStyleBackColor = true;
            this.RadBtnGate.CheckedChanged += new System.EventHandler(this.RadBtnGate_CheckedChanged);
            // 
            // RadBtnStart
            // 
            this.RadBtnStart.AutoSize = true;
            this.RadBtnStart.Checked = true;
            this.RadBtnStart.Location = new System.Drawing.Point(63, 23);
            this.RadBtnStart.Margin = new System.Windows.Forms.Padding(1);
            this.RadBtnStart.Name = "radBtnStart";
            this.RadBtnStart.Size = new System.Drawing.Size(90, 17);
            this.RadBtnStart.TabIndex = 1;
            this.RadBtnStart.TabStop = true;
            this.RadBtnStart.Text = "Start (Default)";
            this.RadBtnStart.UseVisualStyleBackColor = true;
            this.RadBtnStart.CheckedChanged += new System.EventHandler(this.RadBtnStart_CheckedChanged);
            // 
            // RadBtnSafe
            // 
            this.RadBtnSafe.AutoSize = true;
            this.RadBtnSafe.Location = new System.Drawing.Point(63, 61);
            this.RadBtnSafe.Margin = new System.Windows.Forms.Padding(1);
            this.RadBtnSafe.Name = "radBtnSafe";
            this.RadBtnSafe.Size = new System.Drawing.Size(75, 17);
            this.RadBtnSafe.TabIndex = 2;
            this.RadBtnSafe.Text = "Safe Zone";
            this.RadBtnSafe.UseVisualStyleBackColor = true;
            this.RadBtnSafe.CheckedChanged += new System.EventHandler(this.RadBtnSafe_CheckedChanged);
            // 
            // LblInstruct
            // 
            this.LblInstruct.AutoSize = true;
            this.LblInstruct.Location = new System.Drawing.Point(12, 9);
            this.LblInstruct.Name = "label1";
            this.LblInstruct.Size = new System.Drawing.Size(129, 13);
            this.LblInstruct.TabIndex = 3;
            this.LblInstruct.Text = "Choose where to initialize:";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(61, 91);
            this.BtnOK.Name = "btnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // DialogPawnIntializeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 126);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblInstruct);
            this.Controls.Add(this.RadBtnSafe);
            this.Controls.Add(this.RadBtnStart);
            this.Controls.Add(this.RadBtnGate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogPawnIntializeType";
            this.Text = "Start Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadBtnGate;
        private System.Windows.Forms.RadioButton RadBtnStart;
        private System.Windows.Forms.RadioButton RadBtnSafe;
        private System.Windows.Forms.Label LblInstruct;
        private System.Windows.Forms.Button BtnOK;
    }
}