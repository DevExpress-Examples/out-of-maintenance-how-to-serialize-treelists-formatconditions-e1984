Imports System

Namespace E1984
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
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
            Dim treeListFormatRule1 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim treeListFormatRule2 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
            Dim formatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            treeList1 = New DevExpress.XtraTreeList.TreeList()
            treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            button1 = New System.Windows.Forms.Button()
            CType(treeList1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' treeListColumn2
            ' 
            treeListColumn2.Caption = "Number"
            treeListColumn2.FieldName = "Number"
            treeListColumn2.Name = "treeListColumn2"
            treeListColumn2.Visible = True
            treeListColumn2.VisibleIndex = 1
            ' 
            ' treeList1
            ' 
            treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {treeListColumn1, treeListColumn2})
            treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            treeListFormatRule1.ApplyToRow = True
            treeListFormatRule1.Column = treeListColumn2
            treeListFormatRule1.Name = "Format0"
            formatConditionRuleValue1.Appearance.BackColor = Drawing.Color.FromArgb(255, 192, 128)
            formatConditionRuleValue1.Appearance.ForeColor = Drawing.Color.FromArgb(255, 255, 192)
            formatConditionRuleValue1.Appearance.Options.UseBackColor = True
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.NotEqual
            formatConditionRuleValue1.Value1 = -12
            treeListFormatRule1.Rule = formatConditionRuleValue1
            treeListFormatRule2.ApplyToRow = True
            treeListFormatRule2.Column = treeListColumn2
            treeListFormatRule2.Name = "Format1"
            formatConditionRuleValue2.Appearance.BackColor = Drawing.Color.Lime
            formatConditionRuleValue2.Appearance.BackColor2 = Drawing.Color.Yellow
            formatConditionRuleValue2.Appearance.GradientMode = Drawing.Drawing2D.LinearGradientMode.Vertical
            formatConditionRuleValue2.Appearance.Options.UseBackColor = True
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
            formatConditionRuleValue2.Value1 = -12
            treeListFormatRule2.Rule = formatConditionRuleValue2
            treeList1.FormatRules.Add(treeListFormatRule1)
            treeList1.FormatRules.Add(treeListFormatRule2)
            treeList1.Location = New Drawing.Point(0, 0)
            treeList1.Name = "treeList1"
            treeList1.Size = New Drawing.Size(572, 482)
            treeList1.TabIndex = 0
            ' 
            ' treeListColumn1
            ' 
            treeListColumn1.Caption = "Name"
            treeListColumn1.FieldName = "Nane"
            treeListColumn1.Name = "treeListColumn1"
            treeListColumn1.Visible = True
            treeListColumn1.VisibleIndex = 0
            ' 
            ' button1
            ' 
            button1.Location = New Drawing.Point(123, 360)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(339, 23)
            button1.TabIndex = 1
            button1.Text = "Test"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(572, 482)
            Controls.Add(button1)
            Controls.Add(treeList1)
            Name = "Form1"
            Text = "Form1"
            CType(treeList1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

#End Region

        Private treeList1 As DevExpress.XtraTreeList.TreeList
        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private button1 As System.Windows.Forms.Button
    End Class
End Namespace
