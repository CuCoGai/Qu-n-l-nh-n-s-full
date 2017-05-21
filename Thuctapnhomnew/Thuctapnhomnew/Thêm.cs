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
    public partial class frm_them : Form
    {
        public frm_them()
        {
            InitializeComponent();
        }

        private void frm_them_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            // ketnoi.openketnoi();
            //load comboBox
            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");
            //string chuoi = ketnoi.getString("NV0003");
            //MessageBox.Show("th " + chuoi);
            //  cmb_gioitinh.SelectedValue = "Nam";


            //
            cmb_tinhtranghonnhan.Items.Clear();
            cmb_tinhtranghonnhan.Items.Add("Đã kết hôn");
            cmb_tinhtranghonnhan.Items.Add("Chưa kết hôn");
            // cmb_tinhtranghonnhan.SelectedItem = "True";

        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if ((txt_manv.Text == "") || (txt_hoten.Text == "") || (dtk_ngaysinh.Text == "") || (cmb_gioitinh.Text == "") || (txt_cmtnd.Text == ""))
            //if ((txt_ID.Text == "") || (txt_ten.Text == "") )
            {
                MessageBox.Show(" Chưa có dữ liệu thêm vào", "Thông báo");
                return;
            }
            string str = @"Data Source=DESKTOP-MON8K1N\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string strcom = "insert into nhanvien(ma,ten,ngaysinh,gioitinh,soCMT,anh,dienthoai,email,quoctich,tongiao,dantoc,ngaycap,noicap,noisinh,quequan,hokhauthuongtru,noiohiennay ) values (@ma,@ten,@ngaysinh,@gioitinh,@soCMT,@anh,@dienthoai,@email,@quoctich,@tongiao,@dantoc,@ngaycap,@noicap,@noisinh,@quequan,@hokhauthuongtru,@noiohiennay )";
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

            //Boolean tinhtranghn = false;
            //if (cmb_tinhtranghonnhan.Text == "Đã kết hôn")
            //{
            //    tinhtranghn = true;
            //}
            //cmd.Parameters.AddWithValue("@tinhtranghonnnhan", tinhtranghn);
            cmd.Parameters.AddWithValue("@noisinh", txt_noisinh.Text);

            cmd.Parameters.AddWithValue("@quequan", txt_quequan.Text);
            cmd.Parameters.AddWithValue("@hokhauthuongtru", txt_thuongtru.Text);

            cmd.Parameters.AddWithValue("@noiohiennay", txt_tamtru.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Insert thành công", "Thông báo");

            
            
            con.Close();
            from2 fr = new from2();
            fr.Show();
            fr.load();
            Hide();
        }

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

    }
}

