using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CS3_TableEditor.MagicRecordFormLogic {
    public class TargetingFlags {

        // B - E - P - M - R - C - (D - O - N)? - I - Q - Z

        public bool BattleUse { get; set; } //Has B
        public bool EnemyTarget { get; set; } //Has E
        public bool PlayerTarget { get; set; } //Has P
        public bool CasterTarget { get; set; } //Has M
        public bool KOTarget { get; set; } //Has R
        public bool OutsideUse { get; set; } //Has C 
        public bool AttackFromRNG { get; set; } //Has D
        public bool AttackFromMOV { get; set; } //Has O
        public bool NormalAttack { get; set; } //Has N
        public bool CannotMiss { get; set; } //Has I
        public bool Quartz { get; set; } //Quartz - required for Arts
        public bool RecordProvideDescFirstLine { get; set; } //Has Z


        public TargetingFlags(string flags) {
            flags = flags.ToUpper();
            BattleUse = flags.Contains("B");
            EnemyTarget = flags.Contains("E");
            PlayerTarget = flags.Contains("P");
            CasterTarget = flags.Contains("M");
            KOTarget = flags.Contains("R");
            OutsideUse = flags.Contains("C");
            AttackFromRNG = flags.Contains("D");
            AttackFromMOV = flags.Contains("O");
            NormalAttack = flags.Contains("N");
            CannotMiss = flags.Contains("I");
            Quartz = flags.Contains("Q");
            RecordProvideDescFirstLine = flags.Contains("Z");
        }

        public void LoadFlagsIntoUI(GroupBox targetingFlagsGroupBox, CheckBox setDesc1stLineBox) {
            HandleCheckBox(targetingFlagsGroupBox, "TargetEnemiesBox", EnemyTarget);
            HandleCheckBox(targetingFlagsGroupBox, "TargetPlayersBox", PlayerTarget);
            HandleCheckBox(targetingFlagsGroupBox, "TargetCasterBox", CasterTarget);
            HandleCheckBox(targetingFlagsGroupBox, "TargetKOBox", KOTarget);
            HandleCheckBox(targetingFlagsGroupBox, "OutsideUseBox", OutsideUse);
            HandleCheckBox(targetingFlagsGroupBox, "AttackFromRNGBox", AttackFromRNG);
            HandleCheckBox(targetingFlagsGroupBox, "AttackFromMOVBox", AttackFromMOV);
            HandleCheckBox(targetingFlagsGroupBox, "CannotMissBox", CannotMiss);
            setDesc1stLineBox.Checked = RecordProvideDescFirstLine;
        }

        public void LoadFlagsFromUI(GroupBox targetingFlagsGroupBox, CheckBox setDesc1stLineBox) {
            EnemyTarget = ((CheckBox)targetingFlagsGroupBox.Controls["TargetEnemiesBox"]).Checked;
            PlayerTarget = ((CheckBox)targetingFlagsGroupBox.Controls["TargetPlayersBox"]).Checked;
            CasterTarget = ((CheckBox)targetingFlagsGroupBox.Controls["TargetCasterBox"]).Checked;
            KOTarget = ((CheckBox)targetingFlagsGroupBox.Controls["TargetKOBox"]).Checked;
            OutsideUse = ((CheckBox)targetingFlagsGroupBox.Controls["OutsideUseBox"]).Checked;
            AttackFromRNG = ((CheckBox)targetingFlagsGroupBox.Controls["AttackFromRNGBox"]).Checked;
            AttackFromMOV = ((CheckBox)targetingFlagsGroupBox.Controls["AttackFromMOVBox"]).Checked;
            CannotMiss = ((CheckBox)targetingFlagsGroupBox.Controls["CannotMissBox"]).Checked;
            RecordProvideDescFirstLine = setDesc1stLineBox.Checked;
        }

        private void HandleCheckBox(GroupBox targetingFlagsGroupBox, string checkBoxName, bool flag) {
            CheckBox box = (CheckBox)targetingFlagsGroupBox.Controls[checkBoxName];
            if (flag) box.Checked = true; else box.Checked = false;
        }

        public string GetFlags() {
            string flags = "";
            if (BattleUse) flags += 'B';
            if (EnemyTarget) flags += "E";
            if (PlayerTarget) flags += "P";
            if (CasterTarget) flags += "M";
            if (KOTarget) flags += "R";
            if (OutsideUse) flags += "C";
            if (AttackFromRNG) flags += "D";
            if (AttackFromMOV) flags += "O";
            if (NormalAttack) flags += "N";
            if (CannotMiss) flags += "I";
            if (Quartz) flags += "Q";
            if (RecordProvideDescFirstLine) flags += "Z";
            if (flags.Length == 0) return "0";
            return flags;
        }

    }
}
