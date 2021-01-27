namespace CS3_TableEditor.Forms {
    partial class MagicTableForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TMagicList = new System.Windows.Forms.ListView();
            this.MagicCraftsBtn = new System.Windows.Forms.Button();
            this.TMagicBox = new System.Windows.Forms.GroupBox();
            this.MagicBraveOrdersBtn = new System.Windows.Forms.Button();
            this.MagicDivineLinkAttacksBtn = new System.Windows.Forms.Button();
            this.MagicLinkAttacksBtn = new System.Windows.Forms.Button();
            this.MagicLinkAbilitiesBtn = new System.Windows.Forms.Button();
            this.MagicSCraftBtn = new System.Windows.Forms.Button();
            this.MagicDivineArtsBtn = new System.Windows.Forms.Button();
            this.MagicDivineCraftsBtn = new System.Windows.Forms.Button();
            this.MagicArtsBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OpenStatusEffectsBtn = new System.Windows.Forms.Button();
            this.GeneralInfo = new System.Windows.Forms.Button();
            this.TMagicBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TMagicList
            // 
            this.TMagicList.FullRowSelect = true;
            this.TMagicList.HideSelection = false;
            this.TMagicList.Location = new System.Drawing.Point(230, 12);
            this.TMagicList.Name = "TMagicList";
            this.TMagicList.Size = new System.Drawing.Size(877, 307);
            this.TMagicList.TabIndex = 0;
            this.TMagicList.UseCompatibleStateImageBehavior = false;
            this.TMagicList.View = System.Windows.Forms.View.Details;
            // 
            // MagicCraftsBtn
            // 
            this.MagicCraftsBtn.Location = new System.Drawing.Point(14, 33);
            this.MagicCraftsBtn.Name = "MagicCraftsBtn";
            this.MagicCraftsBtn.Size = new System.Drawing.Size(92, 23);
            this.MagicCraftsBtn.TabIndex = 2;
            this.MagicCraftsBtn.Text = "Crafts";
            this.MagicCraftsBtn.UseVisualStyleBackColor = true;
            this.MagicCraftsBtn.Click += new System.EventHandler(this.MagicCraftsBtn_Click);
            // 
            // TMagicBox
            // 
            this.TMagicBox.Controls.Add(this.MagicBraveOrdersBtn);
            this.TMagicBox.Controls.Add(this.MagicDivineLinkAttacksBtn);
            this.TMagicBox.Controls.Add(this.MagicLinkAttacksBtn);
            this.TMagicBox.Controls.Add(this.MagicLinkAbilitiesBtn);
            this.TMagicBox.Controls.Add(this.MagicSCraftBtn);
            this.TMagicBox.Controls.Add(this.MagicDivineArtsBtn);
            this.TMagicBox.Controls.Add(this.MagicDivineCraftsBtn);
            this.TMagicBox.Controls.Add(this.MagicArtsBtn);
            this.TMagicBox.Controls.Add(this.MagicCraftsBtn);
            this.TMagicBox.Location = new System.Drawing.Point(9, 12);
            this.TMagicBox.Name = "TMagicBox";
            this.TMagicBox.Size = new System.Drawing.Size(202, 307);
            this.TMagicBox.TabIndex = 3;
            this.TMagicBox.TabStop = false;
            this.TMagicBox.Enter += new System.EventHandler(this.TMagicBox_Enter);
            // 
            // MagicBraveOrdersBtn
            // 
            this.MagicBraveOrdersBtn.Location = new System.Drawing.Point(14, 178);
            this.MagicBraveOrdersBtn.Name = "MagicBraveOrdersBtn";
            this.MagicBraveOrdersBtn.Size = new System.Drawing.Size(91, 23);
            this.MagicBraveOrdersBtn.TabIndex = 10;
            this.MagicBraveOrdersBtn.Text = "Brave Orders";
            this.MagicBraveOrdersBtn.UseVisualStyleBackColor = true;
            this.MagicBraveOrdersBtn.Click += new System.EventHandler(this.MagicBraveOrdersBtn_Click);
            // 
            // MagicDivineLinkAttacksBtn
            // 
            this.MagicDivineLinkAttacksBtn.Location = new System.Drawing.Point(112, 149);
            this.MagicDivineLinkAttacksBtn.Name = "MagicDivineLinkAttacksBtn";
            this.MagicDivineLinkAttacksBtn.Size = new System.Drawing.Size(75, 23);
            this.MagicDivineLinkAttacksBtn.TabIndex = 9;
            this.MagicDivineLinkAttacksBtn.Text = "Divine";
            this.MagicDivineLinkAttacksBtn.UseVisualStyleBackColor = true;
            this.MagicDivineLinkAttacksBtn.Click += new System.EventHandler(this.MagicDivineLinkAttacksBtn_Click);
            // 
            // MagicLinkAttacksBtn
            // 
            this.MagicLinkAttacksBtn.Location = new System.Drawing.Point(14, 149);
            this.MagicLinkAttacksBtn.Name = "MagicLinkAttacksBtn";
            this.MagicLinkAttacksBtn.Size = new System.Drawing.Size(92, 23);
            this.MagicLinkAttacksBtn.TabIndex = 8;
            this.MagicLinkAttacksBtn.Text = "Link Attacks";
            this.MagicLinkAttacksBtn.UseVisualStyleBackColor = true;
            this.MagicLinkAttacksBtn.Click += new System.EventHandler(this.MagicLinkAttacksBtn_Click);
            // 
            // MagicLinkAbilitiesBtn
            // 
            this.MagicLinkAbilitiesBtn.Location = new System.Drawing.Point(14, 120);
            this.MagicLinkAbilitiesBtn.Name = "MagicLinkAbilitiesBtn";
            this.MagicLinkAbilitiesBtn.Size = new System.Drawing.Size(92, 23);
            this.MagicLinkAbilitiesBtn.TabIndex = 7;
            this.MagicLinkAbilitiesBtn.Text = "Link Abilities";
            this.MagicLinkAbilitiesBtn.UseVisualStyleBackColor = true;
            this.MagicLinkAbilitiesBtn.Click += new System.EventHandler(this.MagicLinkAbilitiesBtn_Click);
            // 
            // MagicSCraftBtn
            // 
            this.MagicSCraftBtn.Location = new System.Drawing.Point(14, 91);
            this.MagicSCraftBtn.Name = "MagicSCraftBtn";
            this.MagicSCraftBtn.Size = new System.Drawing.Size(92, 23);
            this.MagicSCraftBtn.TabIndex = 6;
            this.MagicSCraftBtn.Text = "S Crafts";
            this.MagicSCraftBtn.UseVisualStyleBackColor = true;
            this.MagicSCraftBtn.Click += new System.EventHandler(this.MagicSCraftBtn_Click);
            // 
            // MagicDivineArtsBtn
            // 
            this.MagicDivineArtsBtn.Location = new System.Drawing.Point(112, 62);
            this.MagicDivineArtsBtn.Name = "MagicDivineArtsBtn";
            this.MagicDivineArtsBtn.Size = new System.Drawing.Size(75, 23);
            this.MagicDivineArtsBtn.TabIndex = 5;
            this.MagicDivineArtsBtn.Text = "Divine";
            this.MagicDivineArtsBtn.UseVisualStyleBackColor = true;
            this.MagicDivineArtsBtn.Click += new System.EventHandler(this.MagicDivineArtsBtn_Click);
            // 
            // MagicDivineCraftsBtn
            // 
            this.MagicDivineCraftsBtn.Location = new System.Drawing.Point(112, 33);
            this.MagicDivineCraftsBtn.Name = "MagicDivineCraftsBtn";
            this.MagicDivineCraftsBtn.Size = new System.Drawing.Size(75, 23);
            this.MagicDivineCraftsBtn.TabIndex = 4;
            this.MagicDivineCraftsBtn.Text = "Divine";
            this.MagicDivineCraftsBtn.UseVisualStyleBackColor = true;
            this.MagicDivineCraftsBtn.Click += new System.EventHandler(this.MagicDivineCraftsBtn_Click);
            // 
            // MagicArtsBtn
            // 
            this.MagicArtsBtn.Location = new System.Drawing.Point(14, 62);
            this.MagicArtsBtn.Name = "MagicArtsBtn";
            this.MagicArtsBtn.Size = new System.Drawing.Size(92, 23);
            this.MagicArtsBtn.TabIndex = 3;
            this.MagicArtsBtn.Text = "Arts";
            this.MagicArtsBtn.UseVisualStyleBackColor = true;
            this.MagicArtsBtn.Click += new System.EventHandler(this.MagicArtsBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(1032, 325);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OpenStatusEffectsBtn
            // 
            this.OpenStatusEffectsBtn.Location = new System.Drawing.Point(1113, 41);
            this.OpenStatusEffectsBtn.Name = "OpenStatusEffectsBtn";
            this.OpenStatusEffectsBtn.Size = new System.Drawing.Size(93, 23);
            this.OpenStatusEffectsBtn.TabIndex = 5;
            this.OpenStatusEffectsBtn.Text = "Status Effects";
            this.OpenStatusEffectsBtn.UseVisualStyleBackColor = true;
            this.OpenStatusEffectsBtn.Click += new System.EventHandler(this.OpenStatusEffectsBtn_Click);
            // 
            // GeneralInfo
            // 
            this.GeneralInfo.Location = new System.Drawing.Point(1113, 12);
            this.GeneralInfo.Name = "GeneralInfo";
            this.GeneralInfo.Size = new System.Drawing.Size(92, 23);
            this.GeneralInfo.TabIndex = 6;
            this.GeneralInfo.Text = "General Info";
            this.GeneralInfo.UseVisualStyleBackColor = true;
            this.GeneralInfo.Click += new System.EventHandler(this.GeneralInfo_Click);
            // 
            // MagicTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 359);
            this.Controls.Add(this.GeneralInfo);
            this.Controls.Add(this.OpenStatusEffectsBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TMagicBox);
            this.Controls.Add(this.TMagicList);
            this.Name = "MagicTableForm";
            this.Text = "Magic Table";
            this.TMagicBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TMagicList;
        private System.Windows.Forms.Button MagicCraftsBtn;
        private System.Windows.Forms.GroupBox TMagicBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button MagicArtsBtn;
        private System.Windows.Forms.Button MagicDivineCraftsBtn;
        private System.Windows.Forms.Button MagicDivineArtsBtn;
        private System.Windows.Forms.Button MagicSCraftBtn;
        private System.Windows.Forms.Button MagicLinkAbilitiesBtn;
        private System.Windows.Forms.Button MagicLinkAttacksBtn;
        private System.Windows.Forms.Button MagicDivineLinkAttacksBtn;
        private System.Windows.Forms.Button MagicBraveOrdersBtn;
        private System.Windows.Forms.Button OpenStatusEffectsBtn;
        private System.Windows.Forms.Button GeneralInfo;
    }
}

