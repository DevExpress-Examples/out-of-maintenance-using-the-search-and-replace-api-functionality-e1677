Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
#End Region ' #usings
Imports DevExpress.XtraEditors

Namespace SearchAndReplaceExample
    Public Partial Class Form1
        Inherits Form
        Private searchString As String = String.Empty
        Private replaceString As String = String.Empty

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument("RichEditAbout.rtf", DocumentFormat.Rtf)

        End Sub
        #Region "#isearchresult"
        Private searchResult_Renamed As ISearchResult
        Private ReadOnly Property Document() As Document
            Get
                Return Me.richEditControl1.Document
            End Get
        End Property
        Private direction As SearchDirection = SearchDirection.Forward
        Private options As SearchOptions = SearchOptions.WholeWord Or _
          SearchOptions.CaseSensitive

        Private ReadOnly Property SearchResult() As ISearchResult
            Get
                If searchResult_Renamed Is Nothing Then
                    searchResult_Renamed = CreateSearchResult()
                End If
                Return searchResult_Renamed
            End Get
        End Property
        Private Function CreateSearchResult() As ISearchResult
            Dim range As DocumentRange
            If direction = SearchDirection.Forward Then
                Dim startPos As Integer = Document.Selection.End.ToInt()
                Dim length As Integer = Document.Range.End.ToInt() - startPos
                range = Document.CreateRange(startPos, length)
            Else
                Dim length As Integer = Document.Selection.Start.ToInt()
                range = Document.CreateRange(0, length)
            End If
            Return Document.StartSearch(searchString, options, direction, range)
        End Function
        Private Function FindNext() As Boolean
            If SearchStringIsEmpty() Then
                Return False
            End If
            If SearchResult.FindNext() Then
                Document.Selection = SearchResult.CurrentResult
                Me.richEditControl1.ScrollToCaret()
                Return True
            Else
                XtraMessageBox.Show("Search is complete.", Application.ProductName)
                Return False
            End If
        End Function
        #End Region ' #isearchresult
        Private Function SearchStringIsEmpty() As Boolean
            If String.IsNullOrEmpty(searchString) Then
                XtraMessageBox.Show("Search string is empty!", Application.ProductName)
                Return True
            End If
            Return False
        End Function

        #Region "Button Click Handlers"
        Private Sub btnFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFind.Click
            FindNext()
        End Sub
        Private Sub btnReplace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindReplace.Click
            Do While FindNext()
                Dim doReplace As DialogResult = XtraMessageBox.Show("Selected text will be replaced." & Constants.vbLf & "Proceed?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If doReplace = DialogResult.Yes Then
                    SearchResult.Replace(Me.replaceString)
                End If
            Loop
        End Sub
        Private Sub btnFindAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindAll.Click
            If SearchStringIsEmpty() Then
                Return
            End If
            Dim ranges As DocumentRange() = Document.FindAll(Me.searchString, options)
            XtraMessageBox.Show(String.Format("{0} matches were found.", ranges.Length), Application.ProductName)
        End Sub
        Private Sub btnReplaceAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReplaceAll.Click
            If SearchStringIsEmpty() Then
                Return
            End If
            Dim result As Integer = Document.ReplaceAll(Me.searchString, Me.replaceString, options)
            XtraMessageBox.Show(String.Format("{0} replacements were made.", result), Application.ProductName)
        End Sub
        #End Region ' ButtonClick handlers

        #Region "Options Change Handlers"
        Private Sub textEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtFindWhat.EditValueChanged
            Me.searchString = Me.txtFindWhat.Text
            Me.searchResult_Renamed = Nothing
        End Sub
        Private Sub txtReplaceWith_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtReplaceWith.EditValueChanged
            Me.replaceString = Me.txtReplaceWith.Text
        End Sub
        Private Sub chbWholeWord_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbWholeWord.CheckedChanged
            If Me.chbWholeWord.Checked Then
                Me.options = Me.options Or SearchOptions.WholeWord
            Else
                Me.options = Me.options And Not SearchOptions.WholeWord
            End If
            Me.searchResult_Renamed = Nothing
        End Sub
        Private Sub chbMatchCase_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbMatchCase.CheckedChanged
            If Me.chbMatchCase.Checked Then
                Me.options = Me.options Or SearchOptions.CaseSensitive
            Else
                Me.options = Me.options And Not SearchOptions.CaseSensitive
            End If
            Me.searchResult_Renamed = Nothing
        End Sub
        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
            If Me.radioGroup1.SelectedIndex = 0 Then
                Me.direction = SearchDirection.Forward
            Else
                Me.direction = SearchDirection.Backward
            End If
            Me.searchResult_Renamed = Nothing
        End Sub
        #End Region ' Other Form Control handlers

    End Class
End Namespace