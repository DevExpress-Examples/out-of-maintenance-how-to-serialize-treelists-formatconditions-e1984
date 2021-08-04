using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList.StyleFormatConditions;

namespace E1984 {
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
        public AppearanceObject Appearance {
            get => _appearance;
            set => _appearance.Assign(value);
        }

        [XtraSerializableProperty()]
        public string ColumnName {
            get => _columnName;
            set => _columnName = value;
        }

        [XtraSerializableProperty()]
        public FormatConditionEnum Condition {
            get => _condition;
            set => _condition = value;
        }

        [XtraSerializableProperty()]
        public bool ApplyToRow {
            get => _applyToRow;
            set => _applyToRow = value;
        }

        [XtraSerializableProperty()]
        public object Value1 {
            get => _value1;
            set => _value1 = value;
        }

        [XtraSerializableProperty()]
        public object Value2 {
            get => _value2;
            set => _value2 = value;
        }
        [XtraSerializableProperty()]
        public object Expression {
            get => _expression;
            set => _expression = value;
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