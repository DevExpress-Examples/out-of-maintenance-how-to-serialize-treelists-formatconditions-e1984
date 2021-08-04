Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraTreeList
Imports System.IO

Namespace E1984
	Public Module MyTreeListSerializeHelper
		Public DefaultFileName As String = "test.xml"
		Public SelectedTreeList As TreeList

		Public Sub SaveTreeList()
			SaveTreeList(SelectedTreeList, DefaultFileName)
		End Sub

		Public Sub RestoreTreeList()
			RestoreTreeList(SelectedTreeList, DefaultFileName)
		End Sub



		Private Sub SaveTreeList(ByVal treeList As TreeList, ByVal fileName As String)
			treeList.SaveLayoutToXml(fileName)
			SaveConditions(treeList, "Conditions" & fileName)
		End Sub

		Private Sub SaveConditions(ByVal treeList As TreeList, ByVal fileName As String)
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

		Private Sub RestoreTreeList(ByVal treeList As TreeList, ByVal fileName As String)
			treeList.RestoreLayoutFromXml(fileName)
			RestoreConditions(treeList, "Conditions" & fileName)
		End Sub


		Private Sub RestoreConditions(ByVal treeList As TreeList, ByVal fileName As String)
			If Not File.Exists(fileName) Then
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
	End Module
End Namespace
