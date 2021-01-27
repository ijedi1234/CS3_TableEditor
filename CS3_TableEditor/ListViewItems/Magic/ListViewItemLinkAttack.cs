using CS3_TableEditor.CS3Tables.Magic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CS3_TableEditor.ListViewItems.Magic {
    public class ListViewItemLinkAttack : ListViewItemMagic {

        public static void SetupHeaders(ListView listView) {
            listView.Clear();
            listView.Columns.Add("Name", listView.Width - 22, HorizontalAlignment.Left);
        }

        public ListViewItemLinkAttack(MagicRecord record) : base(record) {
            SubItems.Add("");
            UpdateListViewItem(record);
        }

        public override void UpdateListViewItem(MagicRecord record) {
            SubItems[0].Text = record.Name;
        }

    }
}
