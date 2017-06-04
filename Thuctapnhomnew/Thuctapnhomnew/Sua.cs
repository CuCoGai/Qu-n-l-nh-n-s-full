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
   

    public partial class Sua : Form
    {
       private string id;
        private string path;

        public Sua(string id)
        {
            InitializeComponent();

            QLNhanSuEntities nv = new QLNhanSuEntities();
            nhanvien newnv = nv.nhanviens.Single(s => s.ma == id);
            string path = newnv.anh.ToString();
            if (!string.IsNullOrWhiteSpace(path))
            {
                MemoryStream ms = new MemoryStream((byte[])newnv.anh);
                ptb_anh.Image = Image.FromStream(ms);

            }
            else
                ptb_anh.Image = null;
           
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
            //txt_mahd.Text = newnv.hopdonglaodongnhanvienma;
            //var tenhd = from s in nv.hopdonglaodongnhanviens where s.ma == newnv.hopdonglaodongnhanvienma select s.ten;
            //var luongcoban = from s in nv.hopdonglaodongnhanviens where s.ma == newnv.hopdonglaodongnhanvienma select s.luongthuviec;
            //var ngaybd = from s in nv.hopdonglaodongnhanviens where s.ma == newnv.hopdonglaodongnhanvienma select s.ngaybatdau;
            //var ngaykt = from s in nv.hopdonglaodongnhanviens where s.ma == newnv.hopdonglaodongnhanvienma select s.ngayketthuc;
            //txt_tenhd.Text = tenhd.FirstOrDefault();
            //txt_luongcb.Text = luongcoban.FirstOrDefault().ToString();
            //txt_ngaykt.Text = ngaykt.FirstOrDefault().ToString();


        }

        //public Sua(string id, string path) : this(id)
        //{
        //    this.path = path;
        //}

        //public Sua(string id)
        //{
        //    this.id = id;
        //}

        private void btn_brown_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = openfile.Filter = "JPG file(*.jpg)|*.jpg|All files (*.*)|*.*";
            openfile.FilterIndex = 1;
            openfile.RestoreDirectory = true;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                ptb_anh.ImageLocation = openfile.FileName;

            }
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

        private void lbl_SDT_Click(object sender, EventArgs e)
        {

        }

        //private void Sua_Load(object sender, EventArgs e)
        //{
        //    load();
        //}
        public void load()
        {
            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");

            //
            cmb_tinhtranghonnhan.Items.Clear();
            cmb_tinhtranghonnhan.Items.Add("Đã kết hôn");
            cmb_tinhtranghonnhan.Items.Add("Chưa kết hôn");

        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=DESKTOP-MON8K1N\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string strcom = "update nhanvien set ma=@ma,ten=@ten,ngaysinh=@ngaysinh,gioitinh=@gioitinh,soCMT=@soCMT,anh=@anh,dienthoai=@dienthoai,email=@email,quoctich=@quoctich,tongiao=@tongiao,dantoc=@dantoc,ngaycap=@ngaycap,noicap=@noicap,tinhtranghonnhan=@tinhtranghonnhan,noisinh=@noisinh,quequan=@quequan,hokhauthuongtru=@hokhauthuongtru,noiohiennay=@noiohiennay where ma='" + txt_manv.Text+ "'";

            SqlCommand cmd = new SqlCommand(strcom, con);

            cmd.Parameters.AddWithValue("@ma", txt_manv.Text);
            cmd.Parameters.AddWithValue("@ten", txt_hoten.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(dtk_ngaysinh.Text));
            Boolean gioiTinh = false;
            if (cmb_gioitinh.Text == "Nam")
            {
                gioiTinh = true;
            }


            cmd.Parameters.AddWithValue("@gioitinh", gioiTinh);
            cmd.Parameters.AddWithValue("@soCMT", txt_cmtnd.Text);
            MemoryStream str1 = new MemoryStream();
            ptb_anh.Image.Save(str1, System.Drawing.Imaging.ImageFormat.Jpeg);

            byte[] pic = str1.ToArray();
            cmd.Parameters.AddWithValue("@anh", pic);

            cmd.Parameters.AddWithValue("@dienthoai", txt_sdt.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);

            cmd.Parameters.AddWithValue("@quoctich", txt_quoctich.Text);
            cmd.Parameters.AddWithValue("@tongiao", txt_tongiao.Text);

            cmd.Parameters.AddWithValue("@dantoc", txt_dantoc.Text);
            cmd.Parameters.AddWithValue("@ngaycap", DateTime.Parse(dtp_ngaycap.Text));

            cmd.Parameters.AddWithValue("@noicap", txt_noicap.Text);

            Boolean tinhtranghn = false;
            if (cmb_tinhtranghonnhan.Text == "Đã kết hôn")
            {
                tinhtranghn = true;
            }
            cmd.Parameters.AddWithValue("@tinhtranghonnhan", tinhtranghn);

            cmd.Parameters.AddWithValue("@noisinh", txt_noisinh.Text);

            cmd.Parameters.AddWithValue("@quequan", txt_quequan.Text);
            cmd.Parameters.AddWithValue("@hokhauthuongtru", txt_thuongtru.Text);

            cmd.Parameters.AddWithValue("@noiohiennay", txt_tamtru.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            from2 fr = new from2();
            fr.Show(this);
            fr.load();
        }

        private void Sua_Load_1(object sender, EventArgs e)
        {
            load();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            from2 fr = new from2();
            fr.Show();
            Hide();

        }
    }
}
