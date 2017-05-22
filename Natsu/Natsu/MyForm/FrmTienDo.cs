using System;
using System.Linq;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Natsu.MyClass;

namespace Natsu.MyForm
{
    public partial class FrmTienDo : XtraForm
    {
        public FrmTienDo()
        {
            InitializeComponent();
        }

        private void frm_TienDo_Load(object sender, EventArgs e)
        {
            btn_ChiTiet.Visible = false;
            var fBatchName = (from w in Global.Db.tbl_Batches orderby w.IDBatch select new { w.fBatchName }).ToList();
            cbb_Batch.Properties.DataSource = fBatchName;
            cbb_Batch.Properties.DisplayMember = "fBatchName";
            cbb_Batch.Properties.ValueMember = "fBatchName";
            cbb_Batch.Text = Global.StrBatch;
            if (cbb_Batch.Text == @"No batch")
            {
                btn_ChiTiet.Visible = false;
            }
            else
            {
                btn_ChiTiet.Visible = true;
            }
        }
        private void ThongKe()
        {
            try
            {
                chartControl1.DataSource = null;
                chartControl1.Series.Clear();
                chartControl1.DataSource = Global.Db.ThongKeTienDo(cbb_Batch.Text);
                Series series1 = new Series("Series1", ViewType.Pie);
                series1.ArgumentScaleType = ScaleType.Qualitative;
                series1.ArgumentDataMember = "name";
                series1.ValueScaleType = ScaleType.Numerical;
                series1.ValueDataMembers.AddRange( "soluong" );
                chartControl1.Series.Add(series1);
                ((PiePointOptions)series1.Label.PointOptions).PointView = PointView.ArgumentAndValues;
                chartControl1.PaletteName = "Palette 1";
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void cbb_Batch_EditValueChanged(object sender, EventArgs e)
        {
            ThongKe();
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietTienDo frm = new FrmChiTietTienDo {lb_fBatchName = {Text = cbb_Batch.Text}};
            frm.ShowDialog();
        }
    }
}