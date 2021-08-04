using DevExpress.Utils.Serializing;
using DevExpress.XtraTreeList.StyleFormatConditions;

namespace E1984 {
    public class TreeListFormatConditions
    {

        private SerializableFormatCollection _conditions;

        public TreeListFormatConditions()
        {
            _conditions = new SerializableFormatCollection();
        }

        public TreeListFormatConditions(StyleFormatConditionCollection styles)
        {
            _conditions = new SerializableFormatCollection(styles);
        }

        [XtraSerializableProperty(XtraSerializationVisibility.Collection, true, false, true, 0, XtraSerializationFlags.None)]
        public SerializableFormatCollection Conditions => _conditions;

        private object XtraCreateConditionsItem(XtraItemEventArgs e)
        {
            return Conditions.Add();
        }
    }
}
