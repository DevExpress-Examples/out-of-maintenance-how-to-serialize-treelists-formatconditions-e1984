using System;
using System.Data;
using System.Windows.Forms;

namespace E1984 {
    public partial class Form1 : Form
    {
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("ParentID", typeof(int));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { string.Format("Name{0}", i), i + 1, 3 - i, DateTime.Now.AddDays(i), i % 3 });
            return tbl;
        }
   

        public Form1()
        {
            InitializeComponent();
            treeList1.DataSource = CreateTable(30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save");
            treeList1.SaveLayoutToXml(MyTreeListSerializeHelper.DefaultFileName);
            MessageBox.Show("Clear");
            treeList1.FormatRules.Clear();
            MessageBox.Show("Restore");
            treeList1.RestoreLayoutFromXml(MyTreeListSerializeHelper.DefaultFileName);
        }  
    }

}