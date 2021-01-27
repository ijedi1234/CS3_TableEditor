using CS3_TableEditor.CS3Tables.Magic;
using CS3_TableEditor.MagicRecordFormLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CS3_TableEditor.CS3Tables;

namespace CS3_TableEditor.Forms {
    public partial class MagicRecordForm : Form {

        private MagicRecord magicRecord;
        private TargetingFlags targetingFlags;

        public MagicRecordForm(MagicRecord magicRecord) {
            this.magicRecord = magicRecord;
            InitializeComponent();

            IDBox.Minimum = short.MinValue;
            IDBox.Maximum = short.MaxValue;
            IDBox.Value = magicRecord.ID;
            IDBox.Enabled = false;

            if (((short)magicRecord.OwnerID).ToString() != magicRecord.OwnerID.ToString()) {
                OwnerBox.DataSource = Enum.GetValues(typeof(OwnerType));
                OwnerBox.SelectedItem = magicRecord.OwnerID;
            } else { OwnerBox.Enabled = false; }

            targetingFlags = new TargetingFlags(magicRecord.TargetingType);
            targetingFlags.LoadFlagsIntoUI(TargetingFlagsGroupBox, Provide1stLineBox);

            ActionIntentBox.DataSource = Enum.GetValues(typeof(ActionIntentType));
            ActionIntentBox.SelectedItem = magicRecord.ActionIntent;
            ElementBox.DataSource = Enum.GetValues(typeof(ElementType));
            ElementBox.SelectedItem = magicRecord.Element;
            CastTimeBox.Minimum = byte.MinValue;
            CastTimeBox.Maximum = byte.MaxValue;
            CastTimeBox.Value = magicRecord.CastTime;
            DelayBox.Minimum = byte.MinValue;
            DelayBox.Maximum = byte.MaxValue;
            DelayBox.Value = magicRecord.Delay;
            CostBox.Minimum = short.MinValue;
            CostBox.Maximum = short.MaxValue;
            CostBox.Value = magicRecord.Cost;
            LevelUnlockedBox.Minimum = byte.MinValue;
            LevelUnlockedBox.Maximum = byte.MaxValue;
            LevelUnlockedBox.Value = magicRecord.LevelUnlocked;
            MenuSortOrderBox.Minimum = short.MinValue;
            MenuSortOrderBox.Maximum = short.MaxValue;
            MenuSortOrderBox.Value = magicRecord.MenuSortOrder;

            UnbalanceBox.Minimum = byte.MinValue;
            UnbalanceBox.Maximum = byte.MaxValue;
            UnbalanceBox.Value = magicRecord.Unbalance;
            BreakDamageBox.Minimum = short.MinValue;
            BreakDamageBox.Maximum = short.MaxValue;
            BreakDamageBox.Value = (short)magicRecord.BreakDamage;
            BraveOrderTurnLengthBox.Minimum = short.MinValue;
            BraveOrderTurnLengthBox.Maximum = short.MaxValue;
            if (magicRecord.MagicboRecord != null)
                BraveOrderTurnLengthBox.Value = magicRecord.MagicboRecord.BraveOrderTurnLength;
            else
                BraveOrderTurnLengthBox.Enabled = false;

            SelectionTypeBox.DataSource = Enum.GetValues(typeof(TargetSelectionType));
            SelectionTypeBox.SelectedItem = magicRecord.SelectionType;
            MaxRangeRadiusBox.Value = (decimal)magicRecord.MaxRangeRadius;
            SelectionRadiusBox.Minimum = byte.MinValue;
            SelectionRadiusBox.Maximum = byte.MaxValue;
            SelectionRadiusBox.Value = magicRecord.SelectionRadius;

            Description1stLineBox.Text = magicRecord.Description1stLine;
            Description2ndLineBox.Text = magicRecord.Description2ndLine;
            NameBox.Text = magicRecord.Name;
            AnimationNameBox.Text = magicRecord.AnimationName;
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            if(OwnerBox.Enabled)
                magicRecord.OwnerID = (OwnerType)OwnerBox.SelectedItem;
            targetingFlags.LoadFlagsFromUI(TargetingFlagsGroupBox, Provide1stLineBox);
            magicRecord.TargetingType = targetingFlags.GetFlags();
            magicRecord.ActionIntent = (ActionIntentType)ActionIntentBox.SelectedItem;
            magicRecord.Element = (ElementType)ElementBox.SelectedItem;
            magicRecord.CastTime = (byte)CastTimeBox.Value;
            magicRecord.Delay = (byte)DelayBox.Value;
            magicRecord.Cost = (short)CostBox.Value;
            magicRecord.Unbalance = (byte)UnbalanceBox.Value;
            magicRecord.BreakDamage = (BreakGrade)BreakDamageBox.Value;
            magicRecord.LevelUnlocked = (byte)LevelUnlockedBox.Value;
            magicRecord.MenuSortOrder = (short)MenuSortOrderBox.Value;
            magicRecord.SelectionType = (TargetSelectionType)SelectionTypeBox.SelectedItem;
            magicRecord.MaxRangeRadius = (float)MaxRangeRadiusBox.Value;
            if (magicRecord.MagicboRecord != null)
                magicRecord.MagicboRecord.BraveOrderTurnLength = (short)BraveOrderTurnLengthBox.Value;
            if (targetingFlags.RecordProvideDescFirstLine)
                magicRecord.Description1stLine = Description1stLineBox.Text.Trim();
            else
                magicRecord.Description1stLine = "";
            magicRecord.Description2ndLine = Description2ndLineBox.Text.Trim();
            magicRecord.Name = NameBox.Text;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void Provide1stLineBox_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked) Description1stLineBox.Enabled = true;
            else Description1stLineBox.Enabled = false;
        }

    }
}
