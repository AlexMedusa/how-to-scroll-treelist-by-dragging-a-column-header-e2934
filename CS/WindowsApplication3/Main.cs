using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }

        TreeListScrollHelper helper;
        private void Form1_Load(object sender, EventArgs e) {
            InitData();
            treeList.ExpandAll();

            helper = new TreeListScrollHelper(treeList, 1000);
            helper.EnableScrollingOnColumnDragging();
        }

        private void InitData()
        {
            object[] values = new object[] { "Text", "Text", "Text", "Text", "Text", "Text", "Text", 
                "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text", "Text" };
             TreeListNode parentNode = treeList.AppendNode(values, null);
            for (int i = 2; i < 15; i++)
                parentNode = treeList.AppendNode(values, parentNode);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            helper.DisableScrollingOnColumnDragging();
        }
    }
}
