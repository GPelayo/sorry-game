using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sorry {
    public partial class TitlePage : Form {
        string mainGameArg;

        public TitlePage() {
            mainGameArg = "normal";
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            MainGame newGame = new MainGame(mainGameArg);
            newGame.Show();
            newGame.Owner = this;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void objectiveToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            FormInstructions instruction = new FormInstructions();
            instruction.Show();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            FormRules rules = new FormRules();
            rules.Show();
        }

        private void theCardsToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Cards card = new Cards();
            card.Show();
        }

        private void TitlePage_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F12) {
                DialogPawnIntializeType queryStart = new DialogPawnIntializeType();
                queryStart.ShowDialog();
                mainGameArg = queryStart.GetOutput();

                button1_Click(new Object(), new EventArgs());
            }
            mainGameArg = "normal";
        }
    }
}
