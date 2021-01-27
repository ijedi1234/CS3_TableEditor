using CS3_TableEditor.CS3Tables.Magic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CS3_TableEditor.ListViewItems.Magic {
    public class ListViewItemSCraft : ListViewItemMagic {

        public static void SetupHeaders(ListView listView) {
            listView.Clear();
            listView.Columns.Add("Name", 2 * listView.Width / 10, HorizontalAlignment.Left);
            listView.Columns.Add("Targeting Type", 2 * listView.Width / 10, HorizontalAlignment.Left);
            listView.Columns.Add("Description", 6 * listView.Width / 10 - 20, HorizontalAlignment.Left);
        }

        public ListViewItemSCraft(MagicRecord record) : base(record) {
            SubItems.Add("");
            SubItems.Add("");
            SubItems.Add("");
            UpdateListViewItem(record);
        }

        public override void UpdateListViewItem(MagicRecord record) {
            SubItems[0].Text = record.Name;
            SubItems[1].Text = record.TargetingType;
            SubItems[2].Text = record.Description2ndLine;
        }

    }
}
