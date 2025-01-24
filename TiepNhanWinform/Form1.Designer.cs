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
            SuspendLayout();
            // 
            // cbbDanhMucDichVu
            // 
            cbbDanhMucDichVu.FormattingEnabled = true;
            cbbDanhMucDichVu.Location = new Point(12, 12);
            cbbDanhMucDichVu.Name = "cbbDanhMucDichVu";
            cbbDanhMucDichVu.Size = new Size(210, 23);
            cbbDanhMucDichVu.TabIndex = 0;
            cbbDanhMucDichVu.SelectedIndexChanged += cbbDanhMucDichVu_SelectedIndexChanged;
            // 
            // cbbDanhMucQuayDichVu
            // 
            cbbDanhMucQuayDichVu.FormattingEnabled = true;
            cbbDanhMucQuayDichVu.Location = new Point(12, 41);
            cbbDanhMucQuayDichVu.Name = "cbbDanhMucQuayDichVu";
            cbbDanhMucQuayDichVu.Size = new Size(210, 23);
            cbbDanhMucQuayDichVu.TabIndex = 1;
            // 
            // txtSoHienTai
            // 
            txtSoHienTai.Location = new Point(12, 70);
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
            btnSoTiepTheo.Location = new Point(12, 99);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 141);
            Controls.Add(btnSoTiepTheo);
            Controls.Add(txtSoHienTai);
            Controls.Add(cbbDanhMucQuayDichVu);
            Controls.Add(cbbDanhMucDichVu);
            Name = "Form1";
            Text = "Tiếp nhận";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbDanhMucDichVu;
        private ComboBox cbbDanhMucQuayDichVu;
        private TextBox txtSoHienTai;
        private Button btnSoTiepTheo;
        private System.Windows.Forms.Timer timer1;
    }
}
