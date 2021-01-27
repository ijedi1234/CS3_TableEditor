using CS3_TableEditor.CS3Tables.Magic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace CS3_TableEditor.ListViewItems.Magic {
    public class ListViewItemCraft : ListViewItemMagic {

        public static void SetupHeaders(ListView listView) {
            listView.Clear();
            listView.Columns.Add("Name", 1 * listView.Width / 10, HorizontalAlignment.Left);
            listView.Columns.Add("Targeting Type", 3 * listView.Width / 20, HorizontalAlignment.Left);
            listView.Columns.Add("Owner", listView.Width / 10, HorizontalAlignment.Left);
            listView.Columns.Add("Description", 5 * listView.Width / 10, HorizontalAlignment.Left);
            listView.Columns.Add("Cost", listView.Width / 20, HorizontalAlignment.Left);
            listView.Columns.Add("Alt Attack", listView.Width / 10 - 20, HorizontalAlignment.Left);
        }

        public ListViewItemCraft(MagicRecord record) : base(record) {
            SubItems.Add("");
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
            SubItems[2].Text = record.OwnerID.ToString();
            SubItems[3].Text = record.Description2ndLine;
            SubItems[4].Text = record.Cost.ToString();
            SubItems[5].Text = record.IsForAltAttackMode().ToString();
        }

    }
}
