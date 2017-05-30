using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Thuctapnhomnew
{
    public partial class frm_trangchu : Form
    {
        public frm_trangchu()
        {
            InitializeComponent();
        }

        private void tsmenu_dangnhap_Click(object sender, EventArgs e)
        {
            frm_login fr = new frm_login();
            fr.Show();
            Hide();

        }
        public void EnableMenu()
        {
            tl_quanli.Enabled = true;
            tl_help.Enabled = true;

        }
        public void DisEnabledMenu()
        {
            tl_quanli.Enabled = false;
            tl_help.Enabled = false;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            from2 fr = new from2();
            fr.Show();
            Hide();

        }

        private void tl_help_Click(object sender, EventArgs e)
        {
            
        }

        private void hợpĐồngLaoĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHopDong fr = new frmHopDong();
            fr.Show();
            Hide();
        }
    }
}
