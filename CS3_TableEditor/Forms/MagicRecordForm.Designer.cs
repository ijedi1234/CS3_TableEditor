namespace CS3_TableEditor.Forms {
    partial class MagicRecordForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostBox = new System.Windows.Forms.NumericUpDown();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AnimationNameLabel = new System.Windows.Forms.Label();
            this.AnimationNameBox = new System.Windows.Forms.TextBox();
            this.CastTimeBox = new System.Windows.Forms.NumericUpDown();
            this.CastTimeLabel = new System.Windows.Forms.Label();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.DelayBox = new System.Windows.Forms.NumericUpDown();
            this.UnbalanceBox = new System.Windows.Forms.NumericUpDown();
            this.UnbalanceLabel = new System.Windows.Forms.Label();
            this.DamageGroupBox = new System.Windows.Forms.GroupBox();
            this.BreakDamageBox = new System.Windows.Forms.NumericUpDown();
            this.BreakDamageLabel = new System.Windows.Forms.Label();
            this.LevelUnlockedBox = new System.Windows.Forms.NumericUpDown();
            this.LevelUnlockedLabel = new System.Windows.Forms.Label();
            this.MenuSortOrderBox = new System.Windows.Forms.NumericUpDown();
            this.MenuSortOrderLabel = new System.Windows.Forms.Label();
            this.CastingGroup = new System.Windows.Forms.GroupBox();
            this.ElementLabel = new System.Windows.Forms.Label();
            this.ElementBox = new System.Windows.Forms.ComboBox();
            this.MenuInfoGroup = new System.Windows.Forms.GroupBox();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.OwnerBox = new System.Windows.Forms.ComboBox();
            this.ActionIntentLabel = new System.Windows.Forms.Label();
            this.ActionIntentBox = new System.Windows.Forms.ComboBox();
            this.TargetingGroup = new System.Windows.Forms.GroupBox();
            this.SelectionRadiusLabel = new System.Windows.Forms.Label();
            this.SelectionRadiusBox = new System.Windows.Forms.NumericUpDown();
            this.MaxRangeRadiusBox = new System.Windows.Forms.NumericUpDown();
            this.MaxRangeRadiusLabel = new System.Windows.Forms.Label();
            this.SelectionTypeLabel = new System.Windows.Forms.Label();
            this.SelectionTypeBox = new System.Windows.Forms.ComboBox();
            this.TargetingFlagsGroupBox = new System.Windows.Forms.GroupBox();
            this.CannotMissBox = new System.Windows.Forms.CheckBox();
            this.AttackFromMOVBox = new System.Windows.Forms.CheckBox();
            this.AttackFromRNGBox = new System.Windows.Forms.CheckBox();
            this.OutsideUseBox = new System.Windows.Forms.CheckBox();
            this.TargetKOBox = new System.Windows.Forms.CheckBox();
            this.TargetCasterBox = new System.Windows.Forms.CheckBox();
            this.TargetPlayersBox = new System.Windows.Forms.CheckBox();
            this.TargetEnemiesBox = new System.Windows.Forms.CheckBox();
            this.Description2ndLineBox = new System.Windows.Forms.TextBox();
            this.Description1stLineBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.Provide1stLineBox = new System.Windows.Forms.CheckBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.NumericUpDown();
            this.BOTurnLengthLabel = new System.Windows.Forms.Label();
            this.BraveOrderTurnLengthBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CastTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnbalanceBox)).BeginInit();
            this.DamageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BreakDamageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelUnlockedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSortOrderBox)).BeginInit();
            this.CastingGroup.SuspendLayout();
            this.MenuInfoGroup.SuspendLayout();
            this.TargetingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionRadiusBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRangeRadiusBox)).BeginInit();
            this.TargetingFlagsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BraveOrderTurnLengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(614, 464);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(521, 464);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(586, 24);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(34, 15);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost:";
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(626, 22);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(120, 23);
            this.CostBox.TabIndex = 4;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(71, 11);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(213, 23);
            this.NameBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(23, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            // 
            // AnimationNameLabel
            // 
            this.AnimationNameLabel.AutoSize = true;
            this.AnimationNameLabel.Location = new System.Drawing.Point(287, 14);
            this.AnimationNameLabel.Name = "AnimationNameLabel";
            this.AnimationNameLabel.Size = new System.Drawing.Size(66, 15);
            this.AnimationNameLabel.TabIndex = 9;
            this.AnimationNameLabel.Text = "Animation:";
            // 
            // AnimationNameBox
            // 
            this.AnimationNameBox.Location = new System.Drawing.Point(359, 11);
            this.AnimationNameBox.Name = "AnimationNameBox";
            this.AnimationNameBox.Size = new System.Drawing.Size(279, 23);
            this.AnimationNameBox.TabIndex = 10;
            // 
            // CastTimeBox
            // 
            this.CastTimeBox.Location = new System.Drawing.Point(283, 22);
            this.CastTimeBox.Name = "CastTimeBox";
            this.CastTimeBox.Size = new System.Drawing.Size(120, 23);
            this.CastTimeBox.TabIndex = 11;
            // 
            // CastTimeLabel
            // 
            this.CastTimeLabel.AutoSize = true;
            this.CastTimeLabel.Location = new System.Drawing.Point(215, 24);
            this.CastTimeLabel.Name = "CastTimeLabel";
            this.CastTimeLabel.Size = new System.Drawing.Size(62, 15);
            this.CastTimeLabel.TabIndex = 12;
            this.CastTimeLabel.Text = "Cast Time:";
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(415, 24);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(39, 15);
            this.DelayLabel.TabIndex = 14;
            this.DelayLabel.Text = "Delay:";
            // 
            // DelayBox
            // 
            this.DelayBox.Location = new System.Drawing.Point(460, 22);
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.Size = new System.Drawing.Size(120, 23);
            this.DelayBox.TabIndex = 15;
            // 
            // UnbalanceBox
            // 
            this.UnbalanceBox.Location = new System.Drawing.Point(334, 22);
            this.UnbalanceBox.Name = "UnbalanceBox";
            this.UnbalanceBox.Size = new System.Drawing.Size(120, 23);
            this.UnbalanceBox.TabIndex = 16;
            // 
            // UnbalanceLabel
            // 
            this.UnbalanceLabel.AutoSize = true;
            this.UnbalanceLabel.Location = new System.Drawing.Point(262, 24);
            this.UnbalanceLabel.Name = "UnbalanceLabel";
            this.UnbalanceLabel.Size = new System.Drawing.Size(66, 15);
            this.UnbalanceLabel.TabIndex = 17;
            this.UnbalanceLabel.Text = "Unbalance:";
            // 
            // DamageGroupBox
            // 
            this.DamageGroupBox.Controls.Add(this.BraveOrderTurnLengthBox);
            this.DamageGroupBox.Controls.Add(this.BOTurnLengthLabel);
            this.DamageGroupBox.Controls.Add(this.BreakDamageBox);
            this.DamageGroupBox.Controls.Add(this.BreakDamageLabel);
            this.DamageGroupBox.Controls.Add(this.UnbalanceLabel);
            this.DamageGroupBox.Controls.Add(this.UnbalanceBox);
            this.DamageGroupBox.Location = new System.Drawing.Point(16, 391);
            this.DamageGroupBox.Name = "DamageGroupBox";
            this.DamageGroupBox.Size = new System.Drawing.Size(769, 55);
            this.DamageGroupBox.TabIndex = 18;
            this.DamageGroupBox.TabStop = false;
            this.DamageGroupBox.Text = "Damage";
            // 
            // BreakDamageBox
            // 
            this.BreakDamageBox.Location = new System.Drawing.Point(136, 22);
            this.BreakDamageBox.Name = "BreakDamageBox";
            this.BreakDamageBox.Size = new System.Drawing.Size(120, 23);
            this.BreakDamageBox.TabIndex = 19;
            // 
            // BreakDamageLabel
            // 
            this.BreakDamageLabel.AutoSize = true;
            this.BreakDamageLabel.Location = new System.Drawing.Point(44, 24);
            this.BreakDamageLabel.Name = "BreakDamageLabel";
            this.BreakDamageLabel.Size = new System.Drawing.Size(86, 15);
            this.BreakDamageLabel.TabIndex = 19;
            this.BreakDamageLabel.Text = "Break Damage:";
            // 
            // LevelUnlockedBox
            // 
            this.LevelUnlockedBox.Location = new System.Drawing.Point(642, 22);
            this.LevelUnlockedBox.Name = "LevelUnlockedBox";
            this.LevelUnlockedBox.Size = new System.Drawing.Size(120, 23);
            this.LevelUnlockedBox.TabIndex = 20;
            // 
            // LevelUnlockedLabel
            // 
            this.LevelUnlockedLabel.AutoSize = true;
            this.LevelUnlockedLabel.Location = new System.Drawing.Point(566, 24);
            this.LevelUnlockedLabel.Name = "LevelUnlockedLabel";
            this.LevelUnlockedLabel.Size = new System.Drawing.Size(77, 15);
            this.LevelUnlockedLabel.TabIndex = 19;
            this.LevelUnlockedLabel.Text = "Level Unlock:";
            // 
            // MenuSortOrderBox
            // 
            this.MenuSortOrderBox.Location = new System.Drawing.Point(440, 23);
            this.MenuSortOrderBox.Name = "MenuSortOrderBox";
            this.MenuSortOrderBox.Size = new System.Drawing.Size(120, 23);
            this.MenuSortOrderBox.TabIndex = 19;
            // 
            // MenuSortOrderLabel
            // 
            this.MenuSortOrderLabel.AutoSize = true;
            this.MenuSortOrderLabel.Location = new System.Drawing.Point(360, 25);
            this.MenuSortOrderLabel.Name = "MenuSortOrderLabel";
            this.MenuSortOrderLabel.Size = new System.Drawing.Size(74, 15);
            this.MenuSortOrderLabel.TabIndex = 19;
            this.MenuSortOrderLabel.Text = "Menu Order:";
            // 
            // CastingGroup
            // 
            this.CastingGroup.Controls.Add(this.ElementLabel);
            this.CastingGroup.Controls.Add(this.ElementBox);
            this.CastingGroup.Controls.Add(this.CostBox);
            this.CastingGroup.Controls.Add(this.CostLabel);
            this.CastingGroup.Controls.Add(this.DelayLabel);
            this.CastingGroup.Controls.Add(this.DelayBox);
            this.CastingGroup.Controls.Add(this.CastTimeLabel);
            this.CastingGroup.Controls.Add(this.CastTimeBox);
            this.CastingGroup.Location = new System.Drawing.Point(16, 128);
            this.CastingGroup.Name = "CastingGroup";
            this.CastingGroup.Size = new System.Drawing.Size(769, 60);
            this.CastingGroup.TabIndex = 19;
            this.CastingGroup.TabStop = false;
            this.CastingGroup.Text = "Casting";
            // 
            // ElementLabel
            // 
            this.ElementLabel.AutoSize = true;
            this.ElementLabel.Location = new System.Drawing.Point(29, 24);
            this.ElementLabel.Name = "ElementLabel";
            this.ElementLabel.Size = new System.Drawing.Size(53, 15);
            this.ElementLabel.TabIndex = 17;
            this.ElementLabel.Text = "Element:";
            // 
            // ElementBox
            // 
            this.ElementBox.FormattingEnabled = true;
            this.ElementBox.Location = new System.Drawing.Point(88, 21);
            this.ElementBox.Name = "ElementBox";
            this.ElementBox.Size = new System.Drawing.Size(121, 23);
            this.ElementBox.TabIndex = 16;
            // 
            // MenuInfoGroup
            // 
            this.MenuInfoGroup.Controls.Add(this.LevelUnlockedBox);
            this.MenuInfoGroup.Controls.Add(this.OwnerLabel);
            this.MenuInfoGroup.Controls.Add(this.LevelUnlockedLabel);
            this.MenuInfoGroup.Controls.Add(this.OwnerBox);
            this.MenuInfoGroup.Controls.Add(this.ActionIntentLabel);
            this.MenuInfoGroup.Controls.Add(this.ActionIntentBox);
            this.MenuInfoGroup.Controls.Add(this.MenuSortOrderBox);
            this.MenuInfoGroup.Controls.Add(this.MenuSortOrderLabel);
            this.MenuInfoGroup.Location = new System.Drawing.Point(16, 194);
            this.MenuInfoGroup.Name = "MenuInfoGroup";
            this.MenuInfoGroup.Size = new System.Drawing.Size(769, 52);
            this.MenuInfoGroup.TabIndex = 20;
            this.MenuInfoGroup.TabStop = false;
            this.MenuInfoGroup.Text = "Menu Info";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Location = new System.Drawing.Point(4, 25);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(45, 15);
            this.OwnerLabel.TabIndex = 23;
            this.OwnerLabel.Text = "Owner:";
            // 
            // OwnerBox
            // 
            this.OwnerBox.FormattingEnabled = true;
            this.OwnerBox.Location = new System.Drawing.Point(55, 22);
            this.OwnerBox.Name = "OwnerBox";
            this.OwnerBox.Size = new System.Drawing.Size(121, 23);
            this.OwnerBox.TabIndex = 22;
            // 
            // ActionIntentLabel
            // 
            this.ActionIntentLabel.AutoSize = true;
            this.ActionIntentLabel.Location = new System.Drawing.Point(183, 25);
            this.ActionIntentLabel.Name = "ActionIntentLabel";
            this.ActionIntentLabel.Size = new System.Drawing.Size(41, 15);
            this.ActionIntentLabel.TabIndex = 21;
            this.ActionIntentLabel.Text = "Intent:";
            // 
            // ActionIntentBox
            // 
            this.ActionIntentBox.FormattingEnabled = true;
            this.ActionIntentBox.Location = new System.Drawing.Point(230, 22);
            this.ActionIntentBox.Name = "ActionIntentBox";
            this.ActionIntentBox.Size = new System.Drawing.Size(121, 23);
            this.ActionIntentBox.TabIndex = 20;
            // 
            // TargetingGroup
            // 
            this.TargetingGroup.Controls.Add(this.SelectionRadiusLabel);
            this.TargetingGroup.Controls.Add(this.SelectionRadiusBox);
            this.TargetingGroup.Controls.Add(this.MaxRangeRadiusBox);
            this.TargetingGroup.Controls.Add(this.MaxRangeRadiusLabel);
            this.TargetingGroup.Controls.Add(this.SelectionTypeLabel);
            this.TargetingGroup.Controls.Add(this.SelectionTypeBox);
            this.TargetingGroup.Controls.Add(this.TargetingFlagsGroupBox);
            this.TargetingGroup.Location = new System.Drawing.Point(16, 252);
            this.TargetingGroup.Name = "TargetingGroup";
            this.TargetingGroup.Size = new System.Drawing.Size(769, 133);
            this.TargetingGroup.TabIndex = 21;
            this.TargetingGroup.TabStop = false;
            this.TargetingGroup.Text = "Targeting";
            // 
            // SelectionRadiusLabel
            // 
            this.SelectionRadiusLabel.AutoSize = true;
            this.SelectionRadiusLabel.Location = new System.Drawing.Point(557, 103);
            this.SelectionRadiusLabel.Name = "SelectionRadiusLabel";
            this.SelectionRadiusLabel.Size = new System.Drawing.Size(81, 15);
            this.SelectionRadiusLabel.TabIndex = 8;
            this.SelectionRadiusLabel.Text = "Selection Size:";
            // 
            // SelectionRadiusBox
            // 
            this.SelectionRadiusBox.Location = new System.Drawing.Point(638, 101);
            this.SelectionRadiusBox.Name = "SelectionRadiusBox";
            this.SelectionRadiusBox.Size = new System.Drawing.Size(120, 23);
            this.SelectionRadiusBox.TabIndex = 7;
            // 
            // MaxRangeRadiusBox
            // 
            this.MaxRangeRadiusBox.Location = new System.Drawing.Point(432, 101);
            this.MaxRangeRadiusBox.Name = "MaxRangeRadiusBox";
            this.MaxRangeRadiusBox.Size = new System.Drawing.Size(120, 23);
            this.MaxRangeRadiusBox.TabIndex = 6;
            // 
            // MaxRangeRadiusLabel
            // 
            this.MaxRangeRadiusLabel.AutoSize = true;
            this.MaxRangeRadiusLabel.Location = new System.Drawing.Point(360, 103);
            this.MaxRangeRadiusLabel.Name = "MaxRangeRadiusLabel";
            this.MaxRangeRadiusLabel.Size = new System.Drawing.Size(66, 15);
            this.MaxRangeRadiusLabel.TabIndex = 5;
            this.MaxRangeRadiusLabel.Text = "Range Size:";
            // 
            // SelectionTypeLabel
            // 
            this.SelectionTypeLabel.AutoSize = true;
            this.SelectionTypeLabel.Location = new System.Drawing.Point(3, 103);
            this.SelectionTypeLabel.Name = "SelectionTypeLabel";
            this.SelectionTypeLabel.Size = new System.Drawing.Size(85, 15);
            this.SelectionTypeLabel.TabIndex = 4;
            this.SelectionTypeLabel.Text = "Selection Type:";
            // 
            // SelectionTypeBox
            // 
            this.SelectionTypeBox.FormattingEnabled = true;
            this.SelectionTypeBox.Location = new System.Drawing.Point(94, 100);
            this.SelectionTypeBox.Name = "SelectionTypeBox";
            this.SelectionTypeBox.Size = new System.Drawing.Size(258, 23);
            this.SelectionTypeBox.TabIndex = 3;
            // 
            // TargetingFlagsGroupBox
            // 
            this.TargetingFlagsGroupBox.Controls.Add(this.CannotMissBox);
            this.TargetingFlagsGroupBox.Controls.Add(this.AttackFromMOVBox);
            this.TargetingFlagsGroupBox.Controls.Add(this.AttackFromRNGBox);
            this.TargetingFlagsGroupBox.Controls.Add(this.OutsideUseBox);
            this.TargetingFlagsGroupBox.Controls.Add(this.TargetKOBox);
            this.TargetingFlagsGroupBox.Controls.Add(this.TargetCasterBox);
            this.TargetingFlagsGroupBox.Controls.Add(this.TargetPlayersBox);
            this.TargetingFlagsGroupBox.Controls.Add(this.TargetEnemiesBox);
            this.TargetingFlagsGroupBox.Location = new System.Drawing.Point(6, 22);
            this.TargetingFlagsGroupBox.Name = "TargetingFlagsGroupBox";
            this.TargetingFlagsGroupBox.Size = new System.Drawing.Size(752, 72);
            this.TargetingFlagsGroupBox.TabIndex = 2;
            this.TargetingFlagsGroupBox.TabStop = false;
            this.TargetingFlagsGroupBox.Text = "Flags";
            // 
            // CannotMissBox
            // 
            this.CannotMissBox.AutoSize = true;
            this.CannotMissBox.Location = new System.Drawing.Point(575, 22);
            this.CannotMissBox.Name = "CannotMissBox";
            this.CannotMissBox.Size = new System.Drawing.Size(92, 19);
            this.CannotMissBox.TabIndex = 7;
            this.CannotMissBox.Tag = "I";
            this.CannotMissBox.Text = "Cannot Miss";
            this.CannotMissBox.UseVisualStyleBackColor = true;
            // 
            // AttackFromMOVBox
            // 
            this.AttackFromMOVBox.AutoSize = true;
            this.AttackFromMOVBox.Location = new System.Drawing.Point(186, 47);
            this.AttackFromMOVBox.Name = "AttackFromMOVBox";
            this.AttackFromMOVBox.Size = new System.Drawing.Size(160, 19);
            this.AttackFromMOVBox.TabIndex = 6;
            this.AttackFromMOVBox.Tag = "O";
            this.AttackFromMOVBox.Text = "Attack From Move Range";
            this.AttackFromMOVBox.UseVisualStyleBackColor = true;
            // 
            // AttackFromRNGBox
            // 
            this.AttackFromRNGBox.AutoSize = true;
            this.AttackFromRNGBox.Location = new System.Drawing.Point(6, 47);
            this.AttackFromRNGBox.Name = "AttackFromRNGBox";
            this.AttackFromRNGBox.Size = new System.Drawing.Size(174, 19);
            this.AttackFromRNGBox.TabIndex = 5;
            this.AttackFromRNGBox.Tag = "D";
            this.AttackFromRNGBox.Text = "Attack From Weapon Range";
            this.AttackFromRNGBox.UseVisualStyleBackColor = true;
            // 
            // OutsideUseBox
            // 
            this.OutsideUseBox.AutoSize = true;
            this.OutsideUseBox.Location = new System.Drawing.Point(423, 22);
            this.OutsideUseBox.Name = "OutsideUseBox";
            this.OutsideUseBox.Size = new System.Drawing.Size(146, 19);
            this.OutsideUseBox.TabIndex = 4;
            this.OutsideUseBox.Tag = "C";
            this.OutsideUseBox.Text = "Can Use Outside Battle";
            this.OutsideUseBox.UseVisualStyleBackColor = true;
            // 
            // TargetKOBox
            // 
            this.TargetKOBox.AutoSize = true;
            this.TargetKOBox.Location = new System.Drawing.Point(336, 22);
            this.TargetKOBox.Name = "TargetKOBox";
            this.TargetKOBox.Size = new System.Drawing.Size(81, 19);
            this.TargetKOBox.TabIndex = 3;
            this.TargetKOBox.Tag = "R";
            this.TargetKOBox.Text = "Targets KO";
            this.TargetKOBox.UseVisualStyleBackColor = true;
            // 
            // TargetCasterBox
            // 
            this.TargetCasterBox.AutoSize = true;
            this.TargetCasterBox.Location = new System.Drawing.Point(231, 22);
            this.TargetCasterBox.Name = "TargetCasterBox";
            this.TargetCasterBox.Size = new System.Drawing.Size(99, 19);
            this.TargetCasterBox.TabIndex = 2;
            this.TargetCasterBox.Tag = "M";
            this.TargetCasterBox.Text = "Targets Caster";
            this.TargetCasterBox.UseVisualStyleBackColor = true;
            // 
            // TargetPlayersBox
            // 
            this.TargetPlayersBox.AutoSize = true;
            this.TargetPlayersBox.Location = new System.Drawing.Point(122, 22);
            this.TargetPlayersBox.Name = "TargetPlayersBox";
            this.TargetPlayersBox.Size = new System.Drawing.Size(103, 19);
            this.TargetPlayersBox.TabIndex = 1;
            this.TargetPlayersBox.Tag = "P";
            this.TargetPlayersBox.Text = "Targets Players";
            this.TargetPlayersBox.UseVisualStyleBackColor = true;
            // 
            // TargetEnemiesBox
            // 
            this.TargetEnemiesBox.AutoSize = true;
            this.TargetEnemiesBox.Location = new System.Drawing.Point(6, 22);
            this.TargetEnemiesBox.Name = "TargetEnemiesBox";
            this.TargetEnemiesBox.Size = new System.Drawing.Size(110, 19);
            this.TargetEnemiesBox.TabIndex = 0;
            this.TargetEnemiesBox.Tag = "E";
            this.TargetEnemiesBox.Text = "Targets Enemies";
            this.TargetEnemiesBox.UseVisualStyleBackColor = true;
            // 
            // Description2ndLineBox
            // 
            this.Description2ndLineBox.Location = new System.Drawing.Point(16, 95);
            this.Description2ndLineBox.Name = "Description2ndLineBox";
            this.Description2ndLineBox.Size = new System.Drawing.Size(769, 23);
            this.Description2ndLineBox.TabIndex = 22;
            // 
            // Description1stLineBox
            // 
            this.Description1stLineBox.Enabled = false;
            this.Description1stLineBox.Location = new System.Drawing.Point(16, 66);
            this.Description1stLineBox.Name = "Description1stLineBox";
            this.Description1stLineBox.Size = new System.Drawing.Size(769, 23);
            this.Description1stLineBox.TabIndex = 23;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(29, 41);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.DescriptionLabel.TabIndex = 24;
            this.DescriptionLabel.Text = "Description";
            // 
            // Provide1stLineBox
            // 
            this.Provide1stLineBox.AutoSize = true;
            this.Provide1stLineBox.Location = new System.Drawing.Point(102, 41);
            this.Provide1stLineBox.Name = "Provide1stLineBox";
            this.Provide1stLineBox.Size = new System.Drawing.Size(138, 19);
            this.Provide1stLineBox.TabIndex = 25;
            this.Provide1stLineBox.Text = "Set 1st Line in Record";
            this.Provide1stLineBox.UseVisualStyleBackColor = true;
            this.Provide1stLineBox.CheckedChanged += new System.EventHandler(this.Provide1stLineBox_CheckedChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(641, 16);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 15);
            this.IDLabel.TabIndex = 26;
            this.IDLabel.Text = "ID:";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(668, 12);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(120, 23);
            this.IDBox.TabIndex = 27;
            // 
            // BOTurnLengthLabel
            // 
            this.BOTurnLengthLabel.AutoSize = true;
            this.BOTurnLengthLabel.Location = new System.Drawing.Point(460, 24);
            this.BOTurnLengthLabel.Name = "BOTurnLengthLabel";
            this.BOTurnLengthLabel.Size = new System.Drawing.Size(139, 15);
            this.BOTurnLengthLabel.TabIndex = 28;
            this.BOTurnLengthLabel.Text = "Brave Order Turn Length:";
            // 
            // BraveOrderTurnLengthBox
            // 
            this.BraveOrderTurnLengthBox.Location = new System.Drawing.Point(605, 22);
            this.BraveOrderTurnLengthBox.Name = "BraveOrderTurnLengthBox";
            this.BraveOrderTurnLengthBox.Size = new System.Drawing.Size(120, 23);
            this.BraveOrderTurnLengthBox.TabIndex = 28;
            // 
            // MagicRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.Provide1stLineBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.Description1stLineBox);
            this.Controls.Add(this.Description2ndLineBox);
            this.Controls.Add(this.TargetingGroup);
            this.Controls.Add(this.MenuInfoGroup);
            this.Controls.Add(this.CastingGroup);
            this.Controls.Add(this.DamageGroupBox);
            this.Controls.Add(this.AnimationNameBox);
            this.Controls.Add(this.AnimationNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Name = "MagicRecordForm";
            this.Text = "MagicRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.CostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CastTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnbalanceBox)).EndInit();
            this.DamageGroupBox.ResumeLayout(false);
            this.DamageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BreakDamageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelUnlockedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSortOrderBox)).EndInit();
            this.CastingGroup.ResumeLayout(false);
            this.CastingGroup.PerformLayout();
            this.MenuInfoGroup.ResumeLayout(false);
            this.MenuInfoGroup.PerformLayout();
            this.TargetingGroup.ResumeLayout(false);
            this.TargetingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionRadiusBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRangeRadiusBox)).EndInit();
            this.TargetingFlagsGroupBox.ResumeLayout(false);
            this.TargetingFlagsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BraveOrderTurnLengthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.NumericUpDown CostBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AnimationNameLabel;
        private System.Windows.Forms.TextBox AnimationNameBox;
        private System.Windows.Forms.NumericUpDown CastTimeBox;
        private System.Windows.Forms.Label CastTimeLabel;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.NumericUpDown DelayBox;
        private System.Windows.Forms.NumericUpDown UnbalanceBox;
        private System.Windows.Forms.Label UnbalanceLabel;
        private System.Windows.Forms.GroupBox DamageGroupBox;
        private System.Windows.Forms.NumericUpDown BreakDamageBox;
        private System.Windows.Forms.Label BreakDamageLabel;
        private System.Windows.Forms.Label LevelUnlockedLabel;
        private System.Windows.Forms.NumericUpDown LevelUnlockedBox;
        private System.Windows.Forms.Label MenuSortOrderLabel;
        private System.Windows.Forms.NumericUpDown MenuSortOrderBox;
        private System.Windows.Forms.GroupBox CastingGroup;
        private System.Windows.Forms.ComboBox ElementBox;
        private System.Windows.Forms.Label ElementLabel;
        private System.Windows.Forms.GroupBox MenuInfoGroup;
        private System.Windows.Forms.ComboBox ActionIntentBox;
        private System.Windows.Forms.Label ActionIntentLabel;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.ComboBox OwnerBox;
        private System.Windows.Forms.GroupBox TargetingGroup;
        private System.Windows.Forms.GroupBox TargetingFlagsGroupBox;
        private System.Windows.Forms.CheckBox TargetEnemiesBox;
        private System.Windows.Forms.CheckBox TargetPlayersBox;
        private System.Windows.Forms.CheckBox TargetCasterBox;
        private System.Windows.Forms.CheckBox TargetKOBox;
        private System.Windows.Forms.CheckBox OutsideUseBox;
        private System.Windows.Forms.CheckBox AttackFromRNGBox;
        private System.Windows.Forms.CheckBox AttackFromMOVBox;
        private System.Windows.Forms.CheckBox CannotMissBox;
        private System.Windows.Forms.TextBox Description2ndLineBox;
        private System.Windows.Forms.TextBox Description1stLineBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.CheckBox Provide1stLineBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.NumericUpDown IDBox;
        private System.Windows.Forms.Label SelectionTypeLabel;
        private System.Windows.Forms.ComboBox SelectionTypeBox;
        private System.Windows.Forms.Label MaxRangeRadiusLabel;
        private System.Windows.Forms.NumericUpDown MaxRangeRadiusBox;
        private System.Windows.Forms.NumericUpDown SelectionRadiusBox;
        private System.Windows.Forms.Label SelectionRadiusLabel;
        private System.Windows.Forms.Label BOTurnLengthLabel;
        private System.Windows.Forms.NumericUpDown BraveOrderTurnLengthBox;
    }
}