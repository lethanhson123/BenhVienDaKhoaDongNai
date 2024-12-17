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
            cbbDanhMucDichVu = new ComboBox();
            cbbDanhMucQuayDichVu = new ComboBox();
            txtSoHienTai = new TextBox();
            btnSoTiepTheo = new Button();
            SuspendLayout();
            // 
            // cbbDanhMucDichVu
            // 
            cbbDanhMucDichVu.FormattingEnabled = true;
            cbbDanhMucDichVu.Location = new Point(12, 12);
            cbbDanhMucDichVu.Name = "cbbDanhMucDichVu";
            cbbDanhMucDichVu.Size = new Size(260, 23);
            cbbDanhMucDichVu.TabIndex = 0;
            // 
            // cbbDanhMucQuayDichVu
            // 
            cbbDanhMucQuayDichVu.FormattingEnabled = true;
            cbbDanhMucQuayDichVu.Location = new Point(12, 41);
            cbbDanhMucQuayDichVu.Name = "cbbDanhMucQuayDichVu";
            cbbDanhMucQuayDichVu.Size = new Size(260, 23);
            cbbDanhMucQuayDichVu.TabIndex = 1;
            // 
            // txtSoHienTai
            // 
            txtSoHienTai.Location = new Point(12, 70);
            txtSoHienTai.Name = "txtSoHienTai";
            txtSoHienTai.Size = new Size(260, 23);
            txtSoHienTai.TabIndex = 2;
            txtSoHienTai.Text = "0";
            txtSoHienTai.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSoTiepTheo
            // 
            btnSoTiepTheo.BackColor = Color.Cyan;
            btnSoTiepTheo.Font = new Font("Segoe UI", 14F);
            btnSoTiepTheo.Location = new Point(12, 99);
            btnSoTiepTheo.Name = "btnSoTiepTheo";
            btnSoTiepTheo.Size = new Size(260, 60);
            btnSoTiepTheo.TabIndex = 3;
            btnSoTiepTheo.Text = "SỐ TIẾP THEO";
            btnSoTiepTheo.UseVisualStyleBackColor = false;
            btnSoTiepTheo.Click += btnSoTiepTheo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(btnSoTiepTheo);
            Controls.Add(txtSoHienTai);
            Controls.Add(cbbDanhMucQuayDichVu);
            Controls.Add(cbbDanhMucDichVu);
            Name = "Form1";
            Text = "BVDKDN-Tiếp nhận";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbDanhMucDichVu;
        private ComboBox cbbDanhMucQuayDichVu;
        private TextBox txtSoHienTai;
        private Button btnSoTiepTheo;
    }
}
