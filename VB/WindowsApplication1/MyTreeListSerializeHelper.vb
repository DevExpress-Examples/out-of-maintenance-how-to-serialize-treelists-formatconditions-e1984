Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraTreeList
Imports System.IO

Namespace WindowsApplication1
	Public NotInheritable Class MyTreeListSerializeHelper
		Public Shared DefaultFileName As String = "test.xml"
		Public Shared SelectedTreeList As TreeList

		Private Sub New()
		End Sub
		Public Shared Sub SaveTreeList()
			SaveTreeList(SelectedTreeList, DefaultFileName)
		End Sub

		Public Shared Sub RestoreTreeList()
			RestoreTreeList(SelectedTreeList, DefaultFileName)
		End Sub



		Private Shared Sub SaveTreeList(ByVal treeList As TreeList, ByVal fileName As String)
			treeList.SaveLayoutToXml(fileName)
			SaveConditions(treeList, "Conditions" & fileName)
		End Sub

		Private Shared Sub SaveConditions(ByVal treeList As TreeList, ByVal fileName As String)
			Dim serializer As New XmlXtraSerializer()
			Using stream As New FileStream(fileName, FileMode.OpenOrCreate)
				Try
					Dim collection As New TreeListFormatConditions(treeList.FormatConditions)
					serializer.SerializeObject(collection, stream, "FormatConditions")
				Finally
					stream.Close()
				End Try
			End Using
		End Sub

		Private Shared Sub RestoreTreeList(ByVal treeList As TreeList, ByVal fileName As String)
			treeList.RestoreLayoutFromXml(fileName)
			RestoreConditions(treeList, "Conditions" & fileName)
		End Sub


		Private Shared Sub RestoreConditions(ByVal treeList As TreeList, ByVal fileName As String)
			If (Not File.Exists(fileName)) Then
				Return
			End If
			Dim serializer As New XmlXtraSerializer()
			Using stream As New FileStream(fileName, FileMode.Open)
				Try
					Dim collection As New TreeListFormatConditions()
					serializer.DeserializeObject(collection, stream, "FormatConditions")
					collection.Conditions.CopyToStyleFormats(treeList.FormatConditions)
					treeList.Refresh()
				Finally
					stream.Close()
				End Try
			End Using
		End Sub
	End Class
End Namespace
