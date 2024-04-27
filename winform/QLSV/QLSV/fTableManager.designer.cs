
using System.Windows.Forms;

namespace QLSV
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccountInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtNốiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsvAttendancing = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRfidId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbNow = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.tsmAccountInfor,
            this.kếtNốiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1117, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // tsmAccountInfor
            // 
            this.tsmAccountInfor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tsmAccountInfor.Name = "tsmAccountInfor";
            this.tsmAccountInfor.Size = new System.Drawing.Size(151, 24);
            this.tsmAccountInfor.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // kếtNốiToolStripMenuItem
            // 
            this.kếtNốiToolStripMenuItem.Name = "kếtNốiToolStripMenuItem";
            this.kếtNốiToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.kếtNốiToolStripMenuItem.Text = "Kết nối";
            this.kếtNốiToolStripMenuItem.Click += new System.EventHandler(this.kếtNốiToolStripMenuItem_Click);
            // 
            // lsvAttendancing
            // 
            this.lsvAttendancing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvAttendancing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colRfidId,
            this.colName,
            this.colStatus,
            this.colCheckIn,
            this.colCheckOut});
            this.lsvAttendancing.GridLines = true;
            this.lsvAttendancing.HideSelection = false;
            this.lsvAttendancing.Location = new System.Drawing.Point(4, 63);
            this.lsvAttendancing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvAttendancing.Name = "lsvAttendancing";
            this.lsvAttendancing.Size = new System.Drawing.Size(1117, 515);
            this.lsvAttendancing.TabIndex = 6;
            this.lsvAttendancing.UseCompatibleStateImageBehavior = false;
            this.lsvAttendancing.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "Mã sinh viên";
            this.colID.Width = 115;
            // 
            // colRfidId
            // 
            this.colRfidId.Text = "ID RFID";
            this.colRfidId.Width = 72;
            // 
            // colName
            // 
            this.colName.Text = "Tên";
            this.colName.Width = 160;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Trạng thái";
            this.colStatus.Width = 120;
            // 
            // colCheckIn
            // 
            this.colCheckIn.Text = "Giờ vào";
            this.colCheckIn.Width = 130;
            // 
            // colCheckOut
            // 
            this.colCheckOut.Text = "Giờ ra";
            this.colCheckOut.Width = 130;
            // 
            // lbNow
            // 
            this.lbNow.AutoSize = true;
            this.lbNow.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNow.ForeColor = System.Drawing.Color.Blue;
            this.lbNow.Location = new System.Drawing.Point(0, 26);
            this.lbNow.Name = "lbNow";
            this.lbNow.Size = new System.Drawing.Size(66, 25);
            this.lbNow.TabIndex = 7;
            this.lbNow.Text = "lbNow";
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 607);
            this.Controls.Add(this.lbNow);
            this.Controls.Add(this.lsvAttendancing);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm danh sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAccountInfor;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ListView lsvAttendancing;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colRfidId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colCheckIn;
        private System.Windows.Forms.ColumnHeader colCheckOut;
        private System.IO.Ports.SerialPort serialPort1;
        private ToolStripMenuItem kếtNốiToolStripMenuItem;
        private Label lbNow;
    }
}