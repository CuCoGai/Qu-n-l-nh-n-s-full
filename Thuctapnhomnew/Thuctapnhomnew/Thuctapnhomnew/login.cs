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
        QLNhanSuEntities db=new QLNhanSuEntities();
        public frm_login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_dangnhap;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                NguoiDung use = db.NguoiDungs.Where(s => s.username == txt_user.Text).FirstOrDefault();
                if (txt_user.Text == use.username && txt_pass.Text==use.pass)
                {
                    frm_trangchu fr = new frm_trangchu();
                    fr.EnableMenu();
                    fr.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng", "thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tên đăng nhập không đúng", "thông báo");
            }
        }
    }
}
    
