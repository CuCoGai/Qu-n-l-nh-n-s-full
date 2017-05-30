namespace Thuctapnhomnew
{
    partial class frmHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.tabQuanLyHopDong = new System.Windows.Forms.TabControl();
            this.tabpageDanhSach = new System.Windows.Forms.TabPage();
            this.tabpageThem = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNgayKy = new System.Windows.Forms.DateTimePicker();
            this.dateNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.groupThem = new System.Windows.Forms.GroupBox();
            this.btnLuuThem = new System.Windows.Forms.Button();
            this.btnBoQuaThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupSua = new System.Windows.Forms.GroupBox();
            this.btnBoQuanSua = new System.Windows.Forms.Button();
            this.btnLuuSua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.xóaHợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabQuanLyHopDong.SuspendLayout();
            this.tabpageDanhSach.SuspendLayout();
            this.tabpageThem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupThem.SuspendLayout();
            this.groupSua.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.context.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQuanLyHopDong
            // 
            this.tabQuanLyHopDong.Controls.Add(this.tabpageDanhSach);
            this.tabQuanLyHopDong.Controls.Add(this.tabpageThem);
            this.tabQuanLyHopDong.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuanLyHopDong.Location = new System.Drawing.Point(21, 95);
            this.tabQuanLyHopDong.Name = "tabQuanLyHopDong";
            this.tabQuanLyHopDong.SelectedIndex = 0;
            this.tabQuanLyHopDong.Size = new System.Drawing.Size(635, 354);
            this.tabQuanLyHopDong.TabIndex = 0;
            // 
            // tabpageDanhSach
            // 
            this.tabpageDanhSach.Controls.Add(this.groupBox6);
            this.tabpageDanhSach.Controls.Add(this.groupBox5);
            this.tabpageDanhSach.Controls.Add(this.groupBox4);
            this.tabpageDanhSach.Location = new System.Drawing.Point(4, 26);
            this.tabpageDanhSach.Name = "tabpageDanhSach";
            this.tabpageDanhSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageDanhSach.Size = new System.Drawing.Size(627, 324);
            this.tabpageDanhSach.TabIndex = 0;
            this.tabpageDanhSach.Text = "Danh sách hợp đồng";
            this.tabpageDanhSach.UseVisualStyleBackColor = true;
            // 
            // tabpageThem
            // 
            this.tabpageThem.Controls.Add(this.groupSua);
            this.tabpageThem.Controls.Add(this.groupThem);
            this.tabpageThem.Controls.Add(this.groupBox1);
            this.tabpageThem.Location = new System.Drawing.Point(4, 26);
            this.tabpageThem.Name = "tabpageThem";
            this.tabpageThem.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageThem.Size = new System.Drawing.Size(627, 324);
            this.tabpageThem.TabIndex = 1;
            this.tabpageThem.Text = "Hợp đồng";
            this.tabpageThem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.dateNgayBatDau);
            this.groupBox1.Controls.Add(this.dateNgayKetThuc);
            this.groupBox1.Controls.Add(this.dateNgayKy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hợp đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hợp đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương thử việc";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(120, 30);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(150, 24);
            this.txtMa.TabIndex = 3;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(120, 104);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(150, 24);
            this.txtLuong.TabIndex = 4;
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(120, 69);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 24);
            this.txtTen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày ký";
            // 
            // dateNgayKy
            // 
            this.dateNgayKy.CustomFormat = "dd/MM/yyyy";
            this.dateNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayKy.Location = new System.Drawing.Point(432, 26);
            this.dateNgayKy.Name = "dateNgayKy";
            this.dateNgayKy.Size = new System.Drawing.Size(120, 24);
            this.dateNgayKy.TabIndex = 9;
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dateNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayKetThuc.Location = new System.Drawing.Point(432, 105);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Size = new System.Drawing.Size(120, 24);
            this.dateNgayKetThuc.TabIndex = 10;
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dateNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayBatDau.Location = new System.Drawing.Point(432, 65);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Size = new System.Drawing.Size(120, 24);
            this.dateNgayBatDau.TabIndex = 11;
            // 
            // groupThem
            // 
            this.groupThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupThem.Controls.Add(this.btnBoQuaThem);
            this.groupThem.Controls.Add(this.btnLuuThem);
            this.groupThem.Location = new System.Drawing.Point(442, 200);
            this.groupThem.Name = "groupThem";
            this.groupThem.Size = new System.Drawing.Size(159, 78);
            this.groupThem.TabIndex = 1;
            this.groupThem.TabStop = false;
            this.groupThem.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnLuuThem
            // 
            this.btnLuuThem.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuThem.Image")));
            this.btnLuuThem.Location = new System.Drawing.Point(23, 19);
            this.btnLuuThem.Name = "btnLuuThem";
            this.btnLuuThem.Size = new System.Drawing.Size(48, 41);
            this.btnLuuThem.TabIndex = 1;
            this.btnLuuThem.UseVisualStyleBackColor = true;
            this.btnLuuThem.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQuaThem
            // 
            this.btnBoQuaThem.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQuaThem.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQuaThem.Image")));
            this.btnBoQuaThem.Location = new System.Drawing.Point(86, 19);
            this.btnBoQuaThem.Name = "btnBoQuaThem";
            this.btnBoQuaThem.Size = new System.Drawing.Size(48, 41);
            this.btnBoQuaThem.TabIndex = 2;
            this.btnBoQuaThem.UseVisualStyleBackColor = true;
            this.btnBoQuaThem.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("StarsStripes", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(203, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "QUẢN LÝ HỢP ĐỒNG LAO ĐỘNG";
            // 
            // groupSua
            // 
            this.groupSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupSua.Controls.Add(this.btnBoQuanSua);
            this.groupSua.Controls.Add(this.btnLuuSua);
            this.groupSua.Controls.Add(this.btnSua);
            this.groupSua.Location = new System.Drawing.Point(138, 200);
            this.groupSua.Name = "groupSua";
            this.groupSua.Size = new System.Drawing.Size(214, 78);
            this.groupSua.TabIndex = 3;
            this.groupSua.TabStop = false;
            // 
            // btnBoQuanSua
            // 
            this.btnBoQuanSua.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQuanSua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQuanSua.Image")));
            this.btnBoQuanSua.Location = new System.Drawing.Point(149, 19);
            this.btnBoQuanSua.Name = "btnBoQuanSua";
            this.btnBoQuanSua.Size = new System.Drawing.Size(48, 41);
            this.btnBoQuanSua.TabIndex = 2;
            this.btnBoQuanSua.UseVisualStyleBackColor = true;
            this.btnBoQuanSua.Click += new System.EventHandler(this.btnBoQuanSua_Click);
            // 
            // btnLuuSua
            // 
            this.btnLuuSua.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuSua.Image")));
            this.btnLuuSua.Location = new System.Drawing.Point(85, 19);
            this.btnLuuSua.Name = "btnLuuSua";
            this.btnLuuSua.Size = new System.Drawing.Size(48, 41);
            this.btnLuuSua.TabIndex = 1;
            this.btnLuuSua.UseVisualStyleBackColor = true;
            this.btnLuuSua.Click += new System.EventHandler(this.btnLuuSua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(21, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(48, 41);
            this.btnSua.TabIndex = 0;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox4.Controls.Add(this.btnXem);
            this.groupBox4.Controls.Add(this.dateFrom);
            this.groupBox4.Controls.Add(this.dateTo);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(34, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 88);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thời gian ký";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(90, 22);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(120, 24);
            this.dateFrom.TabIndex = 15;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(90, 55);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(120, 24);
            this.dateTo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Đến ngày";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Từ ngày";
            // 
            // btnXem
            // 
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.Location = new System.Drawing.Point(223, 28);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(50, 44);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox5.Controls.Add(this.btnTimKiem);
            this.groupBox5.Controls.Add(this.txtTimKiem);
            this.groupBox5.Location = new System.Drawing.Point(361, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 88);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(26, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(182, 24);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Sienna;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.Location = new System.Drawing.Point(131, 56);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvDanhSach);
            this.groupBox6.Location = new System.Drawing.Point(16, 110);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(595, 196);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.ContextMenuStrip = this.context;
            this.dgvDanhSach.Location = new System.Drawing.Point(18, 19);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(562, 161);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtToolStripMenuItem,
            this.sửaHợpĐồngToolStripMenuItem,
            this.xóaHợpĐồngToolStripMenuItem});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(150, 70);
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            this.xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            this.xemChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.xemChiTiếtToolStripMenuItem.Text = "Xem chi tiết";
            this.xemChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.xemChiTiếtToolStripMenuItem_Click);
            // 
            // sửaHợpĐồngToolStripMenuItem
            // 
            this.sửaHợpĐồngToolStripMenuItem.Name = "sửaHợpĐồngToolStripMenuItem";
            this.sửaHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sửaHợpĐồngToolStripMenuItem.Text = "Sửa hợp đồng";
            this.sửaHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.sửaHợpĐồngToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnList);
            this.groupBox2.Location = new System.Drawing.Point(12, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 55);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Maroon;
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(11, 13);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(35, 36);
            this.btnList.TabIndex = 0;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(93, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(52, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // xóaHợpĐồngToolStripMenuItem
            // 
            this.xóaHợpĐồngToolStripMenuItem.Name = "xóaHợpĐồngToolStripMenuItem";
            this.xóaHợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.xóaHợpĐồngToolStripMenuItem.Text = "Xóa hợp đồng";
            this.xóaHợpĐồngToolStripMenuItem.Click += new System.EventHandler(this.xóaHợpĐồngToolStripMenuItem_Click);
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabQuanLyHopDong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHopDong";
            this.Text = "Quản lý hợp đồng";
            this.Load += new System.EventHandler(this.groupThem_Load);
            this.tabQuanLyHopDong.ResumeLayout(false);
            this.tabpageDanhSach.ResumeLayout(false);
            this.tabpageThem.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupThem.ResumeLayout(false);
            this.groupSua.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.context.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabQuanLyHopDong;
        private System.Windows.Forms.TabPage tabpageDanhSach;
        private System.Windows.Forms.TabPage tabpageThem;
        private System.Windows.Forms.GroupBox groupThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNgayBatDau;
        private System.Windows.Forms.DateTimePicker dateNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateNgayKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoQuaThem;
        private System.Windows.Forms.Button btnLuuThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupSua;
        private System.Windows.Forms.Button btnBoQuanSua;
        private System.Windows.Forms.Button btnLuuSua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaHợpĐồngToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ToolStripMenuItem xóaHợpĐồngToolStripMenuItem;
    }
}