using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Thuctapnhomnew
{
    public partial class from2 : Form
    {
        QLNhanSuEntities1 db = new QLNhanSuEntities1();
        public from2()
        {
            InitializeComponent();
        }
        DataGridView dt;
        public from2(DataGridView dgv_dsnv)
        {
            InitializeComponent();
            dgv_dsnv = dt;
        }

        public static class ketnoi
        {

            public static string chuoiketnoi = @"Data Source=AMYHUYENDIEU;Initial Catalog=QLNhanSu;Integrated Security=True";
            //  public static string chuoiketnoi = @"Data Source=HONG_NGOC\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            public static SqlConnection con;
            public static SqlCommand cmd;
            public static SqlDataAdapter da;
            public static DataTable dt;


            public static void openketnoi()
            {
                con = new SqlConnection(chuoiketnoi);
                con.Open();
            }
            public static void dongketnoi()
            {
                con.Close();
            }
            // phuong thuc get
            public static DataTable gettable(string sql)
            {
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            public static void executeQuery(string sql)
            {
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_them fr = new frm_them();
            fr.Show();
            Hide();
        }

        private void from2_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            ketnoi.openketnoi();
            //load comboBox
            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");

            //
            cmb_tinhtranghonnhan.Items.Clear();
            cmb_tinhtranghonnhan.Items.Add("Đã kết hôn");
            cmb_tinhtranghonnhan.Items.Add("Chưa kết hôn");
            // cmb_tinhtranghonnhan.SelectedItem = "True";



            //Load DataGridView
            dgv_dsnv.DataSource = ketnoi.gettable("select ma as N'Mã',ten as N'Họ tên',ngaysinh as N'Ngày sinh', case gioitinh when 1 then 'Nam' when 0 then N'Nữ' end as N'Gioi tinh',soCMT as N'CMTND',anh as N'Ảnh nhân viên',dienthoai as N'SĐT',email,quoctich,tongiao,dantoc,ngaycap,noicap,case tinhtranghonnhan when 1 then N'Đã kết hôn' when 0 then N'Chưa kết hôn 'end as N'Trình trạng hôn nhân',noisinh,quequan,hokhauthuongtru,noiohiennay   from nhanvien");

            // btn_chapnhan.Enabled = false;
            //  btn_huy.Enabled = false;
            ketnoi.dongketnoi();
        }

        private void dgv_dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = dgv_dsnv.CurrentRow.Cells[5].Value.ToString();


            if (!string.IsNullOrWhiteSpace(path))
            {
                MemoryStream ms = new MemoryStream((byte[])dgv_dsnv.CurrentRow.Cells[5].Value);
                ptb_anh.Image = Image.FromStream(ms);

            }
            else
                ptb_anh.Image = null;
            string id = dgv_dsnv.CurrentRow.Cells[0].Value.ToString();
            QLNhanSuEntities1 nv = new QLNhanSuEntities1();
            nhanvien newnv = nv.nhanviens.Single(s => s.ma == id);
            txt_manv.Text = newnv.ma;
            txt_hoten.Text = newnv.ten;
            dtk_ngaysinh.Text = newnv.ngaysinh.ToString();

            if (newnv.gioitinh.Value == false)
            {
                cmb_gioitinh.Text = "Nữ";
            }
            else
            {
                cmb_gioitinh.Text = "Nam";
            }
            txt_sdt.Text = newnv.dienthoai;
            txt_email.Text = newnv.email;
            txt_quoctich.Text = newnv.quoctich;
            txt_dantoc.Text = newnv.dantoc;
            txt_tongiao.Text = newnv.tongiao;
            if (newnv.tinhtranghonnhan == false)
            {
                cmb_tinhtranghonnhan.Text = "Chưa kết hôn";
            }
            else
            { cmb_tinhtranghonnhan.Text = "Đã kết hôn"; }
            txt_cmtnd.Text = newnv.soCMT;
            dtp_ngaycap.Text = newnv.ngaycap.ToString();
            txt_noicap.Text = newnv.noicap;
            txt_noisinh.Text = newnv.noisinh;
            txt_quequan.Text = newnv.quequan;
            txt_tamtru.Text = newnv.noiohiennay;
            txt_thuongtru.Text = newnv.hokhauthuongtru;
            txt_hocvan.Text = newnv.hocvanma;
            txt_chucvu.Text = newnv.chucvuma;
            txt_ngoaingu.Text = newnv.trinhdongoaingu;
            txt_maphongban.Text = newnv.phongbanma;
            txt_mahd.Text = newnv.hopdonglaodongnhanvienma;
            var tenhd = from s in nv.hopdonglaodongnhanviens where s.ma == newnv.hopdonglaodongnhanvienma select s.ten;
            var luongcoban = from s in nv.hopdonglaodongnhanviens where s.ma == newnv.hopdonglaodongnhanvienma select s.luongthuviec;
            var ngaybd = from s in nv.hopdonglaodongnhanviens where s.ma == newnv.hopdonglaodongnhanvienma select s.ngaybatdau;
            var ngaykt = from s in nv.hopdonglaodongnhanviens where s.ma == newnv.hopdonglaodongnhanvienma select s.ngayketthuc;
            txt_tenhd.Text = tenhd.FirstOrDefault();
            txt_luongcb.Text = luongcoban.FirstOrDefault().ToString();
            txt_ngaykt.Text = ngaykt.FirstOrDefault().ToString();

        }

        private byte[] convertFilToBytes(string spath)
        {

            byte[] data = null;
            FileInfo finfo = new FileInfo(spath);
            long numBytes = finfo.Length;
            FileStream fs = new FileStream(spath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            data = br.ReadBytes((int)numBytes);
            return data;

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string id =dgv_dsnv.CurrentRow.Cells[0].Value.ToString();
            Sua fr = new Sua(id);
            fr.Show(this);
            Hide();
        
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_dsnv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cần chọn dữ liệu để xóa!", "Thông báo");
                return;
            }
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                ketnoi.openketnoi();
                ketnoi.executeQuery("delete from nhanvien where ma='" + dgv_dsnv.Rows[dgv_dsnv.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                load();
                ketnoi.dongketnoi();
            }
        }



        #region lương nhân viên
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.dataGridViewLuong.DataSource = db.luongnhanviens.ToList();
            this.dataGridViewLuong.Columns[0].HeaderText = "Mã Nhân Viên";
            this.dataGridViewLuong.Columns[1].HeaderText = "Mã LCB";
            this.dataGridViewLuong.Columns[2].HeaderText = "Mã PC";
            this.dataGridViewLuong.Columns[3].HeaderText = "Số ngày công";
            this.dataGridViewLuong.Columns[4].HeaderText = "Số giờ làm thêm";
            this.dataGridViewLuong.Columns[5].HeaderText = "Thưởng";
            this.dataGridViewLuong.Columns[6].HeaderText = "Tạm Ứng";
            this.dataGridViewLuong.Columns[7].HeaderText = "Ngày Lập";

        }
        void Save()
        {
            DialogResult dlr = MessageBox.Show("Lưu tất cả thay đổi?",
                            "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                db.SaveChanges();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                luongnhanvien luongnv = new luongnhanvien();
                luongnv.nhanvienma = this.tbxMaNV_L.Text;
                luongnv.ma = this.tbxIDLuong.Text;
                luongnv.phucapma = this.tbxMaPC.Text;
                luongnv.luongcobanma = this.tbxMaLCB.Text;
                luongnv.SoNgayCong = Int32.Parse(tbxNgayCong.Text);
                luongnv.SoGioLamThem = Int32.Parse(tbcGioLamThem.Text);
                luongnv.Thuong = Int32.Parse(tbxThuong.Text);
                luongnv.TamUng = Int32.Parse(tbxTamUng.Text);
                
                db.luongnhanviens.Add(luongnv);
                MessageBox.Show("Thêm Thành Công!!!");
            }
            catch
            {
                MessageBox.Show("Thêm Thất bại!!");
            }
            Save();
        }


        

        private void btnDel_Click(object sender, EventArgs e)
        {
            String ma = this.dataGridViewLuong.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    luongnhanvien h = db.luongnhanviens.Single(s => s.ma.Equals(ma));
                    db.luongnhanviens.Remove(h);
                    db.SaveChanges();
                    MessageBox.Show("Delete Success");
                }
                catch
                {
                    MessageBox.Show("Delete fail!!");
                }
            }

            Save();
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(this.dataGridViewLuong.CurrentRow.Cells[0].Value.ToString());
            luongnhanvien dt = db.luongnhanviens.Single(s => s.ma.Equals(ma));
            if (this.tbxMaNV_L.Text.Length != 0)
                dt.nhanvienma = tbxMaNV_L.Text;
            if (this.tbxMaLCB.Text.Length != 0)
                dt.luongcobanma = this.tbxMaLCB.Text;
            if (this.tbxMaPC.Text.Length != 0)
                dt.phucapma = this.tbxMaPC.Text;
            if (this.tbxIDLuong.Text.Length != 0)
                dt.ma = this.tbxIDLuong.Text;
            if (this.tbxNgayCong.Text.Length != 0)
                dt.SoNgayCong = Int32.Parse(tbxNgayCong.Text);
            if (this.tbcGioLamThem.Text.Length != 0)
                dt.SoGioLamThem = Int32.Parse(tbcGioLamThem.Text);
            if (this.tbxThuong.Text.Length != 0)
                dt.Thuong = Int32.Parse( tbxThuong.Text);
            if (this.tbxTamUng.Text.Length != 0)
                dt.TamUng = Int32.Parse(tbxTamUng.Text);
            dt.NgayLap = DateTime.Parse( dtpkNgayLapLuong.Text);

            db.SaveChanges();
        }


        private void btnShowLCB_Click(object sender, EventArgs e)
        {
            this.dataGridViewLuong.DataSource = db.luongcobans.ToList();
            this.dataGridViewLuong.Columns[0].HeaderText = "Mã LCB";
            this.dataGridViewLuong.Columns[1].HeaderText = "Hệ số";
            this.dataGridViewLuong.Columns[2].HeaderText = "Tên";
            this.dataGridViewLuong.Columns[3].HeaderText = "Mã Học vấn";
            this.dataGridViewLuong.Columns[4].HeaderText = "Giá trị";
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dataGridViewLuong.DataSource = db.phucaps.ToList();
            this.dataGridViewLuong.Columns[0].HeaderText = "Mã PC";
            this.dataGridViewLuong.Columns[1].HeaderText = "Hệ số";
            this.dataGridViewLuong.Columns[2].HeaderText = "Mã Chức vụ";
        }

        #endregion
    }
}