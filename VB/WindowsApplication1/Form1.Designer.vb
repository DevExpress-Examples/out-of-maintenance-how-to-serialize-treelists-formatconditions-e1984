Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim styleFormatCondition1 As New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition()
			Dim styleFormatCondition2 As New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "Number"
			Me.treeListColumn2.FieldName = "Number"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(128))))))
			styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
			styleFormatCondition1.Appearance.Options.UseBackColor = True
			styleFormatCondition1.Appearance.Options.UseForeColor = True
			styleFormatCondition1.ApplyToRow = True
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual
			styleFormatCondition1.Value1 = "-z"
			styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
			styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.Yellow
			styleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			styleFormatCondition2.Appearance.Options.UseBackColor = True
			styleFormatCondition2.ApplyToRow = True
			styleFormatCondition2.Column = Me.treeListColumn2
			styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
			styleFormatCondition2.Value1 = -12
			Me.treeList1.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() { styleFormatCondition1, styleFormatCondition2})
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(572, 482)
			Me.treeList1.TabIndex = 0
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Name"
			Me.treeListColumn1.FieldName = "Nane"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(123, 360)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(339, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Test"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(572, 482)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace

