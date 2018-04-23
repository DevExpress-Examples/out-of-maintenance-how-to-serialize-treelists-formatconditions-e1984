Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports DevExpress.XtraTreeList.StyleFormatConditions
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.Utils.Serializing

Namespace WindowsApplication1
	Public Class SerializableFormatCollection
		Inherits CollectionBase
		Public Sub New(ByVal collection As StyleFormatConditionCollection)
			CopyFromStyleFormats(collection)
		End Sub

		Public Sub New()
		End Sub


		Public Function Add() As SerializableFormatCondition
			Dim serializableFormat As New SerializableFormatCondition()
			InnerList.Add(serializableFormat)
			Return serializableFormat
		End Function

		Public Sub CopyFromStyleFormats(ByVal styles As StyleFormatConditionCollection)
			Clear()
			For Each style As StyleFormatCondition In styles
				Dim serializableFormat As New SerializableFormatCondition()
				serializableFormat.CopyFromStyleFormat(style)
				InnerList.Add(serializableFormat)
			Next style
		End Sub

		Public Sub CopyToStyleFormats(ByVal styles As StyleFormatConditionCollection)
			styles.Clear()
			For Each serializableFormat As SerializableFormatCondition In Me
				Dim style As New StyleFormatCondition()
				styles.Add(style)
				serializableFormat.CopyToStyleFormat(style)
			Next serializableFormat
		End Sub
	End Class
End Namespace
