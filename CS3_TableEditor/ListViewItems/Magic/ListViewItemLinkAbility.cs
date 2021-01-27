using CS3_TableEditor.CS3Tables.Magic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CS3_TableEditor.ListViewItems.Magic {
    public class ListViewItemLinkAbility : ListViewItemMagic {

        public static void SetupHeaders(ListView listView) {
            listView.Clear();
            listView.Columns.Add("Name", 9 * listView.Width / 20 - 22, HorizontalAlignment.Left);
            listView.Columns.Add("Targeting Type", 2 * listView.Width / 20 - 20, HorizontalAlignment.Left);
        }

        public ListViewItemLinkAbility(MagicRecord record) : base(record) {
            SubItems.Add("");
            SubItems.Add("");
            UpdateListViewItem(record);
        }

        public override void UpdateListViewItem(MagicRecord record) {
            SubItems[0].Text = record.Name;
            SubItems[1].Text = record.TargetingType;
        }

    }
}
