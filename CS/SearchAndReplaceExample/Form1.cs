using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
#endregion #usings
using DevExpress.XtraEditors;

namespace SearchAndReplaceExample {
    public partial class Form1 : Form {
        string searchString = String.Empty;
        string replaceString = String.Empty;

        public Form1() {
            InitializeComponent();
            richEditControl1.LoadDocument("RichEditAbout.rtf", DocumentFormat.Rtf);

        }
        #region #isearchresult
        ISearchResult searchResult;
        Document Document { get { return this.richEditControl1.Document; } }
        SearchDirection direction = SearchDirection.Forward;
        SearchOptions options = SearchOptions.WholeWord |
            SearchOptions.CaseSensitive;

        ISearchResult SearchResult {
            get {
                if (searchResult == null)
                    searchResult = CreateSearchResult();
                return searchResult;
            }
        }
        private ISearchResult CreateSearchResult() {
            DocumentRange range;
            if (direction == SearchDirection.Forward) {
                int startPos = Document.Selection.End.ToInt();
                int length = Document.Range.End.ToInt() - startPos;
                range = Document.CreateRange(startPos, length);
            }
            else {
                int length = Document.Selection.Start.ToInt();
                range = Document.CreateRange(0, length);
            }
            return Document.StartSearch(searchString, options, direction, range);
        }
        private bool FindNext() {
            if(SearchStringIsEmpty())
                return false;
            if(SearchResult.FindNext()) {
                Document.Selection = SearchResult.CurrentResult;
                this.richEditControl1.ScrollToCaret();
                return true;
            }
            else {
                XtraMessageBox.Show("Search is complete.", Application.ProductName);
                return false;
            }
        }
        #endregion #isearchresult
        private bool SearchStringIsEmpty() {
            if(String.IsNullOrEmpty(searchString)) {
                XtraMessageBox.Show("Search string is empty!", Application.ProductName);
                return true;
            }
            return false;
        }

        #region Button Click Handlers
        private void btnFind_Click(object sender, EventArgs e) {
            FindNext();
        }
        private void btnReplace_Click(object sender, EventArgs e) {            
            while(FindNext()) {
                DialogResult doReplace = XtraMessageBox.Show("Selected text will be replaced.\nProceed?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(doReplace == DialogResult.Yes)
                    SearchResult.Replace(this.replaceString);
            } 
        }
        private void btnFindAll_Click(object sender, EventArgs e) {
            if (SearchStringIsEmpty())
                return;
            DocumentRange[] ranges = Document.FindAll(this.searchString, options);
            XtraMessageBox.Show(String.Format("{0} matches were found.", ranges.Length), Application.ProductName);
        }
        private void btnReplaceAll_Click(object sender, EventArgs e) {
            if (SearchStringIsEmpty())
                return;
            int result = Document.ReplaceAll(this.searchString, this.replaceString, options);
            XtraMessageBox.Show(String.Format("{0} replacements were made.", result), Application.ProductName);
        }
        #endregion ButtonClick handlers

        #region Options Change Handlers
        private void textEdit1_EditValueChanged(object sender, EventArgs e) {
            this.searchString = this.txtFindWhat.Text;
            this.searchResult = null;
        }
        private void txtReplaceWith_EditValueChanged(object sender, EventArgs e) {
            this.replaceString = this.txtReplaceWith.Text;
        }
        private void chbWholeWord_CheckedChanged(object sender, EventArgs e) {
            if (this.chbWholeWord.Checked)
                this.options |= SearchOptions.WholeWord;
            else
                this.options &= ~SearchOptions.WholeWord;
            this.searchResult = null;
        }
        private void chbMatchCase_CheckedChanged(object sender, EventArgs e) {
            if (this.chbMatchCase.Checked)
                this.options |= SearchOptions.CaseSensitive;
            else
                this.options &= ~SearchOptions.CaseSensitive;
            this.searchResult = null;
        }
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.radioGroup1.SelectedIndex == 0)
                this.direction = SearchDirection.Forward;
            else
                this.direction = SearchDirection.Backward;
            this.searchResult = null;
        }
        #endregion Other Form Control handlers

    }
}