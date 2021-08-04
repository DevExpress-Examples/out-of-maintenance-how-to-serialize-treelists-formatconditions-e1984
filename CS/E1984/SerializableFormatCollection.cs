using DevExpress.XtraTreeList.StyleFormatConditions;
using System.Collections;

namespace E1984 {
    public class SerializableFormatCollection : CollectionBase
    {
        public SerializableFormatCollection(StyleFormatConditionCollection collection)
        {
            CopyFromStyleFormats(collection);
        }

        public SerializableFormatCollection()
        {
        }


        public SerializableFormatCondition Add()
        {
            SerializableFormatCondition serializableFormat = new SerializableFormatCondition();
            InnerList.Add(serializableFormat);
            return serializableFormat;
        }

        public void CopyFromStyleFormats(StyleFormatConditionCollection styles)
        {
            Clear();
            foreach (StyleFormatCondition style in styles)
            {
                SerializableFormatCondition serializableFormat = new SerializableFormatCondition();
                serializableFormat.CopyFromStyleFormat(style);
                InnerList.Add(serializableFormat);
            }
        }

        public void CopyToStyleFormats(StyleFormatConditionCollection styles)
        {
            styles.Clear();
            foreach (SerializableFormatCondition serializableFormat in this)
            {
                StyleFormatCondition style = new StyleFormatCondition();
                styles.Add(style);
                serializableFormat.CopyToStyleFormat(style);
            }
        }
    }
}
