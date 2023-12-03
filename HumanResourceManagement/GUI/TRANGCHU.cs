using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_NHAN_SU.GUI
{
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        { 
            InitializeComponent();
        }
        private void ThoatHeThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void QuanLyNhanSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frm_NhanSu NV = new frm_NhanSu();
            NV.ShowDialog();
            Show();
        }
        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frm_DangNhap dn = new frm_DangNhap();
            dn.ShowDialog(); 
        }

    }
}
