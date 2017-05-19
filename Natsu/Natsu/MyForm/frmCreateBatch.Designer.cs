﻿namespace Natsu.MyForm
{
    partial class frmCreateBatch
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
            this.txt_DateCreate = new DevExpress.XtraEditors.TextEdit();
            this.lb_SoLuongHinh = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.btn_CreateBatch = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BrowserImage = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ImagePath = new DevExpress.XtraEditors.TextEdit();
            this.txt_UserCreate = new DevExpress.XtraEditors.TextEdit();
            this.txt_Location = new DevExpress.XtraEditors.TextEdit();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_BatchName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ImagePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DateCreate
            // 
            this.txt_DateCreate.Location = new System.Drawing.Point(137, 185);
            this.txt_DateCreate.Name = "txt_DateCreate";
            this.txt_DateCreate.Properties.ReadOnly = true;
            this.txt_DateCreate.Size = new System.Drawing.Size(174, 20);
            this.txt_DateCreate.TabIndex = 41;
            // 
            // lb_SoLuongHinh
            // 
            this.lb_SoLuongHinh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lb_SoLuongHinh.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_SoLuongHinh.Appearance.Options.UseFont = true;
            this.lb_SoLuongHinh.Appearance.Options.UseForeColor = true;
            this.lb_SoLuongHinh.Location = new System.Drawing.Point(137, 256);
            this.lb_SoLuongHinh.Name = "lb_SoLuongHinh";
            this.lb_SoLuongHinh.Size = new System.Drawing.Size(0, 19);
            this.lb_SoLuongHinh.TabIndex = 45;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 363);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Size = new System.Drawing.Size(632, 40);
            this.progressBarControl1.TabIndex = 44;
            // 
            // btn_CreateBatch
            // 
            this.btn_CreateBatch.Location = new System.Drawing.Point(221, 291);
            this.btn_CreateBatch.Name = "btn_CreateBatch";
            this.btn_CreateBatch.Size = new System.Drawing.Size(164, 44);
            this.btn_CreateBatch.TabIndex = 43;
            this.btn_CreateBatch.Text = "Tạo Batch";
            this.btn_CreateBatch.Click += new System.EventHandler(this.btn_CreateBatch_Click);
            // 
            // btn_BrowserImage
            // 
            this.btn_BrowserImage.Location = new System.Drawing.Point(499, 228);
            this.btn_BrowserImage.Name = "btn_BrowserImage";
            this.btn_BrowserImage.Size = new System.Drawing.Size(85, 23);
            this.btn_BrowserImage.TabIndex = 42;
            this.btn_BrowserImage.Text = "Chọn Image...";
            this.btn_BrowserImage.Click += new System.EventHandler(this.btn_BrowserImage_Click);
            // 
            // txt_ImagePath
            // 
            this.txt_ImagePath.Location = new System.Drawing.Point(137, 230);
            this.txt_ImagePath.Name = "txt_ImagePath";
            this.txt_ImagePath.Properties.ReadOnly = true;
            this.txt_ImagePath.Size = new System.Drawing.Size(356, 20);
            this.txt_ImagePath.TabIndex = 39;
            // 
            // txt_UserCreate
            // 
            this.txt_UserCreate.Location = new System.Drawing.Point(137, 141);
            this.txt_UserCreate.Name = "txt_UserCreate";
            this.txt_UserCreate.Properties.ReadOnly = true;
            this.txt_UserCreate.Size = new System.Drawing.Size(174, 20);
            this.txt_UserCreate.TabIndex = 38;
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(137, 98);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(356, 20);
            this.txt_Location.TabIndex = 40;
            // 
            // txt_BatchName
            // 
            this.txt_BatchName.Location = new System.Drawing.Point(137, 56);
            this.txt_BatchName.Name = "txt_BatchName";
            this.txt_BatchName.Size = new System.Drawing.Size(356, 20);
            this.txt_BatchName.TabIndex = 37;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(30, 233);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 13);
            this.labelControl7.TabIndex = 34;
            this.labelControl7.Text = "Đường dẫn Image:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 188);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 13);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Ngày tạo Batch:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 144);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "User tạo Batch:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Đường dẫn:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Tên Batch:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(221, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(182, 27);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "TẠO BATCH MỚI";
            // 
            // frmCreateBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.txt_DateCreate);
            this.Controls.Add(this.lb_SoLuongHinh);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btn_CreateBatch);
            this.Controls.Add(this.btn_BrowserImage);
            this.Controls.Add(this.txt_ImagePath);
            this.Controls.Add(this.txt_UserCreate);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.txt_BatchName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCreateBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateBatch";
            this.Load += new System.EventHandler(this.frmCreateBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ImagePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BatchName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_DateCreate;
        private DevExpress.XtraEditors.LabelControl lb_SoLuongHinh;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton btn_CreateBatch;
        private DevExpress.XtraEditors.SimpleButton btn_BrowserImage;
        private DevExpress.XtraEditors.TextEdit txt_ImagePath;
        private DevExpress.XtraEditors.TextEdit txt_UserCreate;
        private DevExpress.XtraEditors.TextEdit txt_Location;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.TextEdit txt_BatchName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}