using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using DevExpress.XtraTreeList.StyleFormatConditions;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.Utils.Serializing;

namespace WindowsApplication1
{
    public class SerializableFormatCondition
    {

        private AppearanceObject _appearance = new AppearanceObject();

        private bool _applyToRow;

        private string _columnName = "";

        private FormatConditionEnum _condition;

        private object _value1;

        private object _value2;

        private object _expression;


        [XtraSerializableProperty(XtraSerializationVisibility.Content)]
        public AppearanceObject Appearance
        {
            get { return _appearance; }
            set { _appearance.Assign(value); }
        }

        [XtraSerializableProperty()]
        public string ColumnName
        {
            get { return _columnName; }
            set { _columnName = value; }
        }

        [XtraSerializableProperty()]
        public FormatConditionEnum Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        [XtraSerializableProperty()]
        public bool ApplyToRow
        {
            get { return _applyToRow; }
            set { _applyToRow = value; }
        }

        [XtraSerializableProperty()]
        public object Value1
        {
            get { return _value1; }
            set { _value1 = value; }
        }

        [XtraSerializableProperty()]
        public object Value2
        {
            get { return _value2; }
            set { _value2 = value; }
        }
        [XtraSerializableProperty()]
        public object Expression
        {
            get { return _expression; }
            set { _expression = value; }
        }
        public void CopyFromStyleFormat(StyleFormatCondition style)
        {
            Appearance = style.Appearance;
            ApplyToRow = style.ApplyToRow;
            ColumnName = style.Column == null? string.Empty:  style.Column.Name;
            Condition = style.Condition;
            Value1 = style.Value1;
            Value2 = style.Value2;
            Expression = style.Expression;
        }

        public void CopyToStyleFormat(StyleFormatCondition style)
        {
            style.Appearance.Assign(Appearance);
            style.ApplyToRow = ApplyToRow;
            style.Column = ((StyleFormatConditionCollection)style.Collection).TreeListControl.Columns.ColumnByName(ColumnName);
            style.Condition = Condition;
            style.Value1 = Value1;
            style.Value2 = Value2;
            style.Expression = Expression.ToString();
        }
    }
}