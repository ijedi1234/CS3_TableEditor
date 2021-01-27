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

        private RegStatusEffectGroupBoxCollection regStatusEffectGroupBoxCollection;
        private List<RegStatusEffect> regStatusEffects;
        private BOStatusEffectGroupBoxCollection boStatusEffectGroupBoxCollection;
        private List<BraveOrderEffect> boStatusEffects;

        private int currentIndexDisplayedReg;
        private int currentIndexDisplayedBO;

        public MagicStatusEffectsForm(MagicRecord magicRecord) {
            this.magicRecord = magicRecord; magicboRecord = magicRecord.MagicboRecord;
            regStatusEffects = magicRecord.StatusEffects.Select(i => new RegStatusEffect(i.ToBytes())).ToList();
            if(magicboRecord != null)
                boStatusEffects = magicboRecord.BraveOrderEffects.Select(i => new BraveOrderEffect(i.ToBytes())).ToList();
            currentIndexDisplayedBO = -1;
            InitializeComponent();

            List<StatusEffectGroupBoxContents> regCollection = new List<StatusEffectGroupBoxContents> {
                new StatusEffectGroupBoxContents(RegStatusEffect1GroupBox, RegStatusEffect1TextBox),
                new StatusEffectGroupBoxContents(RegStatusEffect2GroupBox, RegStatusEffect2TextBox),
                new StatusEffectGroupBoxContents(RegStatusEffect3GroupBox, RegStatusEffect3TextBox),
                new StatusEffectGroupBoxContents(RegStatusEffect4GroupBox, RegStatusEffect4TextBox),
                new StatusEffectGroupBoxContents(RegStatusEffect5GroupBox, RegStatusEffect5TextBox)
            };
            regStatusEffectGroupBoxCollection = new RegStatusEffectGroupBoxCollection(regStatusEffects, StatusEffectTooltip, RegStatusEffectsNewBtn, regCollection);
            RegStatusEffectID_NumBox.Minimum = short.MinValue;
            RegStatusEffectID_NumBox.Maximum = short.MaxValue;
            RegStatusEffectType[] regStatusEffectTypesArray = (RegStatusEffectType[])Enum.GetValues(typeof(RegStatusEffectType));
            List<RegStatusEffectType> statusEffectTypes = regStatusEffectTypesArray.OrderBy(i => i.ToString()).ToList();
            RegStatusEffectID_StrBox.DataSource = statusEffectTypes;
            RegStatusEffectArg1Box.Minimum = int.MinValue;
            RegStatusEffectArg1Box.Maximum = int.MaxValue;
            RegStatusEffectArg2Box.Minimum = int.MinValue;
            RegStatusEffectArg2Box.Maximum = int.MaxValue;
            RegStatusEffectArg3Box.Minimum = int.MinValue;
            RegStatusEffectArg3Box.Maximum = int.MaxValue;
            DisableRegModifySection();

            if(boStatusEffects == null) {
                BOStatusEffectsGroupBox.Enabled = false; return;
            }

            List<StatusEffectGroupBoxContents> boCollection = new List<StatusEffectGroupBoxContents> {
                new StatusEffectGroupBoxContents(BOStatusEffect1GroupBox, BOStatusEffect1TextBox),
                new StatusEffectGroupBoxContents(BOStatusEffect2GroupBox, BOStatusEffect2TextBox),
                new StatusEffectGroupBoxContents(BOStatusEffect3GroupBox, BOStatusEffect3TextBox),
                new StatusEffectGroupBoxContents(BOStatusEffect4GroupBox, BOStatusEffect4TextBox),
                new StatusEffectGroupBoxContents(BOStatusEffect5GroupBox, BOStatusEffect5TextBox),
            };
            boStatusEffectGroupBoxCollection = new BOStatusEffectGroupBoxCollection(boStatusEffects, StatusEffectTooltip, BOStatusEffectsNewBtn, boCollection);
            BOStatusEffectID_NumBox.Minimum = short.MinValue;
            BOStatusEffectID_NumBox.Maximum = short.MaxValue;
            BOStatusEffectID_StrBox.DataSource = Enum.GetValues(typeof(BraveOrderEffectType));
            BOStatusEffectArg1Box.Minimum = int.MinValue;
            BOStatusEffectArg1Box.Maximum = int.MaxValue;
            BOStatusEffectArg2Box.Minimum = int.MinValue;
            BOStatusEffectArg2Box.Maximum = int.MaxValue;
            BOStatusEffectArg3Box.Minimum = int.MinValue;
            BOStatusEffectArg3Box.Maximum = int.MaxValue;
            DisableBOModifySection();
        }

        private void SetupRegStatusEffectModifyArea(int index) {
            if(currentIndexDisplayedReg >= 0) {
                regStatusEffects[currentIndexDisplayedReg].Id = (RegStatusEffectType)RegStatusEffectID_NumBox.Value;
                regStatusEffects[currentIndexDisplayedReg].Argument1 = (int)RegStatusEffectArg1Box.Value;
                regStatusEffects[currentIndexDisplayedReg].Argument2 = (int)RegStatusEffectArg2Box.Value;
                regStatusEffects[currentIndexDisplayedReg].Argument3 = (int)RegStatusEffectArg3Box.Value;
            }
            if (index < 0) return;
            RegStatusEffectID_NumBox.Enabled = true; RegStatusEffectID_NumBox.ReadOnly = true;
            RegStatusEffectID_NumBox.Value = (short)regStatusEffects[index].Id;
            RegStatusEffectID_StrBox.Enabled = true;
            RegStatusEffectID_StrBox.SelectedIndexChanged -= RegStatusEffectID_StrBoxItemChanged;
            RegStatusEffectID_StrBox.SelectedItem = regStatusEffects[index].Id;
            RegStatusEffectID_StrBox.SelectedIndexChanged += RegStatusEffectID_StrBoxItemChanged;
            RegStatusEffectArg1Box.Enabled = true;
            RegStatusEffectArg1Box.Value = (short)regStatusEffects[index].Argument1;
            RegStatusEffectArg2Box.Enabled = true;
            RegStatusEffectArg2Box.Value = (short)regStatusEffects[index].Argument2;
            RegStatusEffectArg3Box.Enabled = true;
            RegStatusEffectArg3Box.Value = (short)regStatusEffects[index].Argument3;
            currentIndexDisplayedReg = index;
            regStatusEffectGroupBoxCollection.CalculateGroupBoxContents();
        }

        private void SetupBOStatusEffectModifyArea(int index) {
            if (currentIndexDisplayedBO >= 0) {
                boStatusEffects[currentIndexDisplayedBO].Id = (BraveOrderEffectType)BOStatusEffectID_NumBox.Value;
                boStatusEffects[currentIndexDisplayedBO].Argument1 = (int)BOStatusEffectArg1Box.Value;
                boStatusEffects[currentIndexDisplayedBO].Argument2 = (int)BOStatusEffectArg2Box.Value;
                boStatusEffects[currentIndexDisplayedBO].Argument3 = (int)BOStatusEffectArg3Box.Value;
            }
            if (index < 0) return;
            BOStatusEffectID_NumBox.Enabled = true; BOStatusEffectID_NumBox.ReadOnly = true;
            BOStatusEffectID_NumBox.Value = (short)boStatusEffects[index].Id;
            BOStatusEffectID_StrBox.Enabled = true;
            BOStatusEffectID_StrBox.SelectedIndexChanged -= BOStatusEffectID_StrBoxItemChanged;
            BOStatusEffectID_StrBox.SelectedItem = boStatusEffects[index].Id;
            BOStatusEffectID_StrBox.SelectedIndexChanged += BOStatusEffectID_StrBoxItemChanged;
            BOStatusEffectArg1Box.Enabled = true;
            BOStatusEffectArg1Box.Value = (short)boStatusEffects[index].Argument1;
            BOStatusEffectArg2Box.Enabled = true;
            BOStatusEffectArg2Box.Value = (short)boStatusEffects[index].Argument2;
            BOStatusEffectArg3Box.Enabled = true;
            BOStatusEffectArg3Box.Value = (short)boStatusEffects[index].Argument3;
            currentIndexDisplayedBO = index;
            boStatusEffectGroupBoxCollection.CalculateGroupBoxContents();
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            SetupRegStatusEffectModifyArea(-1);
            magicRecord.StatusEffects = regStatusEffects;
            regStatusEffectGroupBoxCollection.ZeroStatusEffectsWithNullID();
            if (magicboRecord != null) {
                SetupBOStatusEffectModifyArea(-1);
                magicboRecord.BraveOrderEffects = boStatusEffects;
                boStatusEffectGroupBoxCollection.ZeroStatusEffectsWithNullID();
            }
            Close();
        }

        private void DisableRegModifySection() {
            currentIndexDisplayedReg = -1;
            RegStatusEffectID_NumBox.Enabled = false;
            RegStatusEffectID_StrBox.Enabled = false;
            RegStatusEffectArg1Box.Enabled = false;
            RegStatusEffectArg2Box.Enabled = false;
            RegStatusEffectArg3Box.Enabled = false;
        }

        private void DisableBOModifySection() {
            currentIndexDisplayedBO = -1;
            BOStatusEffectID_NumBox.Enabled = false;
            BOStatusEffectID_StrBox.Enabled = false;
            BOStatusEffectArg1Box.Enabled = false;
            BOStatusEffectArg2Box.Enabled = false;
            BOStatusEffectArg3Box.Enabled = false;
        }

        private void RegStatusEffectID_StrBoxItemChanged(object sender, EventArgs e) {
            RegStatusEffectType type = (RegStatusEffectType)RegStatusEffectID_StrBox.SelectedItem;
            RegStatusEffectID_NumBox.Value = (short)type;
            SetupRegStatusEffectModifyArea(currentIndexDisplayedReg);
        }

        private void RegStatusEffect1ModifyBtn_Click(object sender, EventArgs e) {
            SetupRegStatusEffectModifyArea(0);
        }

        private void RegStatusEffect2ModifyBtn_Click(object sender, EventArgs e) {
            SetupRegStatusEffectModifyArea(1);
        }

        private void RegStatusEffect3ModifyBtn_Click(object sender, EventArgs e) {
            SetupRegStatusEffectModifyArea(2);
        }

        private void RegStatusEffect4ModifyBtn_Click(object sender, EventArgs e) {
            SetupRegStatusEffectModifyArea(3);
        }

        private void RegStatusEffect5ModifyBtn_Click(object sender, EventArgs e) {
            SetupRegStatusEffectModifyArea(4);
        }

        private void RegStatusEffect1MoveLeftBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveLeft(0);
            DisableRegModifySection();
        }

        private void RegStatusEffect1MoveRightBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveRight(0);
            DisableRegModifySection();
        }

        private void RegStatusEffect2MoveLeftBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveLeft(1);
            DisableRegModifySection();
        }

        private void RegStatusEffect2MoveRightBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveRight(1);
            DisableRegModifySection();
        }

        private void RegStatusEffect3MoveLeftBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveLeft(2);
            DisableRegModifySection();
        }

        private void RegStatusEffect3MoveRightBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveRight(2);
            DisableRegModifySection();
        }

        private void RegStatusEffect4MoveLeftBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveLeft(3);
            DisableRegModifySection();
        }

        private void RegStatusEffect4MoveRightBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveRight(3);
            DisableRegModifySection();
        }

        private void RegStatusEffect5MoveLeftBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveLeft(4);
            DisableRegModifySection();
        }

        private void RegStatusEffect5MoveRightBtn_Click(object sender, EventArgs e) {
            regStatusEffectGroupBoxCollection.MoveRight(4);
            DisableRegModifySection();
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void RegStatusEffectsNewBtn_Click(object sender, EventArgs e) {
            int newIndex = regStatusEffects.Select(i => i.Id == 0).ToList().IndexOf(true);
            if (newIndex < 0) return;
            SetupRegStatusEffectModifyArea(newIndex);
        }

        private void BOStatusEffectID_StrBoxItemChanged(object sender, EventArgs e) {
            BraveOrderEffectType type = (BraveOrderEffectType)BOStatusEffectID_StrBox.SelectedItem;
            BOStatusEffectID_NumBox.Value = (short)type;
            SetupBOStatusEffectModifyArea(currentIndexDisplayedBO);
        }

        private void BOStatusEffect1ModifyBtn_Click(object sender, EventArgs e) {
            SetupBOStatusEffectModifyArea(0);
        }

        private void BOStatusEffect2ModifyBtn_Click(object sender, EventArgs e) {
            SetupBOStatusEffectModifyArea(1);
        }

        private void BOStatusEffect3ModifyBtn_Click(object sender, EventArgs e) {
            SetupBOStatusEffectModifyArea(2);
        }

        private void BOStatusEffect4ModifyBtn_Click(object sender, EventArgs e) {
            SetupBOStatusEffectModifyArea(3);
        }

        private void BOStatusEffect5ModifyBtn_Click(object sender, EventArgs e) {
            SetupBOStatusEffectModifyArea(4);
        }

        private void BOStatusEffect1MoveLeftBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveLeft(0);
            DisableBOModifySection();
        }

        private void BOStatusEffect1MoveRightBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveRight(0);
            DisableBOModifySection();
        }

        private void BOStatusEffect2MoveLeftBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveLeft(1);
            DisableBOModifySection();
        }

        private void BOStatusEffect2MoveRightBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveRight(1);
            DisableBOModifySection();
        }

        private void BOStatusEffect3MoveLeftBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveLeft(2);
            DisableBOModifySection();
        }

        private void BOStatusEffect3MoveRightBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveRight(2);
            DisableBOModifySection();
        }

        private void BOStatusEffect4MoveLeftBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveLeft(3);
            DisableBOModifySection();
        }

        private void BOStatusEffect4MoveRightBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveRight(3);
            DisableBOModifySection();
        }

        private void BOStatusEffect5MoveLeftBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveLeft(4);
            DisableBOModifySection();
        }

        private void BOStatusEffect5MoveRightBtn_Click(object sender, EventArgs e) {
            boStatusEffectGroupBoxCollection.MoveRight(4);
            DisableBOModifySection();
        }

        private void BOStatusEffectsNewBtn_Click(object sender, EventArgs e) {
            int newIndex = boStatusEffects.Select(i => i.Id == 0).ToList().IndexOf(true);
            if (newIndex < 0) return;
            SetupBOStatusEffectModifyArea(newIndex);
        }
    }
}
