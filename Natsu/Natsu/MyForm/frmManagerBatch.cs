using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Natsu.MyClass;

namespace Natsu.MyForm
{
    public partial class frmManagerBatch : DevExpress.XtraEditors.XtraForm
    {
        public frmManagerBatch()
        {
            InitializeComponent();
        }

        private void frmManagerBatch_Load(object sender, EventArgs e)
        {
            RefreshBatch();
        }

        private void btn_TaoBatch_Click(object sender, EventArgs e)
        {
            new frmCreateBatch().ShowDialog();
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
            if (MessageBox.Show("Bạn chắc chắn muốn xóa batch: " + fbatchname + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Global.Db.XoaBatch(fbatchname);
                    Directory.Delete(temp, true);
                    MessageBox.Show("Đã xóa batch thành công!");

                }
                catch (Exception)
                {

                    MessageBox.Show("Xóa batch bị lỗi!");

                }

            }
            RefreshBatch();
        }
    }
}