using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CS3_TableEditor.MagicRecordFormLogic {
    public class StatusEffectGroupBoxContents {

        public StatusEffectGroupBoxContents(GroupBox groupBox, TextBox idBox) {
            GroupBox = groupBox;
            IDBox = idBox;
        }

        public GroupBox GroupBox { get; set; }
        public TextBox IDBox { get; set; }

    }
}
