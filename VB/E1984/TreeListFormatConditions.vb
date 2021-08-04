Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraTreeList.StyleFormatConditions

Namespace E1984
	Public Class TreeListFormatConditions

		Private _conditions As SerializableFormatCollection

		Public Sub New()
			_conditions = New SerializableFormatCollection()
		End Sub

		Public Sub New(ByVal styles As StyleFormatConditionCollection)
			_conditions = New SerializableFormatCollection(styles)
		End Sub

		<XtraSerializableProperty(XtraSerializationVisibility.Collection, True, False, True, 0, XtraSerializationFlags.None)>
		Public Conditions As Function(SerializableFormatCollection) _conditions

		Private Function XtraCreateConditionsItem(ByVal e As XtraItemEventArgs) As Object
			Return Conditions.Add()
		End Function
	End Class
End Namespace
