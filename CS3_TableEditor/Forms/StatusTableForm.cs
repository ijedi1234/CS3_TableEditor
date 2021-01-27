using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3_TableEditor.Forms {
    public partial class StatusTableForm : Form {
        public StatusTableForm() {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
