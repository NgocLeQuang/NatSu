using Natsu.MyClass;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Natsu.MyForm
{
    public partial class FrmManagerBatch : DevExpress.XtraEditors.XtraForm
    {
        public FrmManagerBatch()
        {
            InitializeComponent();
        }

        private void frmManagerBatch_Load(object sender, EventArgs e)
        {
            RefreshBatch();
        }

        private void btn_TaoBatch_Click(object sender, EventArgs e)
        {
            new FrmCreateBatch().ShowDialog();
            RefreshBatch();
        }

        private void RefreshBatch()
        {
            var temp = from var in Global.Db.tbl_Batches orderby var.fdatecreated select var;
            gridControl1.DataSource = temp;
        }

        private void repositoryItemButtonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fbatchname = gridView1.GetFocusedRowCellValue("fBatchName").ToString();
            string temp = Global.StrPath + "\\" + fbatchname;
            if (MessageBox.Show(@"You definitely want to delete the batch: " + fbatchname + @"?", @"Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Global.Db.XoaBatch(fbatchname);
                    Directory.Delete(temp, true);
                    MessageBox.Show(@"Deleted batch successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Delete batch error!");
                }
            }
            RefreshBatch();
        }
    }
}