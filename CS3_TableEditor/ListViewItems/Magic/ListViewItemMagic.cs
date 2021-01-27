using CS3_TableEditor.CS3Tables.Magic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CS3_TableEditor.ListViewItems.Magic {
    public abstract class ListViewItemMagic : ListViewItem {

        private short id;
        private bool forAltAttackMode;

        public ListViewItemMagic(MagicRecord record) {
            id = record.ID; forAltAttackMode = record.ForAltAttackMode;
        }

        public abstract void UpdateListViewItem(MagicRecord record);

        public bool CompareKey(short id, bool forAltAttackMode) {
            return this.id == id && this.forAltAttackMode == forAltAttackMode;
        }

    }
}
