using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sorry {
    public partial class DialogPawnIntializeType : Form {
        string output;
        
        public DialogPawnIntializeType() {
            InitializeComponent();
            output = "normal";
        }

        public string GetOutput() {
            return output;
        }

        private void BtnOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void RadBtnStart_CheckedChanged(object sender, EventArgs e) {
            output = "normal";
        }

        private void RadBtnGate_CheckedChanged(object sender, EventArgs e) {
            output = "front";
        }

        private void RadBtnSafe_CheckedChanged(object sender, EventArgs e) {
            output = "end";
        } 
    }
}
