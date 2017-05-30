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
           
            cmb_gioitinh.Items.Clear();
            cmb_gioitinh.Items.Add("Nam");
            cmb_gioitinh.Items.Add("Nữ");
           


            //
            cmb_tinhtranghonnhan.Items.Clear();
            cmb_tinhtranghonnhan.Items.Add("Đã kết hôn");
            cmb_tinhtranghonnhan.Items.Add("Chưa kết hôn");
            // cmb_tinhtranghonnhan.SelectedItem = "True";

        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            QLNhanSuEntities db = new QLNhanSuEntities();
            nhanvien n = new nhanvien();
            n.ma = txt_manv.Text;
            n.ten = txt_hoten.Text;

            Boolean gioiTinh = false;
            if (cmb_gioitinh.Text == "Nam")
            {
                gioiTinh = true;
            }
            n.gioitinh = gioiTinh;

            n.ngaysinh = DateTime.Parse(dtk_ngaysinh.Text);
            n.soCMT = txt_cmtnd.Text;

            try
            {
                MemoryStream str1 = new MemoryStream();
                ptb_anh.Image.Save(str1, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] pic = str1.ToArray();
                n.anh = pic;
            }
            catch
            {
                n.anh = null;

            }
            n.dienthoai = txt_sdt.Text;
            n.email = txt_email.Text;
            n.quoctich = txt_quoctich.Text;
            n.tongiao = txt_tongiao.Text;
            n.trinhdongoaingu = txt_ngoaingu.Text;
            n.dantoc = txt_dantoc.Text;
            n.ngaycap = DateTime.Parse(dtp_ngaycap.Text);
            n.noicap = txt_noicap.Text;

            Boolean tinhtrang = false;
            if (cmb_tinhtranghonnhan.Text == "Đã kết hôn")
            {
                tinhtrang = true;
            }
            n.tinhtranghonnhan = tinhtrang;
            n.noisinh = txt_noisinh.Text;
            n.quequan = txt_quequan.Text;
            n.noiohiennay = txt_tamtru.Text;
            n.hokhauthuongtru = txt_thuongtru.Text;
            //n.phongbanma = txt_maphongban.Text;
            //n.chucvuma = txt_chucvu.Text;
            
            db.nhanviens.Add(n);
            db.SaveChanges();
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            from2 fr = new from2();
            fr.Show();
            Hide();
        }
    }
}

