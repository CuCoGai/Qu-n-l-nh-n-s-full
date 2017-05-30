namespace Thuctapnhomnew
{
    partial class frmPhongban
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
            this.grbThongtinPhongban = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.grbDanhsachPhongban = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.dgvPhongban = new System.Windows.Forms.DataGridView();
            this.grbThongtinPhongban.SuspendLayout();
            this.grbDanhsachPhongban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongban)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongtinPhongban
            // 
            this.grbThongtinPhongban.Controls.Add(this.txtEmail);
            this.grbThongtinPhongban.Controls.Add(this.txtSDT);
            this.grbThongtinPhongban.Controls.Add(this.txtTen);
            this.grbThongtinPhongban.Controls.Add(this.txtMa);
            this.grbThongtinPhongban.Controls.Add(this.btnThoat);
            this.grbThongtinPhongban.Controls.Add(this.btnXoa);
            this.grbThongtinPhongban.Controls.Add(this.btnSua);
            this.grbThongtinPhongban.Controls.Add(this.btnThem);
            this.grbThongtinPhongban.Controls.Add(this.lbEmail);
            this.grbThongtinPhongban.Controls.Add(this.lbSDT);
            this.grbThongtinPhongban.Controls.Add(this.lbTen);
            this.grbThongtinPhongban.Controls.Add(this.lbMa);
            this.grbThongtinPhongban.Location = new System.Drawing.Point(1, 2);
            this.grbThongtinPhongban.Name = "grbThongtinPhongban";
            this.grbThongtinPhongban.Size = new System.Drawing.Size(746, 232);
            this.grbThongtinPhongban.TabIndex = 5;
            this.grbThongtinPhongban.TabStop = false;
            this.grbThongtinPhongban.Text = "Thông Tin Phòng Ban";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(132, 89);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(332, 20);
            this.txtSDT.TabIndex = 14;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(132, 56);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(332, 20);
            this.txtTen.TabIndex = 13;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(132, 21);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(332, 20);
            this.txtMa.TabIndex = 12;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(519, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(385, 168);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 32);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(257, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 32);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(131, 168);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 32);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(48, 128);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(48, 92);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(75, 13);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.Text = "Số Điện Thoại";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(48, 59);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(82, 13);
            this.lbTen.TabIndex = 5;
            this.lbTen.Text = "Tên Phòng Ban";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(48, 24);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(78, 13);
            this.lbMa.TabIndex = 4;
            this.lbMa.Text = "Mã Phòng Ban";
            // 
            // grbDanhsachPhongban
            // 
            this.grbDanhsachPhongban.Controls.Add(this.txtTimKiem);
            this.grbDanhsachPhongban.Controls.Add(this.lbTimKiem);
            this.grbDanhsachPhongban.Controls.Add(this.dgvPhongban);
            this.grbDanhsachPhongban.Location = new System.Drawing.Point(1, 240);
            this.grbDanhsachPhongban.Name = "grbDanhsachPhongban";
            this.grbDanhsachPhongban.Size = new System.Drawing.Size(746, 247);
            this.grbDanhsachPhongban.TabIndex = 6;
            this.grbDanhsachPhongban.TabStop = false;
            this.grbDanhsachPhongban.Text = "Danh Sách Phòng Ban";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(132, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(332, 20);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(45, 33);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(50, 13);
            this.lbTimKiem.TabIndex = 8;
            this.lbTimKiem.Text = "Tìm Kiếm";
            // 
            // dgvPhongban
            // 
            this.dgvPhongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongban.Location = new System.Drawing.Point(48, 62);
            this.dgvPhongban.Name = "dgvPhongban";
            this.dgvPhongban.Size = new System.Drawing.Size(692, 175);
            this.dgvPhongban.TabIndex = 5;
            this.dgvPhongban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongban_CellContentClick);
            // 
            // frmPhongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 489);
            this.Controls.Add(this.grbDanhsachPhongban);
            this.Controls.Add(this.grbThongtinPhongban);
            this.Name = "frmPhongban";
            this.Text = "Phòng_Ban";
            this.Load += new System.EventHandler(this.frmPhongban_Load);
            this.grbThongtinPhongban.ResumeLayout(false);
            this.grbThongtinPhongban.PerformLayout();
            this.grbDanhsachPhongban.ResumeLayout(false);
            this.grbDanhsachPhongban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongtinPhongban;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.GroupBox grbDanhsachPhongban;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.DataGridView dgvPhongban;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}