namespace Natsu.MyForm
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar_System = new DevExpress.XtraBars.BarSubItem();
            this.btn_Logout = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.bar_Manager = new DevExpress.XtraBars.BarSubItem();
            this.btn_Batch = new DevExpress.XtraBars.BarButtonItem();
            this.btn_User = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Check = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Progress = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Productivity = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ZoomImage = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lb_SoHinhLamDuoc = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoHinhConLai = new DevExpress.XtraEditors.LabelControl();
            this.lb_4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongSoHinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_3 = new DevExpress.XtraEditors.LabelControl();
            this.lb_UserName = new DevExpress.XtraEditors.LabelControl();
            this.lb_IdImage = new DevExpress.XtraEditors.LabelControl();
            this.lb_6 = new DevExpress.XtraEditors.LabelControl();
            this.lb_fBatchName = new DevExpress.XtraEditors.LabelControl();
            this.lb_5 = new DevExpress.XtraEditors.LabelControl();
            this.lb_2 = new DevExpress.XtraEditors.LabelControl();
            this.lb_1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ucNatsu1 = new Natsu.MyUserControl.UcNatsu();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Pause = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Submit_Logout = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Start_Submit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.ucPictureBox1 = new Natsu.MyUserControl.UcPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bar_System,
            this.btn_Logout,
            this.btn_Exit,
            this.bar_Manager,
            this.btn_Batch,
            this.btn_User,
            this.btn_Check,
            this.btn_Progress,
            this.btn_Productivity,
            this.btn_ExportExcel,
            this.btn_ZoomImage});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_System),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_Manager),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ZoomImage)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar_System
            // 
            this.bar_System.Caption = "System";
            this.bar_System.Id = 0;
            this.bar_System.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Logout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Exit)});
            this.bar_System.Name = "bar_System";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Caption = "&Logout";
            this.btn_Logout.Id = 1;
            this.btn_Logout.Name = "btn_Logout";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Caption = "&Exit";
            this.btn_Exit.Id = 2;
            this.btn_Exit.Name = "btn_Exit";
            // 
            // bar_Manager
            // 
            this.bar_Manager.Caption = "Manager";
            this.bar_Manager.Id = 3;
            this.bar_Manager.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Batch),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_User),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Check),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Progress),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Productivity),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ExportExcel)});
            this.bar_Manager.Name = "bar_Manager";
            // 
            // btn_Batch
            // 
            this.btn_Batch.Caption = "Manager &Batch";
            this.btn_Batch.Id = 4;
            this.btn_Batch.Name = "btn_Batch";
            // 
            // btn_User
            // 
            this.btn_User.Caption = "Manager &User";
            this.btn_User.Id = 5;
            this.btn_User.Name = "btn_User";
            // 
            // btn_Check
            // 
            this.btn_Check.Caption = "&Check";
            this.btn_Check.Id = 6;
            this.btn_Check.Name = "btn_Check";
            // 
            // btn_Progress
            // 
            this.btn_Progress.Caption = "&Progress";
            this.btn_Progress.Id = 7;
            this.btn_Progress.Name = "btn_Progress";
            // 
            // btn_Productivity
            // 
            this.btn_Productivity.Caption = "Pro&ductivity";
            this.btn_Productivity.Id = 8;
            this.btn_Productivity.Name = "btn_Productivity";
            // 
            // btn_ExportExcel
            // 
            this.btn_ExportExcel.Caption = "&Export Excel";
            this.btn_ExportExcel.Id = 9;
            this.btn_ExportExcel.Name = "btn_ExportExcel";
            // 
            // btn_ZoomImage
            // 
            this.btn_ZoomImage.Caption = "Zoom Image";
            this.btn_ZoomImage.Id = 10;
            this.btn_ZoomImage.Name = "btn_ZoomImage";
            this.btn_ZoomImage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ZoomImage_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1264, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 646);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1264, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 626);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1264, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 626);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lb_SoHinhLamDuoc);
            this.panelControl1.Controls.Add(this.lb_SoHinhConLai);
            this.panelControl1.Controls.Add(this.lb_4);
            this.panelControl1.Controls.Add(this.lb_TongSoHinh);
            this.panelControl1.Controls.Add(this.lb_3);
            this.panelControl1.Controls.Add(this.lb_UserName);
            this.panelControl1.Controls.Add(this.lb_IdImage);
            this.panelControl1.Controls.Add(this.lb_6);
            this.panelControl1.Controls.Add(this.lb_fBatchName);
            this.panelControl1.Controls.Add(this.lb_5);
            this.panelControl1.Controls.Add(this.lb_2);
            this.panelControl1.Controls.Add(this.lb_1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1264, 25);
            this.panelControl1.TabIndex = 7;
            // 
            // lb_SoHinhLamDuoc
            // 
            this.lb_SoHinhLamDuoc.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_SoHinhLamDuoc.Appearance.Options.UseForeColor = true;
            this.lb_SoHinhLamDuoc.Location = new System.Drawing.Point(525, 6);
            this.lb_SoHinhLamDuoc.Name = "lb_SoHinhLamDuoc";
            this.lb_SoHinhLamDuoc.Size = new System.Drawing.Size(6, 13);
            this.lb_SoHinhLamDuoc.TabIndex = 1;
            this.lb_SoHinhLamDuoc.Text = "0";
            // 
            // lb_SoHinhConLai
            // 
            this.lb_SoHinhConLai.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lb_SoHinhConLai.Appearance.Options.UseForeColor = true;
            this.lb_SoHinhConLai.Location = new System.Drawing.Point(417, 6);
            this.lb_SoHinhConLai.Name = "lb_SoHinhConLai";
            this.lb_SoHinhConLai.Size = new System.Drawing.Size(6, 13);
            this.lb_SoHinhConLai.TabIndex = 2;
            this.lb_SoHinhConLai.Text = "0";
            // 
            // lb_4
            // 
            this.lb_4.Location = new System.Drawing.Point(456, 6);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(67, 13);
            this.lb_4.TabIndex = 3;
            this.lb_4.Text = "Images Done:";
            // 
            // lb_TongSoHinh
            // 
            this.lb_TongSoHinh.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lb_TongSoHinh.Appearance.Options.UseForeColor = true;
            this.lb_TongSoHinh.Location = new System.Drawing.Point(266, 6);
            this.lb_TongSoHinh.Name = "lb_TongSoHinh";
            this.lb_TongSoHinh.Size = new System.Drawing.Size(6, 13);
            this.lb_TongSoHinh.TabIndex = 4;
            this.lb_TongSoHinh.Text = "0";
            // 
            // lb_3
            // 
            this.lb_3.Location = new System.Drawing.Point(305, 6);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(109, 13);
            this.lb_3.TabIndex = 5;
            this.lb_3.Text = "The remaining Images:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_UserName.Location = new System.Drawing.Point(915, 6);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(49, 13);
            this.lb_UserName.TabIndex = 6;
            this.lb_UserName.Text = "UserName";
            // 
            // lb_IdImage
            // 
            this.lb_IdImage.Location = new System.Drawing.Point(630, 6);
            this.lb_IdImage.Name = "lb_IdImage";
            this.lb_IdImage.Size = new System.Drawing.Size(6, 13);
            this.lb_IdImage.TabIndex = 7;
            this.lb_IdImage.Text = "0";
            // 
            // lb_6
            // 
            this.lb_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_6.Location = new System.Drawing.Point(856, 6);
            this.lb_6.Name = "lb_6";
            this.lb_6.Size = new System.Drawing.Size(53, 13);
            this.lb_6.TabIndex = 8;
            this.lb_6.Text = "UserName:";
            // 
            // lb_fBatchName
            // 
            this.lb_fBatchName.Location = new System.Drawing.Point(47, 6);
            this.lb_fBatchName.Name = "lb_fBatchName";
            this.lb_fBatchName.Size = new System.Drawing.Size(27, 13);
            this.lb_fBatchName.TabIndex = 9;
            this.lb_fBatchName.Text = "Batch";
            // 
            // lb_5
            // 
            this.lb_5.Location = new System.Drawing.Point(580, 6);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(44, 13);
            this.lb_5.TabIndex = 10;
            this.lb_5.Text = "IdImage:";
            // 
            // lb_2
            // 
            this.lb_2.Location = new System.Drawing.Point(199, 6);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(66, 13);
            this.lb_2.TabIndex = 11;
            this.lb_2.Text = "Total Images:";
            // 
            // lb_1
            // 
            this.lb_1.Location = new System.Drawing.Point(10, 6);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(31, 13);
            this.lb_1.TabIndex = 12;
            this.lb_1.Text = "Batch:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.ucNatsu1);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(736, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(528, 601);
            this.panelControl2.TabIndex = 8;
            // 
            // ucNatsu1
            // 
            this.ucNatsu1.AutoScroll = true;
            this.ucNatsu1.AutoSize = true;
            this.ucNatsu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNatsu1.Location = new System.Drawing.Point(2, 2);
            this.ucNatsu1.Name = "ucNatsu1";
            this.ucNatsu1.Size = new System.Drawing.Size(524, 567);
            this.ucNatsu1.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btn_Pause);
            this.panelControl4.Controls.Add(this.btn_Submit_Logout);
            this.panelControl4.Controls.Add(this.btn_Start_Submit);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(2, 569);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(524, 30);
            this.panelControl4.TabIndex = 0;
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(312, 5);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(95, 23);
            this.btn_Pause.TabIndex = 7;
            this.btn_Pause.Text = "Pause (ESC)";
            // 
            // btn_Submit_Logout
            // 
            this.btn_Submit_Logout.Location = new System.Drawing.Point(216, 6);
            this.btn_Submit_Logout.Name = "btn_Submit_Logout";
            this.btn_Submit_Logout.Size = new System.Drawing.Size(90, 21);
            this.btn_Submit_Logout.TabIndex = 6;
            this.btn_Submit_Logout.Text = "Submit + Logout";
            // 
            // btn_Start_Submit
            // 
            this.btn_Start_Submit.Location = new System.Drawing.Point(120, 6);
            this.btn_Start_Submit.Name = "btn_Start_Submit";
            this.btn_Start_Submit.Size = new System.Drawing.Size(90, 21);
            this.btn_Start_Submit.TabIndex = 5;
            this.btn_Start_Submit.Text = "Start";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.ucPictureBox1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 45);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(736, 601);
            this.panelControl3.TabIndex = 9;
            // 
            // ucPictureBox1
            // 
            this.ucPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPictureBox1.Location = new System.Drawing.Point(2, 2);
            this.ucPictureBox1.Name = "ucPictureBox1";
            this.ucPictureBox1.Size = new System.Drawing.Size(732, 597);
            this.ucPictureBox1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 646);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmMain";
            this.Text = "Natsu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem bar_System;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_Logout;
        private DevExpress.XtraBars.BarButtonItem btn_Exit;
        private DevExpress.XtraBars.BarSubItem bar_Manager;
        private DevExpress.XtraBars.BarButtonItem btn_Batch;
        private DevExpress.XtraBars.BarButtonItem btn_User;
        private DevExpress.XtraBars.BarButtonItem btn_Check;
        private DevExpress.XtraBars.BarButtonItem btn_Progress;
        private DevExpress.XtraBars.BarButtonItem btn_Productivity;
        private DevExpress.XtraBars.BarButtonItem btn_ExportExcel;
        private DevExpress.XtraBars.BarButtonItem btn_ZoomImage;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private MyUserControl.UcPictureBox ucPictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lb_SoHinhLamDuoc;
        private DevExpress.XtraEditors.LabelControl lb_SoHinhConLai;
        private DevExpress.XtraEditors.LabelControl lb_4;
        private DevExpress.XtraEditors.LabelControl lb_TongSoHinh;
        private DevExpress.XtraEditors.LabelControl lb_3;
        private DevExpress.XtraEditors.LabelControl lb_UserName;
        private DevExpress.XtraEditors.LabelControl lb_IdImage;
        private DevExpress.XtraEditors.LabelControl lb_6;
        private DevExpress.XtraEditors.LabelControl lb_fBatchName;
        private DevExpress.XtraEditors.LabelControl lb_5;
        private DevExpress.XtraEditors.LabelControl lb_2;
        private DevExpress.XtraEditors.LabelControl lb_1;
        private DevExpress.XtraEditors.SimpleButton btn_Pause;
        private DevExpress.XtraEditors.SimpleButton btn_Submit_Logout;
        private DevExpress.XtraEditors.SimpleButton btn_Start_Submit;
        private MyUserControl.UcNatsu ucNatsu1;
    }
}

