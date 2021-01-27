using CS3_TableEditor.CS3Tables.Magic;
using CS3_TableEditor.CS3Tables.Magic.StatusEffects;
using CS3_TableEditor.MagicRecordFormLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace CS3_TableEditor.Forms {
    public partial class MagicStatusEffectsForm : Form {

        private MagicRecord magicRecord;
        private MagicboRecord magicboRecord;

        private StatusEffectGroupBoxCollection<RegStatusEffect> regStatusEffectGroupBoxCollection;
        private StatusEffectGroupBoxCollection<BraveOrderEffect> boStatusEffectGroupBoxCollection;

        public MagicStatusEffectsForm(MagicRecord magicRecord) {
            this.magicRecord = magicRecord; magicboRecord = magicRecord.MagicboRecord;
            List<RegStatusEffect> regStatusEffects = magicRecord.StatusEffects.Select(i => new RegStatusEffect(i.ToBytes())).ToList();
            List<BraveOrderEffect> boStatusEffects = null;
            InitializeComponent();

            List<StatusEffectGroupBoxContents> regCollection = new List<StatusEffectGroupBoxContents> {
                new StatusEffectGroupBoxContents(RegStatusEffect1GroupBox, RegStatusEffect1TextBox),
                new StatusEffectGroupBoxContents(RegStatusEffect2GroupBox, RegStatusEffect2TextBox),
                new StatusEffectGroupBoxContents(RegStatusEffect3GroupBox, RegStatusEffect3TextBox),
                new StatusEffectGroupBoxContents(RegStatusEffect4GroupBox, RegStatusEffect4TextBox),
                new StatusEffectGroupBoxContents(RegStatusEffect5GroupBox, RegStatusEffect5TextBox)
            };
            StatusEffectModifySection regModifySection = new StatusEffectModifySection() {
                strBox = RegStatusEffectID_StrBox,
                numBox = RegStatusEffectID_NumBox,
                arg1Box = RegStatusEffectArg1Box,
                arg2Box = RegStatusEffectArg2Box,
                arg3Box = RegStatusEffectArg3Box
            };
            RegStatusEffectType[] regStatusEffectTypesArray = (RegStatusEffectType[])Enum.GetValues(typeof(RegStatusEffectType));
            Dictionary<short, string> statusEffectTypes = regStatusEffectTypesArray.OrderBy(i => i.ToString()).ToDictionary(i => (short)i, i => i.ToString());
            //RegStatusEffectID_StrBox.SelectedIndexChanged -= RegStatusEffectID_StrBoxItemChanged;
            regStatusEffectGroupBoxCollection = 
                new StatusEffectGroupBoxCollection<RegStatusEffect>(regStatusEffects, StatusEffectTooltip, RegStatusEffectsNewBtn, regCollection,
                regModifySection, statusEffectTypes);
            //RegStatusEffectID_StrBox.SelectedIndexChanged += RegStatusEffectID_StrBoxItemChanged;

            if (magicboRecord != null)
                boStatusEffects = magicboRecord.BraveOrderEffects.Select(i => new BraveOrderEffect(i.ToBytes())).ToList();
            if (boStatusEffects == null) {
                BOStatusEffectsGroupBox.Enabled = false; return;
            }

            List<StatusEffectGroupBoxContents> boCollection = new List<StatusEffectGroupBoxContents> {
                new StatusEffectGroupBoxContents(BOStatusEffect1GroupBox, BOStatusEffect1TextBox),
                new StatusEffectGroupBoxContents(BOStatusEffect2GroupBox, BOStatusEffect2TextBox),
                new StatusEffectGroupBoxContents(BOStatusEffect3GroupBox, BOStatusEffect3TextBox),
                new StatusEffectGroupBoxContents(BOStatusEffect4GroupBox, BOStatusEffect4TextBox),
                new StatusEffectGroupBoxContents(BOStatusEffect5GroupBox, BOStatusEffect5TextBox),
            };
            StatusEffectModifySection boModifySection = new StatusEffectModifySection() {
                strBox = BOStatusEffectID_StrBox,
                numBox = BOStatusEffectID_NumBox,
                arg1Box = BOStatusEffectArg1Box,
                arg2Box = BOStatusEffectArg2Box,
                arg3Box = BOStatusEffectArg3Box
            };
            BraveOrderEffectType[] boStatusEffectTypesArray = (BraveOrderEffectType[])Enum.GetValues(typeof(BraveOrderEffectType));
            statusEffectTypes = boStatusEffectTypesArray.OrderBy(i => i.ToString()).ToDictionary(i => (short)i, i => i.ToString());
            BOStatusEffectID_StrBox.SelectedIndexChanged -= BOStatusEffectID_StrBoxItemChanged;
            boStatusEffectGroupBoxCollection = 
                new StatusEffectGroupBoxCollection<BraveOrderEffect>(boStatusEffects, StatusEffectTooltip, BOStatusEffectsNewBtn, boCollection,
                boModifySection, statusEffectTypes);
            BOStatusEffectID_StrBox.SelectedIndexChanged += BOStatusEffectID_StrBoxItemChanged;
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            magicRecord.StatusEffects = regStatusEffectGroupBoxCollection.StatusEffects;
            if (magicboRecord != null) {
                magicboRecord.BraveOrderEffects = boStatusEffectGroupBoxCollection.StatusEffects;
            }
            Close();
        }

        #region Capturing Event Handlers

        private void RegStatusEffect1ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(true, 0); }
        private void RegStatusEffect2ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(true, 1); }
        private void RegStatusEffect3ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(true, 2); }
        private void RegStatusEffect4ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(true, 3); }
        private void RegStatusEffect5ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(true, 4); }

        private void BOStatusEffect1ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(false, 0); }
        private void BOStatusEffect2ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(false, 1); }
        private void BOStatusEffect3ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(false, 2); }
        private void BOStatusEffect4ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(false, 3); }
        private void BOStatusEffect5ModifyBtn_Click(object sender, EventArgs e) { StatusEffectModifyBtn_Click(false, 4); }

        private void RegStatusEffect1MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, true, 0); }
        private void RegStatusEffect1MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, false, 0); }
        private void RegStatusEffect2MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, true, 1); }
        private void RegStatusEffect2MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, false, 1); }
        private void RegStatusEffect3MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, true, 2); }
        private void RegStatusEffect3MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, false, 2); }
        private void RegStatusEffect4MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, true, 3); }
        private void RegStatusEffect4MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, false, 3); }
        private void RegStatusEffect5MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, true, 4); }
        private void RegStatusEffect5MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(true, false, 4); }

        private void BOStatusEffect1MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, true, 0); }
        private void BOStatusEffect1MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, false, 0); }
        private void BOStatusEffect2MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, true, 1); }
        private void BOStatusEffect2MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, false, 1); }
        private void BOStatusEffect3MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, true, 2); }
        private void BOStatusEffect3MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, false, 2); }
        private void BOStatusEffect4MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, true, 3); }
        private void BOStatusEffect4MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, false, 3); }
        private void BOStatusEffect5MoveLeftBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, true, 4); }
        private void BOStatusEffect5MoveRightBtn_Click(object sender, EventArgs e) { StatusEffectMoveBtn_Click(false, false, 4); }

        private void RegStatusEffectID_StrBoxItemChanged(object sender, EventArgs e) { StatusEffectID_StrBoxItemChanged(true); }
        private void BOStatusEffectID_StrBoxItemChanged(object sender, EventArgs e) { StatusEffectID_StrBoxItemChanged(false); }

        #endregion

        private void StatusEffectID_StrBoxItemChanged(bool isReg) {
            if (isReg) {
                regStatusEffectGroupBoxCollection?.UpdateFormAfterModifyStrBoxChanged();
            } else {
                boStatusEffectGroupBoxCollection?.UpdateFormAfterModifyStrBoxChanged();
            }
        }

        private void StatusEffectModifyBtn_Click(bool isReg, int index) {
            if (isReg)
                regStatusEffectGroupBoxCollection.SwitchDisplayedStatusEffect(index);
            else
                boStatusEffectGroupBoxCollection.SwitchDisplayedStatusEffect(index);
        }

        private void StatusEffectMoveBtn_Click(bool isReg, bool moveLeft, int index) {
            if (isReg) {
                if(moveLeft)
                    regStatusEffectGroupBoxCollection.MoveLeft(index);
                else
                    regStatusEffectGroupBoxCollection.MoveRight(index);
            } else {
                if (moveLeft)
                    boStatusEffectGroupBoxCollection.MoveLeft(index);
                else
                    boStatusEffectGroupBoxCollection.MoveRight(index);
            }
        }

        private void RegStatusEffectsNewBtn_Click(object sender, EventArgs e) {
            int newIndex = regStatusEffectGroupBoxCollection.StatusEffects.Select(i => i.Id == 0).ToList().IndexOf(true);
            if (newIndex < 0) return;
            regStatusEffectGroupBoxCollection.SwitchDisplayedStatusEffect(newIndex);
        }

        private void BOStatusEffectsNewBtn_Click(object sender, EventArgs e) {
            int newIndex = boStatusEffectGroupBoxCollection.StatusEffects.Select(i => i.Id == 0).ToList().IndexOf(true);
            if (newIndex < 0) return;
            boStatusEffectGroupBoxCollection.SwitchDisplayedStatusEffect(newIndex);
        }
    }
}
