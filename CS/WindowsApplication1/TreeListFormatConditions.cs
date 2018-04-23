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
        public SerializableFormatCollection Conditions
        {
            get { return _conditions; }
        }

        private object XtraCreateConditionsItem(XtraItemEventArgs e)
        {
            return Conditions.Add();
        }
    }
}
