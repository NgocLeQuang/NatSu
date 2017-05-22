using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Natsu.MyClass;
using Natsu.Properties;

namespace Natsu.MyForm
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void SetValue()
        {
            if (Global.StrRole == "DESO")
            {
                lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();
            }
        }

        public string GetImage()
        {
            if (Global.StrRole == "DESO")
            {
                string temp = (from w in Global.Db.tbl_MissImage_DESOs where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0 select w.IdImage).FirstOrDefault();
                if (string.IsNullOrEmpty(temp))
                {
                    try
                    {
                        var getFilename =
                            (from w in Global.Db.LayHinhMoi_DeSo(Global.StrBatch, Global.StrUsername)
                             select w.Column1).FirstOrDefault();
                        if (string.IsNullOrEmpty(getFilename))
                        {
                            return "NULL";
                        }
                        lb_IdImage.Text = getFilename;
                        UcPictureBox1.imageBox1.Image = null;
                        if (UcPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename,
                            Settings.Default.ZoomImage) == "Error")
                        {
                            UcPictureBox1.imageBox1.Image = Resources.svn_deleted;
                            return "Error";

                        }
                        UcNatsu1.ucNatsuItem1.textEdit1.Focus();
                    }
                    catch (Exception)
                    {
                        return "NULL";
                    }
                }
                else
                {
                    lb_IdImage.Text = temp;
                    UcPictureBox1.imageBox1.Image = null;
                    if (UcPictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp,
                        Settings.Default.ZoomImage) == "Error")
                    {
                        UcPictureBox1.imageBox1.Image = Resources.svn_deleted;
                        return "Error";
                    }
                    UcNatsu1.ucNatsuItem1.textEdit1.Focus();
                }
            }
            return "OK";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lb_IdImage.Text = "";
                lb_fBatchName.Text = Global.StrBatch;
                lb_UserName.Text = Global.StrUsername;
                lb_TongSoHinh.Text = (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();
                
                bar_Manager.Enabled = false;
                if (Global.StrRole == "DESO")
                {
                    
                }
                else
                {
                    btn_Start_Submit.Enabled = false;
                    btn_Submit_Logout.Enabled = false;
                    bar_Manager.Enabled = true;
                }
                SetValue();
            }
            catch (Exception i)
            {
                MessageBox.Show(@"Error Load Main: " + i.Message);
            }
        }

        private void btn_ZoomImage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new FrmChangeZoom().ShowDialog();
        }

        private void btn_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
            Global.DbBpo.UpdateTimeLogout(Global.StrToken);
            Global.DbBpo.ResetToken(Global.StrUsername, Global.StrIdProject, Global.StrToken);
            Settings.Default.Save();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            new FrmFreeTime().ShowDialog();
            Global.DbBpo.UpdateTimeFree(Global.StrToken, Global.FreeTime);
        }

        private void btn_Start_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Global.DbBpo.UpdateTimeLastRequest(Global.StrToken);
                //Kiểm tra token
                var token = (from w in Global.DbBpo.tbl_TokenLogins where w.UserName == Global.StrUsername && w.IDProject == Global.StrIdProject select w.Token).FirstOrDefault();

                if (token != Global.StrToken)
                {
                    MessageBox.Show("User đã đăng nhập ở PC khác, bạn vui lòng đăng nhập lại!");
                    DialogResult = DialogResult.Yes;
                }
                if (btn_Start_Submit.Text == @"Start")
                {
                    if (string.IsNullOrEmpty(Global.StrBatch))
                    {
                        MessageBox.Show("Vui lòng đăng nhập lại và chọn Batch!");
                        return;
                    }

                    string temp = GetImage();
                    if (temp == "NULL")
                    {
                        var listResult = Global.Db.GetBatNotFinishDeSo(Global.StrUsername).ToList();
                        if (listResult.Count > 0)
                        {
                            if (MessageBox.Show("Batch tiếp theo là: " + listResult[0].fbatchname +
                                    "\nBạn có muốn tiếp tục làm không?", "Thông báo!", MessageBoxButtons.YesNo) ==
                                DialogResult.Yes)
                            {
                                Global.StrBatch = listResult[0].fbatchname;
                                lb_fBatchName.Text = Global.StrBatch;
                                lb_IdImage.Text = "";
                                lb_TongSoHinh.Text =
                                (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                                lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                                lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();
                                
                                SetValue();
                                btn_Start_Submit.Text = @"Start";
                                btn_Start_Submit_Click(null, null);
                            }
                            else
                            {
                                btn_Logout_ItemClick(null, null);
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Out of Image!");
                            btn_Logout_ItemClick(null, null);
                        }
                    }
                    else if (temp == "Error")
                    {
                        MessageBox.Show("Không thể load hình!");
                        btn_Logout_ItemClick(null, null);
                    }
                    UcNatsu1.ResetData();
                    
                    btn_Start_Submit.Text = @"Submit";
                    btn_Submit_Logout.Visible = true;
                }
                else
                {
                    if (Global.StrRole == "DESO")
                    {
                        if (UcNatsu1.IsEmpty())
                        {
                            if (
                                MessageBox.Show(
                                    "Bạn đang để trống nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>",
                                    "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                                return;
                        }
                        UcNatsu1.SaveData(lb_IdImage.Text);
                        UcNatsu1.ResetData();
                        //    uc_ASAHI1.ResetData();//}
                        string temp = GetImage();
                        if (temp == "NULL")
                        {
                            //Global.KeyEven = false;
                            var listResult = Global.Db.GetBatNotFinishDeSo(Global.StrUsername).ToList();
                            if (listResult.Count > 0)
                            {
                                if (MessageBox.Show(
                                        "Batch tiếp theo là: " + listResult[0].fbatchname +
                                        "\nBạn có muốn tiếp tục làm không?", "Thông báo!", MessageBoxButtons.YesNo) ==
                                    DialogResult.Yes)
                                {
                                    Global.StrBatch = listResult[0].fbatchname;
                                    lb_fBatchName.Text = Global.StrBatch;
                                    lb_IdImage.Text = "";
                                    lb_TongSoHinh.Text =
                                    (from w in Global.Db.tbl_Images where w.fbatchname == Global.StrBatch select w.idimage).Count().ToString();
                                    lb_SoHinhConLai.Text = (from w in Global.Db.tbl_Images where w.ReadImageDESo < 2 && w.fbatchname == Global.StrBatch && (w.UserNameDESo != Global.StrUsername || w.UserNameDESo == null || w.UserNameDESo == "") select w.idimage).Count().ToString();
                                    lb_SoHinhLamDuoc.Text = (from w in Global.Db.tbl_MissImage_DESOs where w.UserName == Global.StrUsername && w.fBatchName == Global.StrBatch select w.IdImage).Count().ToString();
                                    
                                    SetValue();
                                    btn_Start_Submit.Text = "Start";
                                    btn_Start_Submit_Click(null, null);
                                }
                                else
                                {
                                    btn_Logout_ItemClick(null, null);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hết Hình!");
                                btn_Logout_ItemClick(null, null);
                            }
                        }
                        else if (temp == "Error")
                        {
                            MessageBox.Show("Không thể load hình!");
                            btn_Logout_ItemClick(null, null);
                        }
                    }
                    SetValue();
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Lỗi khi Submit" + i.Message);
            }
        }
    }
}
