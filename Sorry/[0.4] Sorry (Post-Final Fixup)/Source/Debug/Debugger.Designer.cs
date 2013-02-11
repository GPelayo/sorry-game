namespace Sorry {
    partial class SorryDebugger {
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
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lbl_DebugMoveInfo = new System.Windows.Forms.Label();
            this.Lbl_PawnLoc = new System.Windows.Forms.Label();
            this.ChkBox_LockCard = new System.Windows.Forms.CheckBox();
            this.GrpBox_ForceCard = new System.Windows.Forms.GroupBox();
            this.CmboBox_ForceCard = new System.Windows.Forms.ComboBox();
            this.GrpBox_ButtonDisp = new System.Windows.Forms.GroupBox();
            this.RadBtn_SpaceNum = new System.Windows.Forms.RadioButton();
            this.RadBtn_PawnNum = new System.Windows.Forms.RadioButton();
            this.ChkBox_SpaceInfo = new System.Windows.Forms.CheckBox();
            this.GrpBox_ForcePlayer = new System.Windows.Forms.GroupBox();
            this.ChkBox_LockPlyr = new System.Windows.Forms.CheckBox();
            this.RadBtn_PlyrNone = new System.Windows.Forms.RadioButton();
            this.Lbl_ForceCard = new System.Windows.Forms.Label();
            this.RadBtn_PlyrFour = new System.Windows.Forms.RadioButton();
            this.RadBtn_PlyrThree = new System.Windows.Forms.RadioButton();
            this.RadBtn_PlyrOne = new System.Windows.Forms.RadioButton();
            this.RadBtn_PlyrTwo = new System.Windows.Forms.RadioButton();
            this.GrpBox_ForceCard.SuspendLayout();
            this.GrpBox_ButtonDisp.SuspendLayout();
            this.GrpBox_ForcePlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(12, 246);
            this.Btn_Close.Name = "btnClose";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Lbl_DebugMoveInfo
            // 
            this.Lbl_DebugMoveInfo.AutoSize = true;
            this.Lbl_DebugMoveInfo.Location = new System.Drawing.Point(103, 9);
            this.Lbl_DebugMoveInfo.MinimumSize = new System.Drawing.Size(110, 80);
            this.Lbl_DebugMoveInfo.Name = "lblDebugMoveInfo";
            this.Lbl_DebugMoveInfo.Size = new System.Drawing.Size(110, 80);
            this.Lbl_DebugMoveInfo.TabIndex = 6;
            this.Lbl_DebugMoveInfo.Text = "MoveInfo";
            // 
            // Lbl_PawnLoc
            // 
            this.Lbl_PawnLoc.AutoSize = true;
            this.Lbl_PawnLoc.Location = new System.Drawing.Point(12, 9);
            this.Lbl_PawnLoc.MinimumSize = new System.Drawing.Size(85, 234);
            this.Lbl_PawnLoc.Name = "lblPawnLoc";
            this.Lbl_PawnLoc.Size = new System.Drawing.Size(85, 234);
            this.Lbl_PawnLoc.TabIndex = 10;
            this.Lbl_PawnLoc.Text = "PawnLocations";
            // 
            // ChkBoxLockCard
            // 
            this.ChkBox_LockCard.AutoSize = true;
            this.ChkBox_LockCard.Enabled = false;
            this.ChkBox_LockCard.Location = new System.Drawing.Point(6, 46);
            this.ChkBox_LockCard.Name = "ChkBoxLockCard";
            this.ChkBox_LockCard.Size = new System.Drawing.Size(50, 17);
            this.ChkBox_LockCard.TabIndex = 15;
            this.ChkBox_LockCard.Text = "Lock";
            this.ChkBox_LockCard.UseVisualStyleBackColor = true;
            this.ChkBox_LockCard.CheckedChanged += new System.EventHandler(this.ChkBoxLock_Clicked);
            // 
            // GrpBox_ForceCard
            // 
            this.GrpBox_ForceCard.Controls.Add(this.CmboBox_ForceCard);
            this.GrpBox_ForceCard.Controls.Add(this.ChkBox_LockCard);
            this.GrpBox_ForceCard.Location = new System.Drawing.Point(251, 9);
            this.GrpBox_ForceCard.Name = "grpBoxForceCard";
            this.GrpBox_ForceCard.Size = new System.Drawing.Size(145, 69);
            this.GrpBox_ForceCard.TabIndex = 16;
            this.GrpBox_ForceCard.TabStop = false;
            this.GrpBox_ForceCard.Text = "Force Card";
            // 
            // CmboBox_ForceCard
            // 
            this.CmboBox_ForceCard.AllowDrop = true;
            this.CmboBox_ForceCard.ItemHeight = 13;
            this.CmboBox_ForceCard.Items.AddRange(new object[] {
            "[1-Card]",
            "[2-Card]",
            "[3-Card]",
            "[4-Card]",
            "[5-Card]",
            "[7-Card]",
            "[8-Card]",
            "[10-Card]",
            "[11-Card]",
            "[12-Card]",
            "[Sorry Card]"});
            this.CmboBox_ForceCard.Location = new System.Drawing.Point(6, 19);
            this.CmboBox_ForceCard.Name = "cmboBoxForceCard";
            this.CmboBox_ForceCard.Size = new System.Drawing.Size(104, 21);
            this.CmboBox_ForceCard.TabIndex = 18;
            this.CmboBox_ForceCard.Text = "Choose a Card...";
            this.CmboBox_ForceCard.SelectedIndexChanged += new System.EventHandler(this.CmboBoxForceCard_SelectedIndexChanged);
            // 
            // GrpBox_ButtonDisp
            // 
            this.GrpBox_ButtonDisp.Controls.Add(this.RadBtn_SpaceNum);
            this.GrpBox_ButtonDisp.Controls.Add(this.RadBtn_PawnNum);
            this.GrpBox_ButtonDisp.Controls.Add(this.ChkBox_SpaceInfo);
            this.GrpBox_ButtonDisp.Location = new System.Drawing.Point(251, 174);
            this.GrpBox_ButtonDisp.Name = "grpBoxButtonDisp";
            this.GrpBox_ButtonDisp.Size = new System.Drawing.Size(145, 82);
            this.GrpBox_ButtonDisp.TabIndex = 17;
            this.GrpBox_ButtonDisp.TabStop = false;
            this.GrpBox_ButtonDisp.Text = "Button Text Display";
            // 
            // RadBtn_SpaceNum
            // 
            this.RadBtn_SpaceNum.AutoSize = true;
            this.RadBtn_SpaceNum.Enabled = false;
            this.RadBtn_SpaceNum.Location = new System.Drawing.Point(22, 59);
            this.RadBtn_SpaceNum.Margin = new System.Windows.Forms.Padding(1);
            this.RadBtn_SpaceNum.Name = "radBtnSpaceNum";
            this.RadBtn_SpaceNum.Size = new System.Drawing.Size(66, 17);
            this.RadBtn_SpaceNum.TabIndex = 10;
            this.RadBtn_SpaceNum.TabStop = true;
            this.RadBtn_SpaceNum.Text = "Space #";
            this.RadBtn_SpaceNum.UseVisualStyleBackColor = true;
            this.RadBtn_SpaceNum.CheckedChanged += new System.EventHandler(this.RadBtnSpaceNum_CheckedChanged);
            // 
            // RadBtn_PawnNum
            // 
            this.RadBtn_PawnNum.AutoSize = true;
            this.RadBtn_PawnNum.Enabled = false;
            this.RadBtn_PawnNum.Location = new System.Drawing.Point(22, 40);
            this.RadBtn_PawnNum.Margin = new System.Windows.Forms.Padding(1);
            this.RadBtn_PawnNum.Name = "radBtnPawnNum";
            this.RadBtn_PawnNum.Size = new System.Drawing.Size(62, 17);
            this.RadBtn_PawnNum.TabIndex = 9;
            this.RadBtn_PawnNum.TabStop = true;
            this.RadBtn_PawnNum.Text = "Pawn #";
            this.RadBtn_PawnNum.UseVisualStyleBackColor = true;
            this.RadBtn_PawnNum.CheckedChanged += new System.EventHandler(this.RadBtnPawnNum_CheckedChanged);
            // 
            // ChkBox_SpaceInfo
            // 
            this.ChkBox_SpaceInfo.AutoSize = true;
            this.ChkBox_SpaceInfo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChkBox_SpaceInfo.Location = new System.Drawing.Point(6, 19);
            this.ChkBox_SpaceInfo.Name = "chkBoxSpaceInfo";
            this.ChkBox_SpaceInfo.Size = new System.Drawing.Size(59, 17);
            this.ChkBox_SpaceInfo.TabIndex = 8;
            this.ChkBox_SpaceInfo.Text = "Enable";
            this.ChkBox_SpaceInfo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ChkBox_SpaceInfo.UseVisualStyleBackColor = true;
            this.ChkBox_SpaceInfo.Click += new System.EventHandler(this.ChkBoxSpaceInfo_Clicked);
            // 
            // GrpBox_ForcePlayer
            // 
            this.GrpBox_ForcePlayer.Controls.Add(this.ChkBox_LockPlyr);
            this.GrpBox_ForcePlayer.Controls.Add(this.RadBtn_PlyrNone);
            this.GrpBox_ForcePlayer.Controls.Add(this.Lbl_ForceCard);
            this.GrpBox_ForcePlayer.Controls.Add(this.RadBtn_PlyrThree);
            this.GrpBox_ForcePlayer.Controls.Add(this.RadBtn_PlyrOne);
            this.GrpBox_ForcePlayer.Controls.Add(this.RadBtn_PlyrFour);
            this.GrpBox_ForcePlayer.Controls.Add(this.RadBtn_PlyrTwo);
            this.GrpBox_ForcePlayer.Location = new System.Drawing.Point(251, 78);
            this.GrpBox_ForcePlayer.Name = "GrpBoxForcePlayer";
            this.GrpBox_ForcePlayer.Size = new System.Drawing.Size(145, 90);
            this.GrpBox_ForcePlayer.TabIndex = 18;
            this.GrpBox_ForcePlayer.TabStop = false;
            this.GrpBox_ForcePlayer.Text = "Force Player";
            // 
            // ChkBox_LockPlyr
            // 
            this.ChkBox_LockPlyr.AutoSize = true;
            this.ChkBox_LockPlyr.Location = new System.Drawing.Point(9, 70);
            this.ChkBox_LockPlyr.Margin = new System.Windows.Forms.Padding(0);
            this.ChkBox_LockPlyr.Name = "ChkBoxLockPlyr";
            this.ChkBox_LockPlyr.Size = new System.Drawing.Size(50, 17);
            this.ChkBox_LockPlyr.TabIndex = 20;
            this.ChkBox_LockPlyr.Text = "Lock";
            this.ChkBox_LockPlyr.UseVisualStyleBackColor = true;
            this.ChkBox_LockPlyr.CheckedChanged += new System.EventHandler(this.ChkBoxLockPlyr_CheckedChanged);
            // 
            // RadBtn_PlyrNone
            // 
            this.RadBtn_PlyrNone.AutoSize = true;
            this.RadBtn_PlyrNone.Checked = true;
            this.RadBtn_PlyrNone.Location = new System.Drawing.Point(91, 14);
            this.RadBtn_PlyrNone.Margin = new System.Windows.Forms.Padding(0);
            this.RadBtn_PlyrNone.Name = "RadBtnPlyrNone";
            this.RadBtn_PlyrNone.Size = new System.Drawing.Size(51, 17);
            this.RadBtn_PlyrNone.TabIndex = 19;
            this.RadBtn_PlyrNone.TabStop = true;
            this.RadBtn_PlyrNone.Text = "None";
            this.RadBtn_PlyrNone.UseVisualStyleBackColor = true;
            this.RadBtn_PlyrNone.CheckedChanged += new System.EventHandler(this.RadBtnPlyrNone_CheckedChanged);
            // 
            // Lbl_ForceCard
            // 
            this.Lbl_ForceCard.AutoSize = true;
            this.Lbl_ForceCard.Location = new System.Drawing.Point(6, 16);
            this.Lbl_ForceCard.Name = "label1";
            this.Lbl_ForceCard.Size = new System.Drawing.Size(86, 13);
            this.Lbl_ForceCard.TabIndex = 4;
            this.Lbl_ForceCard.Text = "Choose a player:";
            // 
            // RadBtn_PlyrFour
            // 
            this.RadBtn_PlyrFour.AutoSize = true;
            this.RadBtn_PlyrFour.Location = new System.Drawing.Point(9, 49);
            this.RadBtn_PlyrFour.Margin = new System.Windows.Forms.Padding(0);
            this.RadBtn_PlyrFour.Name = "RadBtnPlyrFour";
            this.RadBtn_PlyrFour.Size = new System.Drawing.Size(54, 17);
            this.RadBtn_PlyrFour.TabIndex = 3;
            this.RadBtn_PlyrFour.TabStop = true;
            this.RadBtn_PlyrFour.Text = "Green";
            this.RadBtn_PlyrFour.UseVisualStyleBackColor = true;
            this.RadBtn_PlyrFour.CheckedChanged += new System.EventHandler(this.RadBtnPlyrGreen_CheckedChanged);
            // 
            // RadBtn_PlyrThree
            // 
            this.RadBtn_PlyrThree.AutoSize = true;
            this.RadBtn_PlyrThree.Location = new System.Drawing.Point(63, 49);
            this.RadBtn_PlyrThree.Margin = new System.Windows.Forms.Padding(0);
            this.RadBtn_PlyrThree.Name = "RadBtnPlyrThree";
            this.RadBtn_PlyrThree.Size = new System.Drawing.Size(56, 17);
            this.RadBtn_PlyrThree.TabIndex = 2;
            this.RadBtn_PlyrThree.TabStop = true;
            this.RadBtn_PlyrThree.Text = "Yellow";
            this.RadBtn_PlyrThree.UseVisualStyleBackColor = true;
            this.RadBtn_PlyrThree.CheckedChanged += new System.EventHandler(this.RadBtnPlyrYellow_CheckedChanged);
            // 
            // RadBtn_PlyrOne
            // 
            this.RadBtn_PlyrOne.AutoSize = true;
            this.RadBtn_PlyrOne.Location = new System.Drawing.Point(9, 32);
            this.RadBtn_PlyrOne.Margin = new System.Windows.Forms.Padding(0);
            this.RadBtn_PlyrOne.Name = "RadBtnPlyrOne";
            this.RadBtn_PlyrOne.Size = new System.Drawing.Size(45, 17);
            this.RadBtn_PlyrOne.TabIndex = 0;
            this.RadBtn_PlyrOne.TabStop = true;
            this.RadBtn_PlyrOne.Text = "Red";
            this.RadBtn_PlyrOne.UseVisualStyleBackColor = true;
            this.RadBtn_PlyrOne.CheckedChanged += new System.EventHandler(this.RadBtnPlyrRed_CheckedChanged);
            // 
            // RadBtn_PlyrTwo
            // 
            this.RadBtn_PlyrTwo.AutoSize = true;
            this.RadBtn_PlyrTwo.Location = new System.Drawing.Point(63, 32);
            this.RadBtn_PlyrTwo.Margin = new System.Windows.Forms.Padding(0);
            this.RadBtn_PlyrTwo.Name = "RadBtnPlyrTwo";
            this.RadBtn_PlyrTwo.Size = new System.Drawing.Size(46, 17);
            this.RadBtn_PlyrTwo.TabIndex = 1;
            this.RadBtn_PlyrTwo.TabStop = true;
            this.RadBtn_PlyrTwo.Text = "Blue";
            this.RadBtn_PlyrTwo.UseVisualStyleBackColor = true;
            this.RadBtn_PlyrTwo.CheckedChanged += new System.EventHandler(this.RadBtnPlyrBlue_CheckedChanged);
            // 
            // SorryDebugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 279);
            this.ControlBox = false;
            this.Controls.Add(this.GrpBox_ForcePlayer);
            this.Controls.Add(this.GrpBox_ButtonDisp);
            this.Controls.Add(this.GrpBox_ForceCard);
            this.Controls.Add(this.Lbl_PawnLoc);
            this.Controls.Add(this.Lbl_DebugMoveInfo);
            this.Controls.Add(this.Btn_Close);
            this.Name = "SorryDebugger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Debugger";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GrpBox_ForceCard.ResumeLayout(false);
            this.GrpBox_ForceCard.PerformLayout();
            this.GrpBox_ButtonDisp.ResumeLayout(false);
            this.GrpBox_ButtonDisp.PerformLayout();
            this.GrpBox_ForcePlayer.ResumeLayout(false);
            this.GrpBox_ForcePlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lbl_DebugMoveInfo;
        private System.Windows.Forms.Label Lbl_PawnLoc;
        private System.Windows.Forms.CheckBox ChkBox_LockCard;
        private System.Windows.Forms.GroupBox GrpBox_ForceCard;
        private System.Windows.Forms.GroupBox GrpBox_ButtonDisp;
        private System.Windows.Forms.RadioButton RadBtn_SpaceNum;
        private System.Windows.Forms.RadioButton RadBtn_PawnNum;
        private System.Windows.Forms.ComboBox CmboBox_ForceCard;
        private System.Windows.Forms.CheckBox ChkBox_SpaceInfo;
        private System.Windows.Forms.GroupBox GrpBox_ForcePlayer;
        private System.Windows.Forms.RadioButton RadBtn_PlyrFour;
        private System.Windows.Forms.RadioButton RadBtn_PlyrThree;
        private System.Windows.Forms.RadioButton RadBtn_PlyrTwo;
        private System.Windows.Forms.RadioButton RadBtn_PlyrOne;
        private System.Windows.Forms.CheckBox ChkBox_LockPlyr;
        private System.Windows.Forms.RadioButton RadBtn_PlyrNone;
        private System.Windows.Forms.Label Lbl_ForceCard;
    }
}