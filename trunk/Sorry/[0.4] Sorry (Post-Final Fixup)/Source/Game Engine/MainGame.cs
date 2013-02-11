using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sorry {
    public partial class MainGame : Form {
        private void Space_Click(object sender, EventArgs e) {
            Space clickedBttn = (Space)sender;

            if (secondPawnMode || secondSpaceMode)
                chosenSpace2 = clickedBttn.IdNumber;
            else
                chosenSpace = clickedBttn.IdNumber;

            RunPlayersPhase();
        }

        private void BtnSkip_Click(object sender, EventArgs e) {
            CancelTurn(true);
        }

        private void BtnCancelMove_Click(object sender, EventArgs e) {
            ResetBoardDisplay();
            CancelTurn(false);
            Btn_CancelMove.Enabled = false;
        }

        private void MainGame_FormClosed(object sender, FormClosedEventArgs e) {
                this.Owner.Show();
                bugChecker.Close();
        }

        private void MainGame_Activated(object sender, EventArgs e) {
            //GetDebuggerData();
            //UpdateDebugger();
        }

        private void KeyboardShorcuts(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F12) {
                bugChecker.Location = new Point(this.Size.Width, 0);
                bugChecker.Show();
                bugChecker.Activate();
            }
            else if (e.KeyCode == Keys.Escape) {
                if(Btn_CancelMove.Enabled)
                    BtnCancelMove_Click(new object(), new EventArgs());
            }
        }
    }
}