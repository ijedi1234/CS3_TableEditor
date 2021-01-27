using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CS3_TableEditor.CS3Tables.Magic.StatusEffects;
using System.Linq;

namespace CS3_TableEditor.MagicRecordFormLogic {
    public class BOStatusEffectGroupBoxCollection {

        private List<StatusEffectGroupBoxContents> contents;
        private List<BraveOrderEffect> statusEffects;
        private Button statusEffectCreateNewBtn;
        private ToolTip toolTip;

        public BOStatusEffectGroupBoxCollection(List<BraveOrderEffect> statusEffects, ToolTip statusEffectTooltip, Button statusEffectCreateNewBtn,
            List<StatusEffectGroupBoxContents> existingList) {
            this.statusEffects = statusEffects;
            this.statusEffectCreateNewBtn = statusEffectCreateNewBtn;
            contents = existingList;
            toolTip = statusEffectTooltip;
            CalculateGroupBoxContents();
        }

        public void MoveLeft(int index) {
            BraveOrderEffect statusEffect = statusEffects[index];
            statusEffects.RemoveAt(index);
            int destIndex;
            if(index == 0) {
                destIndex = contents.Where(i => i.GroupBox.Enabled).Count() - 1;
            } else {
                destIndex = index - 1;
            }
            statusEffects.Insert(destIndex, statusEffect);
            CalculateGroupBoxContents();
        }

        public void MoveRight(int index) {
            BraveOrderEffect statusEffect = statusEffects[index];
            statusEffects.RemoveAt(index);
            int destIndex;
            if (index == contents.Where(i => i.GroupBox.Enabled).Count() - 1) {
                destIndex = 0;
            } else {
                destIndex = index + 1;
            }
            statusEffects.Insert(destIndex, statusEffect);
            CalculateGroupBoxContents();
        }

        public void ZeroStatusEffectsWithNullID() {
            for (int i = 0; i < contents.Count; i++) {
                if (statusEffects[i].Id == 0) {
                    statusEffects[i].Argument1 = 0;
                    statusEffects[i].Argument2 = 0;
                    statusEffects[i].Argument3 = 0;
                }
            }
        }

        public void CalculateGroupBoxContents() {
            statusEffectCreateNewBtn.Enabled = false;
            ZeroStatusEffectsWithNullID();
            for (int i = 0; i < contents.Count; i++) {
                if (statusEffects[i].Id == 0) {
                    statusEffectCreateNewBtn.Enabled = true;
                    contents[i].IDBox.Text = "";
                    contents[i].GroupBox.Enabled = false;
                    continue;
                } else {
                    contents[i].GroupBox.Enabled = true;
                }
                contents[i].IDBox.Text = ((short)statusEffects[i].Id).ToString();
                toolTip.SetToolTip(contents[i].IDBox, statusEffects[i].Id.ToString());
            }
        }

    }
}
