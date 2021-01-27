using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CS3_TableEditor.Forms {
    public partial class TableSelectForm : Form {

        private CS3TablesGroup cs3Tables;

        public TableSelectForm() {
            InitializeComponent();
            cs3Tables = new CS3TablesGroup();
        }

        private void MagicTableBtn_Click(object sender, EventArgs e) {
            FormCollection forms = Application.OpenForms;
            foreach(Form form in forms) {
                if (form is MagicTableForm) return;
            }
            MagicTableForm magicTableForm = new MagicTableForm(cs3Tables.GetMagicTable());
            magicTableForm.Show();
        }
    }
}
