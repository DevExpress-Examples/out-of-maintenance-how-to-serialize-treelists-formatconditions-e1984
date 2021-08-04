Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Serializing

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			tbl.Columns.Add("ParentID", GetType(Integer))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i + 1, 3 - i, DateTime.Now.AddDays(i), i Mod 3 })
			Next i
			Return tbl
		End Function


		Public Sub New()
			InitializeComponent()
			treeList1.DataSource = CreateTable(30)
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			MessageBox.Show("Save")
			MyTreeListSerializeHelper.SelectedTreeList = treeList1
			MyTreeListSerializeHelper.SaveTreeList()
			MessageBox.Show("Clear")
			treeList1.FormatConditions.Clear()
			MessageBox.Show("Restore")
			MyTreeListSerializeHelper.RestoreTreeList()
		End Sub
	End Class

End Namespace