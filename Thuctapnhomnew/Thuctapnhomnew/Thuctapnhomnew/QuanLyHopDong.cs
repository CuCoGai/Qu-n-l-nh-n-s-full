using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuctapnhomnew
{
    
    public partial class frmHopDong : Form
    {
        QLNhanSuEntities db=new QLNhanSuEntities();
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            hopdonglaodongnhanvien hd=new hopdonglaodongnhanvien();
           hd.ma = txtMa.Text;
                hd.ten = txtTen.Text;
                hd.luongthuviec = decimal.Parse(txtLuong.Text);
                hd.ngaybatdau = dateNgayBatDau.Value;
                hd.ngayky = dateNgayKy.Value;
                hd.ngayketthuc = dateNgayKetThuc.Value;
                db.hopdonglaodongnhanviens.Add(hd);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Thêm mới hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                groupThem_Load(sender, e);  //load lai form
            }
            catch (Exception)
            {
                MessageBox.Show("Không thế thêm hợp đồng!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(txtLuong.Text);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            groupThem_Load(sender, e);
        }

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            hopdonglaodongnhanvien hd = db.hopdonglaodongnhanviens.Where(s => s.ma == txtMa.Text).SingleOrDefault();
           hd.ten = txtTen.Text;
            
            try
            {
                hd.luongthuviec = decimal.Parse(txtLuong.Text);
                hd.ngaybatdau = dateNgayBatDau.Value;
                hd.ngayky = dateNgayKy.Value;
                hd.ngayketthuc = dateNgayKetThuc.Value;
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sửa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    groupThem_Load(sender, e);  //load lai form
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thế sửa hợp đồng!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lại tiền lương!", "Nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridViewLoad()
        {
            for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
            {
                dgvDanhSach.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            dgvDanhSach.Columns[0].HeaderText = "Mã hợp đồng";
            dgvDanhSach.Columns[0].Width = 100;
            dgvDanhSach.Columns[1].HeaderText = "Tên hợp đồng";
            dgvDanhSach.Columns[1].Width = 150;
            dgvDanhSach.Columns[2].HeaderText = "Lương khởi điểm";
            dgvDanhSach.Columns[2].Width = 100;
            dgvDanhSach.Columns[3].HeaderText = "Ngày ký hợp đồng";
            dgvDanhSach.Columns[3].Width = 150;
        }
        private void groupThem_Load(object sender, EventArgs e)
        {
            var query = from s in db.hopdonglaodongnhanviens where s.Status==true
                select new {ma = s.ma, ten = s.ten, luong = s.luongthuviec, ngayky = s.ngayky};

            dgvDanhSach.DataSource = query.ToList();
            tabQuanLyHopDong.SelectedTab = tabpageDanhSach;
            DataGridViewLoad();
            groupSua.Visible = false;
            groupThem.Visible = true;

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            var query = from s in db.hopdonglaodongnhanviens where s.ngayky>=dateFrom.Value && s.ngayky<=dateTo.Value
                        select new { ma = s.ma, ten = s.ten, luong = s.luongthuviec, ngayky = s.ngayky };
            dgvDanhSach.DataSource = query.ToList();
            DataGridViewLoad();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var query=from s in db.hopdonglaodongnhanviens where s.ma.Contains(txtTimKiem.Text) || s.ten.Contains(txtTimKiem.Text)
                      select new { ma = s.ma, ten = s.ten, luong = s.luongthuviec, ngayky = s.ngayky };
            dgvDanhSach.DataSource = query.ToList();
            DataGridViewLoad();
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            hopdonglaodongnhanvien current = db.hopdonglaodongnhanviens.Where(s => s.ma == ma).FirstOrDefault();
            txtMa.Text = current.ma;
            txtTen.Text = current.ten;
            txtLuong.Text = current.luongthuviec.ToString();
            dateNgayKy.Value = current.ngayky.Value;
            dateNgayBatDau.Value = current.ngaybatdau.Value;
            dateNgayKetThuc.Value = current.ngayketthuc.Value;

            //sua trang thai
            tabQuanLyHopDong.SelectedTab = tabpageThem;
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtLuong.ReadOnly = true;
            dateNgayKy.Enabled = false;
            dateNgayBatDau.Enabled = false;
            dateNgayKetThuc.Enabled = false;
            groupSua.Visible = true;
            groupThem.Visible = false;
            btnLuuSua.Visible = false;
           
        }

        private void sửaHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            hopdonglaodongnhanvien current = db.hopdonglaodongnhanviens.Where(s => s.ma == ma).FirstOrDefault();
            txtMa.Text = current.ma;
           
            try
            {
                txtTen.Text = current.ten;
            }
            catch (Exception)
            {
                txtTen.Text = "0";
                throw;
            }
            try
            {
                txtLuong.Text = current.luongthuviec.ToString();
            }
            catch (Exception)
            {
                txtLuong.Text = "0";
            }
            try
            {
                dateNgayKy.Value = current.ngayky.Value;
            }
            catch (Exception)
            {
                dateNgayKy.Value=DateTime.Now;
            }
            try
            {
                dateNgayBatDau.Value = current.ngaybatdau.Value;
            }
            catch (Exception)
            {
                dateNgayBatDau.Value=DateTime.Now;
            }
            try
            {
                dateNgayKetThuc.Value = current.ngayketthuc.Value;
            }
            catch (Exception)
            {
                dateNgayKetThuc.Value = DateTime.Now;
            }
            tabQuanLyHopDong.SelectedTab = tabpageThem;
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = false;
            txtLuong.ReadOnly = false;
            dateNgayKy.Enabled = true;
            dateNgayBatDau.Enabled = true;
            dateNgayKetThuc.Enabled = true;
            groupSua.Visible = true;
            groupThem.Visible = false;
            btnLuuSua.Visible = true;
            btnSua.Visible = false;
        }

        private void btnBoQuanSua_Click(object sender, EventArgs e)
        {
            groupThem_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMa.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtLuong.ReadOnly = false;
            dateNgayKy.Enabled = true;
            dateNgayBatDau.Enabled = true;
            dateNgayKetThuc.Enabled = true;
            groupSua.Visible = true;
            groupThem.Visible = false;
            btnLuuSua.Visible = true;
            btnSua.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
           groupThem_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tabQuanLyHopDong.SelectedTab = tabpageThem;
            txtMa.ReadOnly = false;
            txtMa.Text = null;
            txtTen.Text = null;
            txtLuong.Text ="0";
            groupSua.Visible = false;
            groupThem.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_trangchu fr = new frm_trangchu();
            fr.EnableMenu();
            fr.Show();
            Hide();
        }

        private void xóaHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            hopdonglaodongnhanvien current = db.hopdonglaodongnhanviens.Where(s => s.ma == ma).FirstOrDefault();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hợp đồng không?", "Xóa",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    current.Status = false;
                    db.SaveChanges();
                    MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa hợp đồng!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                }
                groupThem_Load(sender, e);
            }
           
        }
    }
}
