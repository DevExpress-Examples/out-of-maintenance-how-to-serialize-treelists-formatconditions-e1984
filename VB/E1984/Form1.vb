Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace E1984
    Public Partial Class Form1
        Inherits Form

        Private Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("Name", GetType(String))
            tbl.Columns.Add("ID", GetType(Integer))
            tbl.Columns.Add("Number", GetType(Integer))
            tbl.Columns.Add("Date", GetType(Date))
            tbl.Columns.Add("ParentID", GetType(Integer))

            For i = 0 To RowCount - 1
                tbl.Rows.Add(New Object() {String.Format("Name{0}", i), i + 1, 3 - i, Date.Now.AddDays(i), i Mod 3})
            Next

            Return tbl
        End Function

        Public Sub New()
            InitializeComponent()
            treeList1.DataSource = CreateTable(30)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("Save")
            treeList1.SaveLayoutToXml(DefaultFileName)
            MessageBox.Show("Clear")
            treeList1.FormatRules.Clear()
            MessageBox.Show("Restore")
            treeList1.RestoreLayoutFromXml(DefaultFileName)
        End Sub
    End Class
End Namespace
