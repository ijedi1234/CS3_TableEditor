using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CS3_TableEditor.CS3Tables.Magic.StatusEffects;
using System.Linq;

namespace CS3_TableEditor.MagicRecordFormLogic {
    public class StatusEffectGroupBoxCollection<T> where T: StatusEffect {

        public List<T> StatusEffects { get; set; }

        private List<StatusEffectGroupBoxContents> contents;
        private Button statusEffectCreateNewBtn;
        private StatusEffectModifySection modifySection;
        private ToolTip toolTip;

        private T displayedStatusEffect;

        public StatusEffectGroupBoxCollection(List<T> statusEffects, ToolTip statusEffectTooltip, Button statusEffectCreateNewBtn,
            List<StatusEffectGroupBoxContents> existingList, StatusEffectModifySection modifySection, Dictionary<short, string> statusEffectTypes) {
            StatusEffects = statusEffects;

            modifySection.numBox.Minimum = short.MinValue;
            modifySection.numBox.Maximum = short.MaxValue;
            modifySection.strBox.DataSource = new BindingSource(statusEffectTypes, null);
            modifySection.strBox.DisplayMember = "Value";
            modifySection.strBox.ValueMember = "Key";
            modifySection.arg1Box.Minimum = int.MinValue;
            modifySection.arg1Box.Maximum = int.MaxValue;
            modifySection.arg2Box.Minimum = int.MinValue;
            modifySection.arg2Box.Maximum = int.MaxValue;
            modifySection.arg3Box.Minimum = int.MinValue;
            modifySection.arg3Box.Maximum = int.MaxValue;

            this.statusEffectCreateNewBtn = statusEffectCreateNewBtn;
            this.modifySection = modifySection;
            SwitchDisplayedStatusEffect(-1);
            contents = existingList;
            toolTip = statusEffectTooltip;
            MapStatusEffects2Contents();
            //CalculateGroupBoxContents();
        }

        public void SwitchDisplayedStatusEffect(int index) {
            SaveDisplayedStatusEffect();
            try {
                displayedStatusEffect = StatusEffects[index];
            } catch {
                displayedStatusEffect = null;
                SetModifySection(); return;
            }
            KeyValuePair<short, string> selectedKV = 
                new KeyValuePair<short, string>(displayedStatusEffect.GetID(), displayedStatusEffect.GetIDString());
            SetModifySection(selectedKV, displayedStatusEffect.GetID(), displayedStatusEffect.Argument1, displayedStatusEffect.Argument2,
                displayedStatusEffect.Argument3, true);
        }

        private void SetModifySection() {
            KeyValuePair<short, string> selectedKV = new KeyValuePair<short, string>(0, "NULL");
            SetModifySection(selectedKV, 0, 0, 0, 0, false);
        }

        private void SetModifySection(KeyValuePair<short, string> selectedKV, short id, int arg1, int arg2, int arg3, bool enableSection) {
            modifySection.strBox.SelectedItem = selectedKV;
            modifySection.strBox.Enabled = enableSection;
            modifySection.numBox.Value = id;
            modifySection.numBox.Enabled = enableSection;
            modifySection.arg1Box.Value = arg1;
            modifySection.arg1Box.Enabled = enableSection;
            modifySection.arg2Box.Value = arg2;
            modifySection.arg2Box.Enabled = enableSection;
            modifySection.arg3Box.Value = arg3;
            modifySection.arg3Box.Enabled = enableSection;
        }

        public void SaveDisplayedStatusEffect() {
            if (displayedStatusEffect == null) return;
            displayedStatusEffect.SetID((short)modifySection.numBox.Value);
            displayedStatusEffect.Argument1 = (int)modifySection.arg1Box.Value;
            displayedStatusEffect.Argument2 = (int)modifySection.arg2Box.Value;
            displayedStatusEffect.Argument3 = (int)modifySection.arg3Box.Value;
        }

        public void UpdateFormAfterModifyStrBoxChanged() {
            if (displayedStatusEffect == null) return;
            int contentsIndex = -1;
            for(int i = 0; i < StatusEffects.Count; i++) {
                T statusEffect = StatusEffects[i];
                if (statusEffect.UniqueID == displayedStatusEffect.UniqueID) {
                    contentsIndex = i; break;
                }
            }
            short id = ((KeyValuePair<short, string>)modifySection.strBox.SelectedItem).Key;
            StatusEffects[contentsIndex].SetID(id);
            modifySection.numBox.Value = id;
            if(id == 0)
                SwitchDisplayedStatusEffect(-1);
            MapStatusEffects2Contents();
        }

        private void MapStatusEffects2Contents() {
            statusEffectCreateNewBtn.Enabled = false;
            ZeroStatusEffectsWithNullID();
            ShiftNullStatusEffects();
            for (int i = 0; i < StatusEffects.Count; i++) {
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

        public void ZeroStatusEffectsWithNullID() {
            for (int i = 0; i < contents.Count; i++) {
                if (StatusEffects[i].GetID() == 0) {
                    StatusEffects[i].Argument1 = 0;
                    StatusEffects[i].Argument2 = 0;
                    StatusEffects[i].Argument3 = 0;
                }
            }
        }

        private void ShiftNullStatusEffects() {
            List<T> statusEffectsNull = StatusEffects.Where(i => i.GetID() == 0).ToList();
            StatusEffects = StatusEffects.Where(i => i.GetID() != 0).ToList();
            StatusEffects.AddRange(statusEffectsNull);
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
            MapStatusEffects2Contents();
            //CalculateGroupBoxContents();
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
            MapStatusEffects2Contents();
            //CalculateGroupBoxContents();
        }

    }
}
