using System.Windows.Forms;
namespace QLSV
{
    partial class fAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSV1DataSet = new QLSV.QLSV1DataSet();
            this.attendanceTableAdapter = new QLSV.QLSV1DataSetTableAdapters.AttendanceTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrOutMin = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.nmrOutHour = new System.Windows.Forms.NumericUpDown();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.nmrInMin = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nmrInHour = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbThu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.ThuTrongTuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianVaoHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianTanHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnViewSch = new System.Windows.Forms.Button();
            this.btnEditSche = new System.Windows.Forms.Button();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel25 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txbTypeAccount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel31 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccout = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbIdCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.student_id_inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_id_inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name_inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_phone_inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_email_inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txbNameSearch = new System.Windows.Forms.TextBox();
            this.btnSeachFood = new System.Windows.Forms.Button();
            this.btnImportStudent = new System.Windows.Forms.Button();
            this.btnExportStudent = new System.Windows.Forms.Button();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddStd = new System.Windows.Forms.Button();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendance_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV1DataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOutMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOutHour)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrInMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrInHour)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.panel16.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel31.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tc.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.qLSV1DataSet;
            this.attendanceBindingSource.CurrentChanged += new System.EventHandler(this.attendanceBindingSource_CurrentChanged);
            // 
            // qLSV1DataSet
            // 
            this.qLSV1DataSet.DataSetName = "QLSV1DataSet";
            this.qLSV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel11);
            this.tabPage2.Controls.Add(this.panel15);
            this.tabPage2.Controls.Add(this.panel16);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1313, 501);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Thời gian biểu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Location = new System.Drawing.Point(750, 75);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(350, 356);
            this.panel11.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label18);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.nmrOutMin);
            this.panel12.Controls.Add(this.label17);
            this.panel12.Controls.Add(this.nmrOutHour);
            this.panel12.Location = new System.Drawing.Point(4, 146);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(263, 84);
            this.panel12.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(185, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "phút";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thời gian tan học";
            // 
            // nmrOutMin
            // 
            this.nmrOutMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrOutMin.Location = new System.Drawing.Point(121, 40);
            this.nmrOutMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrOutMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmrOutMin.Name = "nmrOutMin";
            this.nmrOutMin.Size = new System.Drawing.Size(60, 34);
            this.nmrOutMin.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(92, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "giờ";
            // 
            // nmrOutHour
            // 
            this.nmrOutHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrOutHour.Location = new System.Drawing.Point(26, 40);
            this.nmrOutHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrOutHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmrOutHour.Name = "nmrOutHour";
            this.nmrOutHour.Size = new System.Drawing.Size(60, 34);
            this.nmrOutHour.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label16);
            this.panel13.Controls.Add(this.nmrInMin);
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.nmrInHour);
            this.panel13.Controls.Add(this.label8);
            this.panel13.Location = new System.Drawing.Point(4, 54);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(263, 79);
            this.panel13.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(185, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "phút";
            // 
            // nmrInMin
            // 
            this.nmrInMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrInMin.Location = new System.Drawing.Point(121, 30);
            this.nmrInMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrInMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmrInMin.Name = "nmrInMin";
            this.nmrInMin.Size = new System.Drawing.Size(60, 34);
            this.nmrInMin.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "giờ";
            // 
            // nmrInHour
            // 
            this.nmrInHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrInHour.Location = new System.Drawing.Point(26, 30);
            this.nmrInHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrInHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmrInHour.Name = "nmrInHour";
            this.nmrInHour.Size = new System.Drawing.Size(60, 34);
            this.nmrInHour.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thời gian vào học";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txbThu);
            this.panel14.Controls.Add(this.label9);
            this.panel14.Location = new System.Drawing.Point(4, 14);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(263, 36);
            this.panel14.TabIndex = 1;
            // 
            // txbThu
            // 
            this.txbThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txbThu.Location = new System.Drawing.Point(151, 7);
            this.txbThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbThu.Name = "txbThu";
            this.txbThu.ReadOnly = true;
            this.txbThu.Size = new System.Drawing.Size(110, 22);
            this.txbThu.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thứ trong tuần";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dgvSchedule);
            this.panel15.Location = new System.Drawing.Point(14, 75);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(731, 356);
            this.panel15.TabIndex = 5;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThuTrongTuan,
            this.ThoiGianVaoHoc,
            this.ThoiGianTanHoc});
            this.dgvSchedule.Location = new System.Drawing.Point(4, 4);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 62;
            this.dgvSchedule.RowTemplate.Height = 28;
            this.dgvSchedule.Size = new System.Drawing.Size(724, 338);
            this.dgvSchedule.TabIndex = 0;
            this.dgvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellClick);
            // 
            // ThuTrongTuan
            // 
            this.ThuTrongTuan.DataPropertyName = "ThuTrongTuan";
            this.ThuTrongTuan.HeaderText = "Thứ";
            this.ThuTrongTuan.MinimumWidth = 8;
            this.ThuTrongTuan.Name = "ThuTrongTuan";
            this.ThuTrongTuan.Width = 150;
            // 
            // ThoiGianVaoHoc
            // 
            this.ThoiGianVaoHoc.DataPropertyName = "ThoiGianVaoHoc";
            this.ThoiGianVaoHoc.HeaderText = "Thời Gian Vào Học";
            this.ThoiGianVaoHoc.MinimumWidth = 8;
            this.ThoiGianVaoHoc.Name = "ThoiGianVaoHoc";
            this.ThoiGianVaoHoc.Width = 150;
            // 
            // ThoiGianTanHoc
            // 
            this.ThoiGianTanHoc.DataPropertyName = "ThoiGianTanHoc";
            this.ThoiGianTanHoc.HeaderText = "Thời Gian Tan Học";
            this.ThoiGianTanHoc.MinimumWidth = 8;
            this.ThoiGianTanHoc.Name = "ThoiGianTanHoc";
            this.ThoiGianTanHoc.Width = 150;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnViewSch);
            this.panel16.Controls.Add(this.btnEditSche);
            this.panel16.Location = new System.Drawing.Point(18, 5);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(727, 70);
            this.panel16.TabIndex = 4;
            // 
            // btnViewSch
            // 
            this.btnViewSch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnViewSch.Location = new System.Drawing.Point(203, 6);
            this.btnViewSch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewSch.Name = "btnViewSch";
            this.btnViewSch.Size = new System.Drawing.Size(119, 60);
            this.btnViewSch.TabIndex = 0;
            this.btnViewSch.Text = "Xem";
            this.btnViewSch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewSch.UseVisualStyleBackColor = false;
            this.btnViewSch.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnEditSche
            // 
            this.btnEditSche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditSche.Location = new System.Drawing.Point(8, 6);
            this.btnEditSche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditSche.Name = "btnEditSche";
            this.btnEditSche.Size = new System.Drawing.Size(119, 60);
            this.btnEditSche.TabIndex = 0;
            this.btnEditSche.Text = "Sửa";
            this.btnEditSche.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditSche.UseVisualStyleBackColor = false;
            this.btnEditSche.Click += new System.EventHandler(this.btnEditSche_Click);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel25);
            this.tpAccount.Controls.Add(this.panel30);
            this.tpAccount.Controls.Add(this.panel31);
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAccount.Size = new System.Drawing.Size(1313, 501);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.btnResetPassword);
            this.panel25.Controls.Add(this.panel27);
            this.panel25.Controls.Add(this.panel28);
            this.panel25.Controls.Add(this.panel29);
            this.panel25.Location = new System.Drawing.Point(750, 75);
            this.panel25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(402, 356);
            this.panel25.TabIndex = 6;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(295, 174);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(100, 53);
            this.btnResetPassword.TabIndex = 0;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txbTypeAccount);
            this.panel27.Controls.Add(this.label11);
            this.panel27.Location = new System.Drawing.Point(3, 94);
            this.panel27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(395, 36);
            this.panel27.TabIndex = 3;
            // 
            // txbTypeAccount
            // 
            this.txbTypeAccount.Location = new System.Drawing.Point(151, 7);
            this.txbTypeAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTypeAccount.Name = "txbTypeAccount";
            this.txbTypeAccount.Size = new System.Drawing.Size(241, 22);
            this.txbTypeAccount.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Loại tài khoản";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.txbDisplayName);
            this.panel28.Controls.Add(this.label12);
            this.panel28.Location = new System.Drawing.Point(4, 54);
            this.panel28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(395, 36);
            this.panel28.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(151, 7);
            this.txbDisplayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(241, 22);
            this.txbDisplayName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên hiển thị";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.txbUserName);
            this.panel29.Controls.Add(this.label13);
            this.panel29.Location = new System.Drawing.Point(4, 14);
            this.panel29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(395, 36);
            this.panel29.TabIndex = 1;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(151, 7);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(241, 22);
            this.txbUserName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên tài khoản";
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.dgvAccount);
            this.panel30.Location = new System.Drawing.Point(14, 75);
            this.panel30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(731, 356);
            this.panel30.TabIndex = 5;
            // 
            // dgvAccount
            // 
            this.dgvAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.DisplayName,
            this.Type});
            this.dgvAccount.Location = new System.Drawing.Point(4, 4);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.RowTemplate.Height = 28;
            this.dgvAccount.Size = new System.Drawing.Size(724, 338);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên đăng nhập";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.Width = 150;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Tên hiển thị";
            this.DisplayName.MinimumWidth = 8;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Width = 150;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại tài khoản";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.btnShowAccount);
            this.panel31.Controls.Add(this.btnEditAccount);
            this.panel31.Controls.Add(this.btnDeleteAccout);
            this.panel31.Controls.Add(this.btnAddAccount);
            this.panel31.Location = new System.Drawing.Point(18, 5);
            this.panel31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(727, 70);
            this.panel31.TabIndex = 4;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShowAccount.Location = new System.Drawing.Point(589, 5);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(119, 60);
            this.btnShowAccount.TabIndex = 0;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAccount.UseVisualStyleBackColor = false;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditAccount.Location = new System.Drawing.Point(395, 5);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(119, 60);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccout
            // 
            this.btnDeleteAccout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteAccout.Location = new System.Drawing.Point(200, 5);
            this.btnDeleteAccout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccout.Name = "btnDeleteAccout";
            this.btnDeleteAccout.Size = new System.Drawing.Size(119, 60);
            this.btnDeleteAccout.TabIndex = 0;
            this.btnDeleteAccout.Text = "Xóa";
            this.btnDeleteAccout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteAccout.UseVisualStyleBackColor = false;
            this.btnDeleteAccout.Click += new System.EventHandler(this.btnDeleteAccout_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddAccount.Location = new System.Drawing.Point(5, 5);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(119, 60);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 25);
            this.tpFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFood.Size = new System.Drawing.Size(1313, 501);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Sinh viên";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.Controls.Add(this.panel32);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(742, 72);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(568, 427);
            this.panel5.TabIndex = 2;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.txbMail);
            this.panel32.Controls.Add(this.label15);
            this.panel32.Location = new System.Drawing.Point(4, 182);
            this.panel32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(395, 36);
            this.panel32.TabIndex = 5;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(115, 7);
            this.txbMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(278, 22);
            this.txbMail.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(18, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mail";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txbPhoneNumber);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 134);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(395, 36);
            this.panel10.TabIndex = 4;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(116, 7);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(278, 22);
            this.txbPhoneNumber.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(18, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "SĐT";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbName);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 94);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(395, 36);
            this.panel9.TabIndex = 3;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(116, 7);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(278, 22);
            this.txbName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(18, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbID);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(4, 6);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(395, 36);
            this.panel8.TabIndex = 2;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(115, 7);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(278, 22);
            this.txbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbIdCard);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(4, 54);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(395, 36);
            this.panel7.TabIndex = 1;
            // 
            // txbIdCard
            // 
            this.txbIdCard.Location = new System.Drawing.Point(115, 7);
            this.txbIdCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbIdCard.Name = "txbIdCard";
            this.txbIdCard.Size = new System.Drawing.Size(278, 22);
            this.txbIdCard.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Card";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvStudent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 72);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(739, 427);
            this.panel4.TabIndex = 1;
            // 
            // dgvStudent
            // 
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id_inf,
            this.card_id_inf,
            this.student_name_inf,
            this.student_phone_inf,
            this.student_email_inf});
            this.dgvStudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudent.Location = new System.Drawing.Point(4, 2);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 62;
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.Size = new System.Drawing.Size(732, 421);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // student_id_inf
            // 
            this.student_id_inf.DataPropertyName = "student_id";
            this.student_id_inf.HeaderText = "Mã sinh viên";
            this.student_id_inf.MinimumWidth = 8;
            this.student_id_inf.Name = "student_id_inf";
            this.student_id_inf.ReadOnly = true;
            this.student_id_inf.Width = 150;
            // 
            // card_id_inf
            // 
            this.card_id_inf.DataPropertyName = "card_id";
            this.card_id_inf.HeaderText = "Mã RFID";
            this.card_id_inf.MinimumWidth = 8;
            this.card_id_inf.Name = "card_id_inf";
            this.card_id_inf.ReadOnly = true;
            this.card_id_inf.Width = 150;
            // 
            // student_name_inf
            // 
            this.student_name_inf.DataPropertyName = "student_name";
            this.student_name_inf.HeaderText = "Tên sinh viên";
            this.student_name_inf.MinimumWidth = 8;
            this.student_name_inf.Name = "student_name_inf";
            this.student_name_inf.ReadOnly = true;
            this.student_name_inf.Width = 150;
            // 
            // student_phone_inf
            // 
            this.student_phone_inf.DataPropertyName = "student_phone";
            this.student_phone_inf.HeaderText = "Số điện thoại";
            this.student_phone_inf.MinimumWidth = 8;
            this.student_phone_inf.Name = "student_phone_inf";
            this.student_phone_inf.ReadOnly = true;
            this.student_phone_inf.Width = 150;
            // 
            // student_email_inf
            // 
            this.student_email_inf.DataPropertyName = "student_email";
            this.student_email_inf.HeaderText = "Mail sinh viên";
            this.student_email_inf.MinimumWidth = 8;
            this.student_email_inf.Name = "student_email_inf";
            this.student_email_inf.ReadOnly = true;
            this.student_email_inf.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnImportStudent);
            this.panel3.Controls.Add(this.btnExportStudent);
            this.panel3.Controls.Add(this.btnShowFood);
            this.panel3.Controls.Add(this.btnEditFood);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnAddStd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1307, 70);
            this.panel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.txbNameSearch);
            this.panel6.Controls.Add(this.btnSeachFood);
            this.panel6.Location = new System.Drawing.Point(739, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 68);
            this.panel6.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(4, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tên sinh viên";
            // 
            // txbNameSearch
            // 
            this.txbNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameSearch.ForeColor = System.Drawing.Color.Red;
            this.txbNameSearch.Location = new System.Drawing.Point(4, 30);
            this.txbNameSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNameSearch.Multiline = true;
            this.txbNameSearch.Name = "txbNameSearch";
            this.txbNameSearch.Size = new System.Drawing.Size(322, 34);
            this.txbNameSearch.TabIndex = 1;
            // 
            // btnSeachFood
            // 
            this.btnSeachFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeachFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSeachFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeachFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeachFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeachFood.Location = new System.Drawing.Point(334, 2);
            this.btnSeachFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeachFood.Name = "btnSeachFood";
            this.btnSeachFood.Size = new System.Drawing.Size(151, 62);
            this.btnSeachFood.TabIndex = 0;
            this.btnSeachFood.Text = "Tìm kiếm";
            this.btnSeachFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeachFood.UseVisualStyleBackColor = false;
            this.btnSeachFood.Click += new System.EventHandler(this.btnSeachFood_Click);
            // 
            // btnImportStudent
            // 
            this.btnImportStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnImportStudent.Location = new System.Drawing.Point(597, 4);
            this.btnImportStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportStudent.Name = "btnImportStudent";
            this.btnImportStudent.Size = new System.Drawing.Size(119, 60);
            this.btnImportStudent.TabIndex = 2;
            this.btnImportStudent.Text = "Import Sinh Viên";
            this.btnImportStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportStudent.UseVisualStyleBackColor = false;
            this.btnImportStudent.Click += new System.EventHandler(this.btnImportStudent_Click);
            // 
            // btnExportStudent
            // 
            this.btnExportStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExportStudent.Location = new System.Drawing.Point(482, 4);
            this.btnExportStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportStudent.Name = "btnExportStudent";
            this.btnExportStudent.Size = new System.Drawing.Size(119, 60);
            this.btnExportStudent.TabIndex = 1;
            this.btnExportStudent.Text = "Xuất Excel";
            this.btnExportStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportStudent.UseVisualStyleBackColor = false;
            this.btnExportStudent.Click += new System.EventHandler(this.btnExportStudent_Click);
            // 
            // btnShowFood
            // 
            this.btnShowFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowFood.Location = new System.Drawing.Point(361, 4);
            this.btnShowFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(119, 60);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowFood.UseVisualStyleBackColor = false;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditFood.Location = new System.Drawing.Point(242, 4);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(119, 60);
            this.btnEditFood.TabIndex = 0;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteFood.Location = new System.Drawing.Point(123, 4);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(119, 60);
            this.btnDeleteFood.TabIndex = 0;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddStd
            // 
            this.btnAddStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddStd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStd.Location = new System.Drawing.Point(4, 4);
            this.btnAddStd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.Size = new System.Drawing.Size(119, 60);
            this.btnAddStd.TabIndex = 0;
            this.btnAddStd.Text = "Thêm";
            this.btnAddStd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStd.UseVisualStyleBackColor = false;
            this.btnAddStd.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 25);
            this.tpBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBill.Size = new System.Drawing.Size(1313, 501);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Điểm danh";
            this.tpBill.UseVisualStyleBackColor = true;
            this.tpBill.Click += new System.EventHandler(this.tpBill_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 438);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnExportExcel);
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 348);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 90);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Từ ngày";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.White;
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(729, 5);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(119, 60);
            this.btnExportExcel.TabIndex = 2;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnViewBill
            // 
            this.btnViewBill.BackColor = System.Drawing.Color.White;
            this.btnViewBill.ForeColor = System.Drawing.Color.Black;
            this.btnViewBill.Location = new System.Drawing.Point(312, 5);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(119, 60);
            this.btnViewBill.TabIndex = 1;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewBill.UseVisualStyleBackColor = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkToDate.Location = new System.Drawing.Point(451, 44);
            this.dtpkToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(258, 22);
            this.dtpkToDate.TabIndex = 0;
            this.dtpkToDate.ValueChanged += new System.EventHandler(this.dtpkToDate_ValueChanged);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFromDate.Location = new System.Drawing.Point(11, 44);
            this.dtpkFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(268, 22);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.card_id,
            this.student_name,
            this.attendance_status,
            this.DateCheckIn,
            this.DateCheckOut});
            this.dtgvBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvBill.Location = new System.Drawing.Point(0, 0);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 62;
            this.dtgvBill.RowTemplate.Height = 28;
            this.dtgvBill.Size = new System.Drawing.Size(1307, 343);
            this.dtgvBill.TabIndex = 0;
            this.dtgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellContentClick);
            // 
            // student_id
            // 
            this.student_id.DataPropertyName = "student_id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id.DefaultCellStyle = dataGridViewCellStyle1;
            this.student_id.HeaderText = "Mã sinh viên";
            this.student_id.MinimumWidth = 8;
            this.student_id.Name = "student_id";
            // 
            // card_id
            // 
            this.card_id.DataPropertyName = "card_id";
            this.card_id.HeaderText = "Mã thẻ RFID";
            this.card_id.MinimumWidth = 8;
            this.card_id.Name = "card_id";
            // 
            // student_name
            // 
            this.student_name.DataPropertyName = "student_name";
            this.student_name.HeaderText = "Tên sinh viên";
            this.student_name.MinimumWidth = 8;
            this.student_name.Name = "student_name";
            // 
            // attendance_status
            // 
            this.attendance_status.DataPropertyName = "attendance_status";
            this.attendance_status.HeaderText = "Trạng thái điểm danh";
            this.attendance_status.MinimumWidth = 8;
            this.attendance_status.Name = "attendance_status";
            // 
            // DateCheckIn
            // 
            this.DateCheckIn.DataPropertyName = "DateCheckIn";
            this.DateCheckIn.HeaderText = "CheckIn";
            this.DateCheckIn.MinimumWidth = 8;
            this.DateCheckIn.Name = "DateCheckIn";
            // 
            // DateCheckOut
            // 
            this.DateCheckOut.DataPropertyName = "DateCheckOut";
            this.DateCheckOut.HeaderText = "CheckOut";
            this.DateCheckOut.MinimumWidth = 8;
            this.DateCheckOut.Name = "DateCheckOut";
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpBill);
            this.tc.Controls.Add(this.tpFood);
            this.tc.Controls.Add(this.tpAccount);
            this.tc.Controls.Add(this.tabPage2);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1321, 530);
            this.tc.TabIndex = 0;
            this.tc.SelectedIndexChanged += new System.EventHandler(this.tc_SelectedIndexChanged);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1321, 530);
            this.Controls.Add(this.tc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fAdmin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAdmin_FormClosing);
            this.Load += new System.EventHandler(this.fAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV1DataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOutMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOutHour)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrInMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrInHour)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.panel16.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel30.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel31.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tpBill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private QLSV1DataSet qLSV1DataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private QLSV1DataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private TabPage tabPage2;
        private Panel panel11;
        private Panel panel12;
        private Label label7;
        private Panel panel13;
        private Label label8;
        private Panel panel14;
        private TextBox txbThu;
        private Label label9;
        private Panel panel15;
        private DataGridView dgvSchedule;
        private DataGridViewTextBoxColumn ThuTrongTuan;
        private DataGridViewTextBoxColumn ThoiGianVaoHoc;
        private DataGridViewTextBoxColumn ThoiGianTanHoc;
        private Panel panel16;
        private Button btnViewSch;
        private Button btnEditSche;
        private TabPage tpAccount;
        private Panel panel25;
        private Button btnResetPassword;
        private Panel panel27;
        private TextBox txbTypeAccount;
        private Label label11;
        private Panel panel28;
        private TextBox txbDisplayName;
        private Label label12;
        private Panel panel29;
        private TextBox txbUserName;
        private Label label13;
        private Panel panel30;
        private DataGridView dgvAccount;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn DisplayName;
        private DataGridViewTextBoxColumn Type;
        private Panel panel31;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccout;
        private Button btnAddAccount;
        private TabPage tpFood;
        private Panel panel5;
        private Panel panel32;
        private TextBox txbMail;
        private Label label15;
        private Panel panel10;
        private TextBox txbPhoneNumber;
        private Label label4;
        private Panel panel9;
        private TextBox txbName;
        private Label label3;
        private Panel panel8;
        private TextBox txbID;
        private Label label2;
        private Panel panel7;
        private TextBox txbIdCard;
        private Label label1;
        private Panel panel4;
        private DataGridView dgvStudent;
        private DataGridViewTextBoxColumn student_id_inf;
        private DataGridViewTextBoxColumn card_id_inf;
        private DataGridViewTextBoxColumn student_name_inf;
        private DataGridViewTextBoxColumn student_phone_inf;
        private DataGridViewTextBoxColumn student_email_inf;
        private Panel panel3;
        private Panel panel6;
        private Label label14;
        private TextBox txbNameSearch;
        private Button btnSeachFood;
        private Button btnImportStudent;
        private Button btnExportStudent;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddStd;
        private TabPage tpBill;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Button btnExportExcel;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private DataGridView dtgvBill;
        private DataGridViewTextBoxColumn student_id;
        private DataGridViewTextBoxColumn card_id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn attendance_status;
        private DataGridViewTextBoxColumn DateCheckIn;
        private DataGridViewTextBoxColumn DateCheckOut;
        private TabControl tc;
        private Label label16;
        private NumericUpDown nmrInMin;
        private Label label10;
        private NumericUpDown nmrInHour;
        private Label label18;
        private NumericUpDown nmrOutMin;
        private Label label17;
        private NumericUpDown nmrOutHour;
    }
}