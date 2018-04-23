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
	Public Class SerializableFormatCondition

		Private _appearance As New AppearanceObject()

		Private _applyToRow As Boolean

		Private _columnName As String = ""

		Private _condition As FormatConditionEnum

		Private _value1 As Object

		Private _value2 As Object

		Private _expression As Object


		<XtraSerializableProperty(XtraSerializationVisibility.Content)> _
		Public Property Appearance() As AppearanceObject
			Get
				Return _appearance
			End Get
			Set(ByVal value As AppearanceObject)
				_appearance.Assign(value)
			End Set
		End Property

		<XtraSerializableProperty()> _
		Public Property ColumnName() As String
			Get
				Return _columnName
			End Get
			Set(ByVal value As String)
				_columnName = value
			End Set
		End Property

		<XtraSerializableProperty()> _
		Public Property Condition() As FormatConditionEnum
			Get
				Return _condition
			End Get
			Set(ByVal value As FormatConditionEnum)
				_condition = value
			End Set
		End Property

		<XtraSerializableProperty()> _
		Public Property ApplyToRow() As Boolean
			Get
				Return _applyToRow
			End Get
			Set(ByVal value As Boolean)
				_applyToRow = value
			End Set
		End Property

		<XtraSerializableProperty()> _
		Public Property Value1() As Object
			Get
				Return _value1
			End Get
			Set(ByVal value As Object)
				_value1 = value
			End Set
		End Property

		<XtraSerializableProperty()> _
		Public Property Value2() As Object
			Get
				Return _value2
			End Get
			Set(ByVal value As Object)
				_value2 = value
			End Set
		End Property
		<XtraSerializableProperty()> _
		Public Property Expression() As Object
			Get
				Return _expression
			End Get
			Set(ByVal value As Object)
				_expression = value
			End Set
		End Property
		Public Sub CopyFromStyleFormat(ByVal style As StyleFormatCondition)
			Appearance = style.Appearance
			ApplyToRow = style.ApplyToRow
			If style.Column Is Nothing Then
				ColumnName = String.Empty
			Else
				ColumnName = style.Column.Name
			End If
			Condition = style.Condition
			Value1 = style.Value1
			Value2 = style.Value2
			Expression = style.Expression
		End Sub

		Public Sub CopyToStyleFormat(ByVal style As StyleFormatCondition)
			style.Appearance.Assign(Appearance)
			style.ApplyToRow = ApplyToRow
			style.Column = (CType(style.Collection, StyleFormatConditionCollection)).TreeListControl.Columns.ColumnByName(ColumnName)
			style.Condition = Condition
			style.Value1 = Value1
			style.Value2 = Value2
			style.Expression = Expression.ToString()
		End Sub
	End Class
End Namespace