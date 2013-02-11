using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sorry {
    public partial class FormMoveQuery : Form {
        public bool willBump;
        public bool willSwitch;

        public FormMoveQuery() {
            willBump = true;
            willSwitch = true;
            InitializeComponent();
        }

        private void RadBtn_Chc1_CheckedChanged(object sender, EventArgs e) {
            willSwitch = RadBtnChc1.Checked;
        }

        private void RadBtn_Chc2_CheckedChanged(object sender, EventArgs e) {
            willBump = RadBtnChc2.Checked;
        }

        private void Btn_OK_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
