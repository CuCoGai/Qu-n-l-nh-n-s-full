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
    public partial class frmPhongban : Form
    {
        QLNhanSuEntities1 enti = new QLNhanSuEntities1();

        public frmPhongban()
        {
            InitializeComponent();
        }

        private void frmPhongban_Load(object sender, EventArgs e)
        {
            FillData();
        }

        public void FillData()
        {
            this.dgvPhongban.DataSource = enti.phongbans.ToList();
            this.dgvPhongban.Columns[0].HeaderText = "Mã";
            this.dgvPhongban.Columns[1].HeaderText = "Tên";
            this.dgvPhongban.Columns[2].HeaderText = "Số Điện Thoại";
            this.dgvPhongban.Columns[3].HeaderText = "Email";
        }

        private void dgvPhongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mapb = this.dgvPhongban.CurrentRow.Cells[0].Value.ToString();
            PhongBan pb = enti.phongbans.Single(s => s.ma.equals(mapb));
            txtMa.Text = pb.;
            txtTen.Text = pb.;
            txtSDT.Text = pb.;
            txtEmail.Text = pb.;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PhongBan pb = new PhongBan();
                pb.mã = txtMa.Text;
                pb.tên = txtTen.Text;
                pb.SDT = txtSDT.Text;
                pb.email = txtEmail.Text;
                enti.phongbans.Add(pb);
                enti.SaveChanges();
                FillData();
                MessageBox.Show("Thêm phòng ban thành công!!!");
            }
            catch
            {
                MessageBox.Show("Không thể thêm phòng ban!!!");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Sửa thông tin phòng ban thành công!!!");
            }
            catch
            {
                MessageBox.Show("Không thể sửa thông tin phòng ban!!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String mapb = this.dgvPhongban.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    PhongBan pb = enti.phongbans.Single(s => s.ma.Equals(mapb));
                    enti.phongbans.Remove(pb);
                    enti.SaveChanges();
                    FillData();
                    MessageBox.Show("Delete Success");
                }
                catch
                {
                    MessageBox.Show("Delete fail!!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frm_trangchu f = new frm_trangchu();
            f.Show();
            this.Hide();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            QLNhanSuEntities1 enti = new QLNhanSuEntities1();
            var Lst = (from s in enti.phongbans where s.TenHang.Contains(txtTimKiem.Text) select s).ToList();
            dgvPhongban.DataSource = Lst;
            txtMa.DataBindings.Clear();
            txtTen.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtMa.DataBindings.Add("text", Lst, "Mã");
            txtTen.DataBindings.Add("text", Lst, "Tên");
            txtSDT.DataBindings.Add("text", Lst, "");
            txtEmail.DataBindings.Add("text", Lst, "Email");
        }
    }
}
