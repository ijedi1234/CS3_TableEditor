using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CS3_TableEditor.CS3Tables.Magic.StatusEffects;
using System.Linq;

namespace CS3_TableEditor.MagicRecordFormLogic {
    public class StatusEffectGroupBoxCollection<T> where T: StatusEffect {

        private List<StatusEffectGroupBoxContents> contents;
        public List<T> StatusEffects { get; set; }
        private Button statusEffectCreateNewBtn;
        private ToolTip toolTip;

        public StatusEffectGroupBoxCollection(List<T> statusEffects, ToolTip statusEffectTooltip, Button statusEffectCreateNewBtn,
            List<StatusEffectGroupBoxContents> existingList) {
            StatusEffects = statusEffects;
            this.statusEffectCreateNewBtn = statusEffectCreateNewBtn;
            contents = existingList;
            toolTip = statusEffectTooltip;
            CalculateGroupBoxContents();
        }

        public void MoveLeft(int index) {
            T statusEffect = StatusEffects[index];
            StatusEffects.RemoveAt(index);
            int destIndex;
            if(index == 0) {
                destIndex = contents.Where(i => i.GroupBox.Enabled).Count() - 1;
            } else {
                destIndex = index - 1;
            }
            StatusEffects.Insert(destIndex, statusEffect);
            CalculateGroupBoxContents();
        }

        public void MoveRight(int index) {
            T statusEffect = StatusEffects[index];
            StatusEffects.RemoveAt(index);
            int destIndex;
            if (index == contents.Where(i => i.GroupBox.Enabled).Count() - 1) {
                destIndex = 0;
            } else {
                destIndex = index + 1;
            }
            StatusEffects.Insert(destIndex, statusEffect);
            CalculateGroupBoxContents();
        }

        public void ZeroStatusEffectsWithNullID() {
            for (int i = 0; i < contents.Count; i++) {
                if (StatusEffects[i].GetID() == 0) {
                    StatusEffects[i].Argument1 = 0;
                    StatusEffects[i].Argument2 = 0;
                    StatusEffects[i].Argument3 = 0;
                }
            }
            List<T> statusEffectsNull = StatusEffects.Where(i => i.GetID() == 0).ToList();
            StatusEffects = StatusEffects.Where(i => i.GetID() != 0).ToList();
            StatusEffects.AddRange(statusEffectsNull);
        }

        public void CalculateGroupBoxContents() {
            statusEffectCreateNewBtn.Enabled = false;
            ZeroStatusEffectsWithNullID();
            for (int i = 0; i < contents.Count; i++) {
                if (StatusEffects[i].GetID() == 0) {
                    statusEffectCreateNewBtn.Enabled = true;
                    contents[i].IDBox.Text = "";
                    contents[i].GroupBox.Enabled = false;
                    continue;
                } else {
                    contents[i].GroupBox.Enabled = true;
                }
                contents[i].IDBox.Text = (StatusEffects[i].GetID()).ToString();
                toolTip.SetToolTip(contents[i].IDBox, StatusEffects[i].GetIDString());
            }
        }

    }
}
