namespace FORMDNDK
{
    partial class DangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox_TenTaiKhoan = new TextBox();
            textBox_MatKhau = new TextBox();
            label2 = new Label();
            textBox_XNMatKhau = new TextBox();
            label3 = new Label();
            textBox_Email = new TextBox();
            label4 = new Label();
            button_DangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 197);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên tài khoản:";
            // 
            // textBox_TenTaiKhoan
            // 
            textBox_TenTaiKhoan.Location = new Point(211, 197);
            textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            textBox_TenTaiKhoan.Size = new Size(390, 27);
            textBox_TenTaiKhoan.TabIndex = 2;
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(211, 248);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.Size = new Size(390, 27);
            textBox_MatKhau.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 248);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // textBox_XNMatKhau
            // 
            textBox_XNMatKhau.Location = new Point(211, 296);
            textBox_XNMatKhau.Name = "textBox_XNMatKhau";
            textBox_XNMatKhau.Size = new Size(390, 27);
            textBox_XNMatKhau.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 296);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 5;
            label3.Text = "Xác nhận mật khẩu:";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(211, 343);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(390, 27);
            textBox_Email.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 343);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // button_DangKy
            // 
            button_DangKy.Location = new Point(268, 400);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(183, 29);
            button_DangKy.TabIndex = 9;
            button_DangKy.Text = "Đăng Ký";
            button_DangKy.UseVisualStyleBackColor = true;
            button_DangKy.Click += button_DangKy_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_DangKy);
            Controls.Add(textBox_Email);
            Controls.Add(label4);
            Controls.Add(textBox_XNMatKhau);
            Controls.Add(label3);
            Controls.Add(textBox_MatKhau);
            Controls.Add(label2);
            Controls.Add(textBox_TenTaiKhoan);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "DangKy";
            Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox_TenTaiKhoan;
        private TextBox textBox_MatKhau;
        private Label label2;
        private TextBox textBox_XNMatKhau;
        private Label label3;
        private TextBox textBox_Email;
        private Label label4;
        private Button button_DangKy;
    }
}