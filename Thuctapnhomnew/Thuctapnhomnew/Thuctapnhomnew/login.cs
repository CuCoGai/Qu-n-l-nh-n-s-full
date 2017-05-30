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

namespace Thuctapnhomnew
{
    public partial class frm_login : Form
    {
        public SqlConnection conn;
        public DataTable dt = new DataTable("NguoiDung");
        public SqlDataAdapter da = new SqlDataAdapter();

        private void connect()
        {
            string str = @"Data Source=DESKTOP-MON8K1N\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            try
            {
                conn = new SqlConnection(str);
                conn.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("không thể kết nối tới cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

        }

        private void disconnect()
        {
            conn.Close();//ngắt kết nối
            conn.Dispose();//giải phóng tài nguyên
            conn = null;//hủy đối tượng

        }

        public frm_login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            connect();
            //  txt_ten.Text = "admin";
            this.AcceptButton = btn_dangnhap;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conn;
            cm.CommandType = CommandType.Text;
            cm.CommandText = @"select * from NguoiDung where username=@ten and pass=@password";
            cm.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = txt_user.Text;
            cm.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txt_pass.Text;
            da.SelectCommand = cm;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                frm_trangchu fr = new frm_trangchu();

                 fr.EnableMenu();
                fr.Show();

                Hide();
            }
            else
                MessageBox.Show("Đăng nhập thất bại", "thông báo");
        }
    }
}
    
