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
