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
	Public Class TreeListFormatConditions

		Private _conditions As SerializableFormatCollection

		Public Sub New()
			_conditions = New SerializableFormatCollection()
		End Sub

		Public Sub New(ByVal styles As StyleFormatConditionCollection)
			_conditions = New SerializableFormatCollection(styles)
		End Sub

		<XtraSerializableProperty(XtraSerializationVisibility.Collection, True, False, True, 0, XtraSerializationFlags.None)> _
		Public ReadOnly Property Conditions() As SerializableFormatCollection
			Get
				Return _conditions
			End Get
		End Property

		Private Function XtraCreateConditionsItem(ByVal e As XtraItemEventArgs) As Object
			Return Conditions.Add()
		End Function
	End Class
End Namespace
