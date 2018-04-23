Imports Microsoft.VisualBasic
Imports System
Namespace SearchAndReplaceExample
    Public Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup
            Me.chbMatchCase = New DevExpress.XtraEditors.CheckEdit
            Me.chbWholeWord = New DevExpress.XtraEditors.CheckEdit
            Me.btnReplaceAll = New DevExpress.XtraEditors.SimpleButton
            Me.btnFindAll = New DevExpress.XtraEditors.SimpleButton
            Me.btnFindReplace = New DevExpress.XtraEditors.SimpleButton
            Me.btnFind = New DevExpress.XtraEditors.SimpleButton
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.txtReplaceWith = New DevExpress.XtraEditors.TextEdit
            Me.txtFindWhat = New DevExpress.XtraEditors.TextEdit
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chbMatchCase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chbWholeWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtReplaceWith.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtFindWhat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.radioGroup1)
            Me.panelControl1.Controls.Add(Me.chbMatchCase)
            Me.panelControl1.Controls.Add(Me.chbWholeWord)
            Me.panelControl1.Controls.Add(Me.btnReplaceAll)
            Me.panelControl1.Controls.Add(Me.btnFindAll)
            Me.panelControl1.Controls.Add(Me.btnFindReplace)
            Me.panelControl1.Controls.Add(Me.btnFind)
            Me.panelControl1.Controls.Add(Me.labelControl2)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.txtReplaceWith)
            Me.panelControl1.Controls.Add(Me.txtFindWhat)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(652, 126)
            Me.panelControl1.TabIndex = 1
            '
            'radioGroup1
            '
            Me.radioGroup1.Location = New System.Drawing.Point(7, 40)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroup1.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroup1.Properties.Columns = 2
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Down"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Up")})
            Me.radioGroup1.Size = New System.Drawing.Size(112, 25)
            Me.radioGroup1.TabIndex = 9
            '
            'chbMatchCase
            '
            Me.chbMatchCase.EditValue = True
            Me.chbMatchCase.Location = New System.Drawing.Point(135, 67)
            Me.chbMatchCase.Name = "chbMatchCase"
            Me.chbMatchCase.Properties.Caption = "Match Case"
            Me.chbMatchCase.Size = New System.Drawing.Size(86, 19)
            Me.chbMatchCase.TabIndex = 8
            '
            'chbWholeWord
            '
            Me.chbWholeWord.EditValue = True
            Me.chbWholeWord.Location = New System.Drawing.Point(135, 38)
            Me.chbWholeWord.Name = "chbWholeWord"
            Me.chbWholeWord.Properties.Caption = "Whole Word"
            Me.chbWholeWord.Size = New System.Drawing.Size(86, 19)
            Me.chbWholeWord.TabIndex = 7
            '
            'btnReplaceAll
            '
            Me.btnReplaceAll.Location = New System.Drawing.Point(238, 92)
            Me.btnReplaceAll.Name = "btnReplaceAll"
            Me.btnReplaceAll.Size = New System.Drawing.Size(98, 23)
            Me.btnReplaceAll.TabIndex = 5
            Me.btnReplaceAll.Text = "Replace All"
            '
            'btnFindAll
            '
            Me.btnFindAll.Location = New System.Drawing.Point(238, 34)
            Me.btnFindAll.Name = "btnFindAll"
            Me.btnFindAll.Size = New System.Drawing.Size(98, 23)
            Me.btnFindAll.TabIndex = 6
            Me.btnFindAll.Text = "Find All"
            '
            'btnFindReplace
            '
            Me.btnFindReplace.Location = New System.Drawing.Point(238, 63)
            Me.btnFindReplace.Name = "btnFindReplace"
            Me.btnFindReplace.Size = New System.Drawing.Size(98, 23)
            Me.btnFindReplace.TabIndex = 5
            Me.btnFindReplace.Text = "Find and Replace"
            '
            'btnFind
            '
            Me.btnFind.Location = New System.Drawing.Point(238, 5)
            Me.btnFind.Name = "btnFind"
            Me.btnFind.Size = New System.Drawing.Size(98, 23)
            Me.btnFind.TabIndex = 4
            Me.btnFind.Text = "Find"
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(7, 99)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(67, 13)
            Me.labelControl2.TabIndex = 3
            Me.labelControl2.Text = "Replace With:"
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(7, 9)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(53, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "Find What:"
            '
            'txtReplaceWith
            '
            Me.txtReplaceWith.Location = New System.Drawing.Point(80, 95)
            Me.txtReplaceWith.Name = "txtReplaceWith"
            Me.txtReplaceWith.Size = New System.Drawing.Size(141, 20)
            Me.txtReplaceWith.TabIndex = 1
            '
            'txtFindWhat
            '
            Me.txtFindWhat.Location = New System.Drawing.Point(80, 6)
            Me.txtFindWhat.Name = "txtFindWhat"
            Me.txtFindWhat.Size = New System.Drawing.Size(141, 20)
            Me.txtFindWhat.TabIndex = 0
            '
            'richEditControl1
            '
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 126)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(652, 256)
            Me.richEditControl1.TabIndex = 2
            Me.richEditControl1.Text = "richEditControl1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(652, 382)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chbMatchCase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chbWholeWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtReplaceWith.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtFindWhat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents txtReplaceWith As DevExpress.XtraEditors.TextEdit
        Private WithEvents txtFindWhat As DevExpress.XtraEditors.TextEdit
        Private WithEvents btnReplaceAll As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnFindAll As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnFindReplace As DevExpress.XtraEditors.SimpleButton
        Private WithEvents chbMatchCase As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chbWholeWord As DevExpress.XtraEditors.CheckEdit
        Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
    End Class
End Namespace

