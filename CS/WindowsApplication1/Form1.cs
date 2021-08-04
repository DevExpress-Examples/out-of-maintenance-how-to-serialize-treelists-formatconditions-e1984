using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Serializing;

namespace WindowsApplication1
{
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
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i + 1, 3 - i, DateTime.Now.AddDays(i), i % 3 });
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
            MyTreeListSerializeHelper.SelectedTreeList = treeList1;
            MyTreeListSerializeHelper.SaveTreeList();
            MessageBox.Show("Clear");
            treeList1.FormatConditions.Clear();
            MessageBox.Show("Restore");
            MyTreeListSerializeHelper.RestoreTreeList();
        }  
    }

}