using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sorry {
    public partial class SorryDebugger : Form {
        bool pawnIndexDisplayOn, spaceIndexDisplayOn, forceCardOn, lockFrcCrdOn, forcePlayerOn, lockPlyrOn;
        int forceCardIndex, forcePlayerIndex;

        public SorryDebugger() {
            forceCardOn = false;
            lockFrcCrdOn = false;
            lockPlyrOn = false;
            pawnIndexDisplayOn = false;
            spaceIndexDisplayOn = false;
            InitializeComponent();
            forceCardIndex = 0;
            forcePlayerIndex = 0;
        }

        public bool IsPawnInfoOn {
            get { return pawnIndexDisplayOn; }
        }

        public bool IsSpaceInfoOn {
            get { return spaceIndexDisplayOn; }
        }

        public bool ForcedCardIsOn {
            get { return forceCardOn; }
        }

        public bool ForcedPlayerIsOn {
            get { return forcePlayerOn; }
        }

        public int ForcedCard {
            get {
                if (!lockFrcCrdOn) {
                    CmboBox_ForceCard.Text = "Choose a Card...";
                    forceCardOn = false;
                }
                return forceCardIndex;
            }
        }

        public int ForcedPlayer {
            get {
                if (!lockPlyrOn) {
                    lockPlyrOn = false;
                    RadBtn_PlyrNone.Checked = true;
                }
                return forcePlayerIndex;
            }
        }

        public void MoveInfoDisplay(string card, string player, string pawn, string newSpace, string lastSpace, string frstmode,
                                    string scndPawnMode, string scndSpaceMode, string newSpace2, string scndPawn, string lastSpace2) {
            string playerString = "Null";
            
            switch (player) {
            case "0":
                playerString = "Red";
                break;
            case "1":
                playerString = "Blue";
                break;
            case "2":
                playerString = "Yellow";
                break;
            case "3":
                playerString = "Green";
                break;
            }

            Lbl_DebugMoveInfo.Text = "Move Info:";
            Lbl_DebugMoveInfo.Text += "\n\tPicked Card: " + card;
            Lbl_DebugMoveInfo.Text += "\n\tPlayer: " + playerString;
            Lbl_DebugMoveInfo.Text += "\n\tChosen Pawn: " + pawn;
            Lbl_DebugMoveInfo.Text += "\n\tChosen Space:" + newSpace;
            Lbl_DebugMoveInfo.Text += "\n\tPrevious Space:" + lastSpace;
            Lbl_DebugMoveInfo.Text += "\n\tIsSpaceMode: " + frstmode;
            Lbl_DebugMoveInfo.Text += "\n\tIsSecondPawnMode: " + scndPawnMode;
            Lbl_DebugMoveInfo.Text += "\n\tIsSecondSpaceMode: " + scndSpaceMode;

            if (scndPawnMode == "true") {
                Lbl_DebugMoveInfo.Text += "\n\t2nd Chosen Pawn: " + scndPawn;
                Lbl_DebugMoveInfo.Text += "\n\t2nd Chosen Space: " + newSpace2;
                Lbl_DebugMoveInfo.Text += "\n\t2nd Previous Space: " + frstmode;
            }
        }

        public void PawnLocationDisplay(int[] pawnIndexes) {
            Lbl_PawnLoc.Text = "Pawn Locations";
            for (int i = 0; i < pawnIndexes.Length; i++)
                Lbl_PawnLoc.Text += "\n\tPawn " + i.ToString() + ": " + pawnIndexes[i];
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void ChkBoxSpaceInfo_Clicked(object sender, EventArgs e) {
            RadBtn_PawnNum.Enabled = ChkBox_SpaceInfo.Checked;
            RadBtn_PawnNum.Checked = false;
            RadBtn_SpaceNum.Enabled = ChkBox_SpaceInfo.Checked;
            RadBtn_SpaceNum.Checked = false;
        }

        private void ChkBoxLock_Clicked(object sender, EventArgs e) {
            lockFrcCrdOn = ChkBox_LockCard.Checked;
        }

        private void CmboBoxForceCard_SelectedIndexChanged(object sender, EventArgs e) {
            forceCardOn = true;

            string selectedCard = CmboBox_ForceCard.Text;

            switch (selectedCard) {
            case "[1-Card]":
                forceCardIndex = 0;
                break;
            case "[2-Card]":
                forceCardIndex = 1;
                break;
            case "[3-Card]":
                forceCardIndex = 2;
                break;
            case "[4-Card]":
                forceCardIndex = 3;
                break;
            case "[5-Card]":
                forceCardIndex = 4;
                break;
            case "[7-Card]":
                forceCardIndex = 5;
                break;
            case "[8-Card]":
                forceCardIndex = 6;
                break;
            case "[10-Card]":
                forceCardIndex = 7;
                break;
            case "[11-Card]":
                forceCardIndex = 8;
                break;
            case "[12-Card]":
                forceCardIndex = 9;
                break;
            case "[Sorry Card]":
                forceCardIndex = 10;
                break;
            default:
                forceCardOn = false;
                break;
            }

            ChkBox_LockCard.Enabled = forceCardOn;
        }

        private void RadBtnPawnNum_CheckedChanged(object sender, EventArgs e) {
            pawnIndexDisplayOn = RadBtn_PawnNum.Checked;
        }

        private void RadBtnSpaceNum_CheckedChanged(object sender, EventArgs e) {
            spaceIndexDisplayOn = RadBtn_SpaceNum.Checked;
        }

        private void RadBtnPlyrRed_CheckedChanged(object sender, EventArgs e) {
            forcePlayerIndex = 1;
        }

        private void RadBtnPlyrBlue_CheckedChanged(object sender, EventArgs e) {
            forcePlayerIndex = 2;
        }

        private void RadBtnPlyrYellow_CheckedChanged(object sender, EventArgs e) {
            forcePlayerIndex = 3;
        }

        private void RadBtnPlyrGreen_CheckedChanged(object sender, EventArgs e) {
            forcePlayerIndex = 4;
        }

        private void RadBtnPlyrNone_CheckedChanged(object sender, EventArgs e) {
           forcePlayerOn = !RadBtn_PlyrNone.Checked;
           ChkBox_LockPlyr.Enabled = !RadBtn_PlyrNone.Checked;
        }

        private void ChkBoxLockPlyr_CheckedChanged(object sender, EventArgs e) {
            lockPlyrOn = ChkBox_LockPlyr.Checked;
        }
    }
}