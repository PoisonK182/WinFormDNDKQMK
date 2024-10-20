namespace FORMDNDK
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox_TenTaiKhoan = new TextBox();
            textBox_MatKhau = new TextBox();
            linkLabel_QuenMatKhau = new LinkLabel();
            linkLabel_DangKy = new LinkLabel();
            button_DangNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 228);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 297);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // textBox_TenTaiKhoan
            // 
            textBox_TenTaiKhoan.Location = new Point(231, 228);
            textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            textBox_TenTaiKhoan.Size = new Size(356, 27);
            textBox_TenTaiKhoan.TabIndex = 3;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(231, 290);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.PasswordChar = '*';
            textBox_MatKhau.Size = new Size(356, 27);
            textBox_MatKhau.TabIndex = 4;
            // 
            // linkLabel_QuenMatKhau
            // 
            linkLabel_QuenMatKhau.AutoSize = true;
            linkLabel_QuenMatKhau.Location = new Point(107, 349);
            linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            linkLabel_QuenMatKhau.Size = new Size(111, 20);
            linkLabel_QuenMatKhau.TabIndex = 5;
            linkLabel_QuenMatKhau.TabStop = true;
            linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu";
            linkLabel_QuenMatKhau.LinkClicked += linkLabel_QuenMatKhau_LinkClicked;
            // 
            // linkLabel_DangKy
            // 
            linkLabel_DangKy.AutoSize = true;
            linkLabel_DangKy.Location = new Point(511, 349);
            linkLabel_DangKy.Name = "linkLabel_DangKy";
            linkLabel_DangKy.Size = new Size(64, 20);
            linkLabel_DangKy.TabIndex = 6;
            linkLabel_DangKy.TabStop = true;
            linkLabel_DangKy.Text = "Đăng Ký";
            linkLabel_DangKy.LinkClicked += linkLabel_DangKy_LinkClicked;
            // 
            // button_DangNhap
            // 
            button_DangNhap.Location = new Point(293, 373);
            button_DangNhap.Name = "button_DangNhap";
            button_DangNhap.Size = new Size(169, 53);
            button_DangNhap.TabIndex = 7;
            button_DangNhap.Text = "Đăng Nhập";
            button_DangNhap.UseVisualStyleBackColor = true;
            button_DangNhap.Click += button_DangNhap_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_DangNhap);
            Controls.Add(linkLabel_DangKy);
            Controls.Add(linkLabel_QuenMatKhau);
            Controls.Add(textBox_MatKhau);
            Controls.Add(textBox_TenTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "DangNhap";
            Text = "Đăng Nhập";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox_TenTaiKhoan;
        private TextBox textBox_MatKhau;
        private LinkLabel linkLabel_QuenMatKhau;
        private LinkLabel linkLabel_DangKy;
        private Button button_DangNhap;
    }
}
