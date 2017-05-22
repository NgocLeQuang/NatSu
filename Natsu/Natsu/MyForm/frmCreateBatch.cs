using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Natsu.MyClass;

namespace Natsu.MyForm
{
    public partial class FrmCreateBatch : XtraForm
    {
        private string[] _lFileNames;
        private int _soluonghinh;
        public FrmCreateBatch()
        {
            InitializeComponent();
        }

        private void frmCreateBatch_Load(object sender, EventArgs e)
        {
            txt_UserCreate.Text = Global.StrUsername;
            txt_DateCreate.Text = DateTime.Now.ToShortDateString() + @"  -  " + DateTime.Now.ToShortTimeString();
        }

        private void btn_BrowserImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_BatchName.Text))
            {
                MessageBox.Show(@"Please enter a batch name", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = @"All Types Image|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _lFileNames = dlg.FileNames;
                txt_ImagePath.Text = Path.GetDirectoryName(dlg.FileName);
            }
            _soluonghinh = 0;
            _soluonghinh = dlg.FileNames.Length;
            lb_SoLuongHinh.Text = dlg.FileNames.Length + @" files ";
        }

        private void btn_CreateBatch_Click(object sender, EventArgs e)
        {
            UpLoadSingle();
        }
        private void UpLoadSingle()
        {
            progressBarControl1.EditValue = 0;
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.PercentView = true;
            progressBarControl1.Properties.Maximum = _lFileNames.Length;
            progressBarControl1.Properties.Minimum = 0;
            var batch = (from w in Global.Db.tbl_Batches.Where(w => w.fBatchName == txt_BatchName.Text) select w.fBatchName).FirstOrDefault();
            if (!string.IsNullOrEmpty(txt_ImagePath.Text))
            {
                if (string.IsNullOrEmpty(batch))
                {
                    var fBatch = new tbl_Batch
                    {
                        fBatchName = txt_BatchName.Text,
                        fusercreate = txt_UserCreate.Text,
                        fdatecreated = DateTime.Now,
                        fPathPicture = txt_ImagePath.Text,
                        fLocation = txt_Location.Text,
                        fSoLuongAnh = _soluonghinh.ToString(),
                        LoaiBatch = "Getsu"
                        //LoaiBatch = rg_LoaiBatch.Properties.Items[rg_LoaiBatch.SelectedIndex].Description

                    };
                    Global.Db.tbl_Batches.InsertOnSubmit(fBatch);
                    Global.Db.SubmitChanges();




                }
                else
                {
                    MessageBox.Show(@"Batch exists please enter another batch name!");
                    return;
                }
            }
            else
            {
                MessageBox.Show(@"You have not selected an image yet!");
                return;
            }
            string temp = Global.StrPath + "\\" + txt_BatchName.Text;
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }
            else
            {
                MessageBox.Show(@"Batch named batch!");
                return;
            }
            foreach (string i in _lFileNames)
            {
                FileInfo fi = new FileInfo(i);

                tbl_Image tempImage = new tbl_Image
                {
                    fbatchname = txt_BatchName.Text,
                    idimage = Path.GetFileName(fi.ToString()),
                    ReadImageDESo = 0,
                    CheckedDESo = 0,
                    TienDoDESO = "Hình chưa nhập",
                    ReadImageDESO_Good = 1,
                    ReadImageDESO_NotGood = 1
                };
                Global.Db.tbl_Images.InsertOnSubmit(tempImage);
                Global.Db.SubmitChanges();


                string des = temp + @"\" + Path.GetFileName(fi.ToString());
                fi.CopyTo(des);
                progressBarControl1.PerformStep();
                progressBarControl1.Update();
            }
            MessageBox.Show(@"Create a new batch successfully!");
            progressBarControl1.EditValue = 0;
            txt_BatchName.Text = "";
            txt_ImagePath.Text = "";
            lb_SoLuongHinh.Text = "";
        }
        public static string[] GetFilesFrom(string searchFolder, string[] filters, bool isRecursive)
        {
            List<string> filesFound = new List<string>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, $"*.{filter}", searchOption));
            }
            return filesFound.ToArray();
        }
    }
}