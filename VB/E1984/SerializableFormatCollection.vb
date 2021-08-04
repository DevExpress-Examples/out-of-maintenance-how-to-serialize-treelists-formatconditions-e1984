Imports DevExpress.XtraTreeList.StyleFormatConditions
Imports System.Collections

Namespace E1984
    Public Class SerializableFormatCollection
        Inherits CollectionBase

        Public Sub New(ByVal collection As StyleFormatConditionCollection)
            CopyFromStyleFormats(collection)
        End Sub

        Public Sub New()
        End Sub

        Public Function Add() As SerializableFormatCondition
            Dim serializableFormat As SerializableFormatCondition = New SerializableFormatCondition()
            InnerList.Add(serializableFormat)
            Return serializableFormat
        End Function

        Public Sub CopyFromStyleFormats(ByVal styles As StyleFormatConditionCollection)
            Clear()

            For Each style As StyleFormatCondition In styles
                Dim serializableFormat As SerializableFormatCondition = New SerializableFormatCondition()
                serializableFormat.CopyFromStyleFormat(style)
                InnerList.Add(serializableFormat)
            Next
        End Sub

        Public Sub CopyToStyleFormats(ByVal styles As StyleFormatConditionCollection)
            styles.Clear()

            For Each serializableFormat As SerializableFormatCondition In Me
                Dim style As StyleFormatCondition = New StyleFormatCondition()
                styles.Add(style)
                serializableFormat.CopyToStyleFormat(style)
            Next
        End Sub
    End Class
End Namespace
