using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMDNDK
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
