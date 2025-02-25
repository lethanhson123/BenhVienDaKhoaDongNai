namespace TiepNhanWinform
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            cbbDanhMucDichVu = new ComboBox();
            cbbDanhMucQuayDichVu = new ComboBox();
            txtSoHienTai = new TextBox();
            btnSoTiepTheo = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbbDanhMucDichVu
            // 
            cbbDanhMucDichVu.FormattingEnabled = true;
            cbbDanhMucDichVu.Location = new Point(6, 22);
            cbbDanhMucDichVu.Name = "cbbDanhMucDichVu";
            cbbDanhMucDichVu.Size = new Size(210, 23);
            cbbDanhMucDichVu.TabIndex = 0;
            cbbDanhMucDichVu.SelectedIndexChanged += cbbDanhMucDichVu_SelectedIndexChanged;
            // 
            // cbbDanhMucQuayDichVu
            // 
            cbbDanhMucQuayDichVu.FormattingEnabled = true;
            cbbDanhMucQuayDichVu.Location = new Point(6, 51);
            cbbDanhMucQuayDichVu.Name = "cbbDanhMucQuayDichVu";
            cbbDanhMucQuayDichVu.Size = new Size(210, 23);
            cbbDanhMucQuayDichVu.TabIndex = 1;
            // 
            // txtSoHienTai
            // 
            txtSoHienTai.Location = new Point(6, 80);
            txtSoHienTai.Name = "txtSoHienTai";
            txtSoHienTai.Size = new Size(210, 23);
            txtSoHienTai.TabIndex = 2;
            txtSoHienTai.Text = "0";
            txtSoHienTai.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSoTiepTheo
            // 
            btnSoTiepTheo.BackColor = Color.Cyan;
            btnSoTiepTheo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSoTiepTheo.Location = new Point(6, 109);
            btnSoTiepTheo.Name = "btnSoTiepTheo";
            btnSoTiepTheo.Size = new Size(210, 40);
            btnSoTiepTheo.TabIndex = 3;
            btnSoTiepTheo.Text = "SỐ TIẾP THEO (F1)";
            btnSoTiepTheo.UseVisualStyleBackColor = false;
            btnSoTiepTheo.Click += btnSoTiepTheo_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 128);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xác thực";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Cyan;
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.Location = new Point(6, 80);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(210, 40);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(5, 51);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.Size = new Size(210, 23);
            txtMatKhau.TabIndex = 5;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(6, 22);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.PlaceholderText = "Tài khoản";
            txtTaiKhoan.Size = new Size(210, 23);
            txtTaiKhoan.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbDanhMucDichVu);
            groupBox2.Controls.Add(cbbDanhMucQuayDichVu);
            groupBox2.Controls.Add(btnSoTiepTheo);
            groupBox2.Controls.Add(txtSoHienTai);
            groupBox2.Location = new Point(239, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(221, 159);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gọi số";
            groupBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 181);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Đồng Nai";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbbDanhMucDichVu;
        private ComboBox cbbDanhMucQuayDichVu;
        private TextBox txtSoHienTai;
        private Button btnSoTiepTheo;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
    }
}
