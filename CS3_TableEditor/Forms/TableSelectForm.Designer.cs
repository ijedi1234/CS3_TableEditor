namespace CS3_TableEditor.Forms {
    partial class TableSelectForm {
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
            this.MagicTableBtn = new System.Windows.Forms.Button();
            this.StatusTableBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MagicTableBtn
            // 
            this.MagicTableBtn.Location = new System.Drawing.Point(117, 73);
            this.MagicTableBtn.Name = "MagicTableBtn";
            this.MagicTableBtn.Size = new System.Drawing.Size(75, 23);
            this.MagicTableBtn.TabIndex = 0;
            this.MagicTableBtn.Text = "Magic";
            this.MagicTableBtn.UseVisualStyleBackColor = true;
            this.MagicTableBtn.Click += new System.EventHandler(this.MagicTableBtn_Click);
            // 
            // StatusTableBtn
            // 
            this.StatusTableBtn.Location = new System.Drawing.Point(265, 72);
            this.StatusTableBtn.Name = "StatusTableBtn";
            this.StatusTableBtn.Size = new System.Drawing.Size(75, 23);
            this.StatusTableBtn.TabIndex = 1;
            this.StatusTableBtn.Text = "Status";
            this.StatusTableBtn.UseVisualStyleBackColor = true;
            // 
            // TableSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusTableBtn);
            this.Controls.Add(this.MagicTableBtn);
            this.Name = "TableSelectForm";
            this.Text = "TableSelectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MagicTableBtn;
        private System.Windows.Forms.Button StatusTableBtn;
    }
}