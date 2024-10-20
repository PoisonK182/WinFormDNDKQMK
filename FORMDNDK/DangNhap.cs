namespace FORMDNDK
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
        Modify modify = new Modify();
        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nh?p tên tài kho?n! "); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nh?p m?t kh?u! "); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count!=0)
                {
                    MessageBox.Show("??ng nh?p thành công!","Thông báo ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Home home= new Home();
                    home.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tên tài kho?n ho?c m?t kh?u ch?a ?úng !");
                }
            }
        }
    }
}
