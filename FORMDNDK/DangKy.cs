using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace FORMDNDK
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();

        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[\w]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();   
        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_XNMatKhau.Text;
            string email = textBox_Email.Text;
            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 kí tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (xnmatkhau!=matkhau) { MessageBox.Show("Xác nhận mật khẩu hoặc mật khẩu chưa trùng nhau"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập email dài 6-24 kí tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '"+email+"'").Count!=0) { MessageBox.Show("Email đã được đăng ký rồi, vui lòng đăng ký email khác!");return; }
            try
            {
                string query = "Insert into TaiKhoan values ('"+tentk+"','"+matkhau+"','"+email+"')";
                modify.command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký! Vui lòng đăng ký tên tài khoản khác!");
            }
        }
    }
}
