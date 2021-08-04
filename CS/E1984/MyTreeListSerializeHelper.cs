using DevExpress.Utils.Serializing;
using DevExpress.XtraTreeList;
using System.IO;

namespace E1984 {
    public static class MyTreeListSerializeHelper
    {
        public static string DefaultFileName = "test.xml";
        public static TreeList SelectedTreeList;

        public static void SaveTreeList()
        {
            SaveTreeList(SelectedTreeList, DefaultFileName);
        }

        public static void RestoreTreeList()
        {
            RestoreTreeList(SelectedTreeList, DefaultFileName);
        }



        static void SaveTreeList(TreeList treeList, string fileName)
        {
            treeList.SaveLayoutToXml(fileName);
            SaveConditions(treeList, "Conditions" + fileName);
        }

        private static void SaveConditions(TreeList treeList, string fileName)
        {
            XmlXtraSerializer serializer = new XmlXtraSerializer();
            using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                try
                {
                    TreeListFormatConditions collection = new TreeListFormatConditions(treeList.FormatConditions);
                    serializer.SerializeObject(collection, stream, "FormatConditions");
                }
                finally { stream.Close(); }
            }
        }

        static void RestoreTreeList(TreeList treeList, string fileName)
        {
            treeList.RestoreLayoutFromXml(fileName);
            RestoreConditions(treeList, "Conditions" + fileName);
        }


        private static void RestoreConditions(TreeList treeList, string fileName)
        {
            if (!File.Exists(fileName)) return;
            XmlXtraSerializer serializer = new XmlXtraSerializer();
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                try
                {
                    TreeListFormatConditions collection = new TreeListFormatConditions();
                    serializer.DeserializeObject(collection, stream, "FormatConditions");
                    collection.Conditions.CopyToStyleFormats(treeList.FormatConditions);
                    treeList.Refresh();
                }
                finally { stream.Close(); }
            }
        }
    }
}
