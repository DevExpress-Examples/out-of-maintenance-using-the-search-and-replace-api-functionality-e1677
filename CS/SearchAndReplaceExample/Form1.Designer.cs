namespace SearchAndReplaceExample {
    partial class Form1 {
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.chbMatchCase = new DevExpress.XtraEditors.CheckEdit();
            this.chbWholeWord = new DevExpress.XtraEditors.CheckEdit();
            this.btnReplaceAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnFindAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnFindReplace = new DevExpress.XtraEditors.SimpleButton();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtReplaceWith = new DevExpress.XtraEditors.TextEdit();
            this.txtFindWhat = new DevExpress.XtraEditors.TextEdit();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMatchCase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbWholeWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReplaceWith.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFindWhat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.radioGroup1);
            this.panelControl1.Controls.Add(this.chbMatchCase);
            this.panelControl1.Controls.Add(this.chbWholeWord);
            this.panelControl1.Controls.Add(this.btnReplaceAll);
            this.panelControl1.Controls.Add(this.btnFindAll);
            this.panelControl1.Controls.Add(this.btnFindReplace);
            this.panelControl1.Controls.Add(this.btnFind);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtReplaceWith);
            this.panelControl1.Controls.Add(this.txtFindWhat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(652, 126);
            this.panelControl1.TabIndex = 1;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(7, 40);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Down"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Up")});
            this.radioGroup1.Size = new System.Drawing.Size(112, 25);
            this.radioGroup1.TabIndex = 9;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // chbMatchCase
            // 
            this.chbMatchCase.EditValue = true;
            this.chbMatchCase.Location = new System.Drawing.Point(135, 67);
            this.chbMatchCase.Name = "chbMatchCase";
            this.chbMatchCase.Properties.Caption = "Match Case";
            this.chbMatchCase.Size = new System.Drawing.Size(86, 19);
            this.chbMatchCase.TabIndex = 8;
            this.chbMatchCase.CheckedChanged += new System.EventHandler(this.chbMatchCase_CheckedChanged);
            // 
            // chbWholeWord
            // 
            this.chbWholeWord.EditValue = true;
            this.chbWholeWord.Location = new System.Drawing.Point(135, 38);
            this.chbWholeWord.Name = "chbWholeWord";
            this.chbWholeWord.Properties.Caption = "Whole Word";
            this.chbWholeWord.Size = new System.Drawing.Size(86, 19);
            this.chbWholeWord.TabIndex = 7;
            this.chbWholeWord.CheckedChanged += new System.EventHandler(this.chbWholeWord_CheckedChanged);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(238, 92);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(98, 23);
            this.btnReplaceAll.TabIndex = 5;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(238, 34);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(98, 23);
            this.btnFindAll.TabIndex = 6;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnFindReplace
            // 
            this.btnFindReplace.Location = new System.Drawing.Point(238, 63);
            this.btnFindReplace.Name = "btnFindReplace";
            this.btnFindReplace.Size = new System.Drawing.Size(98, 23);
            this.btnFindReplace.TabIndex = 5;
            this.btnFindReplace.Text = "Find and Replace";
            this.btnFindReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(238, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Replace With:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Find What:";
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(80, 95);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(141, 20);
            this.txtReplaceWith.TabIndex = 1;
            this.txtReplaceWith.EditValueChanged += new System.EventHandler(this.txtReplaceWith_EditValueChanged);
            // 
            // txtFindWhat
            // 
            this.txtFindWhat.Location = new System.Drawing.Point(80, 6);
            this.txtFindWhat.Name = "txtFindWhat";
            this.txtFindWhat.Size = new System.Drawing.Size(141, 20);
            this.txtFindWhat.TabIndex = 0;
            this.txtFindWhat.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 126);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(652, 256);
            this.richEditControl1.TabIndex = 2;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 382);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMatchCase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbWholeWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReplaceWith.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFindWhat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtReplaceWith;
        private DevExpress.XtraEditors.TextEdit txtFindWhat;
        private DevExpress.XtraEditors.SimpleButton btnReplaceAll;
        private DevExpress.XtraEditors.SimpleButton btnFindAll;
        private DevExpress.XtraEditors.SimpleButton btnFindReplace;
        private DevExpress.XtraEditors.CheckEdit chbMatchCase;
        private DevExpress.XtraEditors.CheckEdit chbWholeWord;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}

