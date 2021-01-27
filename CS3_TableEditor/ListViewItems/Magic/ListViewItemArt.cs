using CS3_TableEditor.CS3Tables.Magic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CS3_TableEditor.ListViewItems.Magic {
    public class ListViewItemArt : ListViewItemMagic {

        public static void SetupHeaders(ListView listView) {
            listView.Clear();
            listView.Columns.Add("Name", listView.Width / 10, HorizontalAlignment.Left);
            listView.Columns.Add("Targeting Type", 3 * listView.Width / 20, HorizontalAlignment.Left);
            listView.Columns.Add("Element", listView.Width / 10, HorizontalAlignment.Left);
            listView.Columns.Add("Description", listView.Width / 2, HorizontalAlignment.Left);
            listView.Columns.Add("Cost", 3 * listView.Width / 20 - 20, HorizontalAlignment.Left);
        }

        public ListViewItemArt(MagicRecord record) : base(record) {
            SubItems.Add("");
            SubItems.Add("");
            SubItems.Add("");
            SubItems.Add("");
            SubItems.Add("");
            UpdateListViewItem(record);
        }

        public override void UpdateListViewItem(MagicRecord record) {
            SubItems[0].Text = record.Name;
            SubItems[1].Text = record.TargetingType;
            SubItems[2].Text = record.Element.ToString();
            SubItems[3].Text = record.Description2ndLine;
            SubItems[4].Text = record.Cost.ToString();
        }

    }
}
