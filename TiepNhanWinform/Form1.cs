using System.Windows.Forms;

namespace TiepNhanWinform
{
    public partial class Form1 : Form
    {
        public DateTime? NgayHienTai { get; set; }
        public string? APICapSoSite { get; set; }
        public List<DanhMucDichVu>? ListDanhMucDichVu { get; set; }
        public List<DanhMucQuayDichVu>? ListDanhMucQuayDichVu { get; set; }
        public List<DanhMucQuayDichVu>? ListDanhMucQuayDichVuSub { get; set; }
        public DanhMucDichVu? DanhMucDichVu { get; set; }
        public DanhMucQuayDichVu? DanhMucQuayDichVu { get; set; }
        public ThanhVien? ThanhVien { get; set; }

        public string FileName = "ThanhVien.txt";
        public Form1()
        {
            InitializeComponent();
            ThanhVien = new ThanhVien();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            StartPosition = FormStartPosition.Manual;
            Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            this.TopMost = true;
            APICapSoSite = "http://10.84.3.124:901";
            //APICapSoSite = "http://localhost:5097";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string url = APICapSoSite + "/api/v1/DanhMucQuayDichVu/GetByActiveToListAsync?Active=true";
                HttpClient client = new HttpClient();
                string response = client.GetStringAsync(url).Result;
                ListDanhMucQuayDichVu = JsonConvert.DeserializeObject<List<DanhMucQuayDichVu>>(response);
                if (ListDanhMucQuayDichVu != null)
                {
                    if (ListDanhMucQuayDichVu.Count > 0)
                    {
                        if (ListDanhMucDichVu != null)
                        {
                            if (ListDanhMucDichVu.Count > 0)
                            {
                                long DanhMucDichVuID = ListDanhMucDichVu[0].ID;
                                ListDanhMucQuayDichVuSub = ListDanhMucQuayDichVu.Where(item => item.DanhMucDichVuID == DanhMucDichVuID).ToList();
                                cbbDanhMucQuayDichVu.DataSource = ListDanhMucQuayDichVuSub;
                                cbbDanhMucQuayDichVu.ValueMember = "ID";
                                cbbDanhMucQuayDichVu.DisplayMember = "Name";
                            }
                        }
                    }
                }

                if (File.Exists(FileName))
                {
                    string content = File.ReadAllText(FileName);
                    if (!string.IsNullOrEmpty(content))
                    {
                        try
                        {
                            ThanhVien.ID = long.Parse(content);
                            if (ThanhVien.ID > 0)
                            {
                                GetListDanhMucDichVu();
                                SetGroupBox();
                            }
                        }
                        catch (Exception ex)
                        {
                            string msg = ex.Message;
                            MessageBox.Show(msg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg);
            }
            NgayHienTai = DateTime.Now;
        }

        private void btnSoTiepTheo_Click(object sender, EventArgs e)
        {
            SoTiepTheo();
        }
        private void SoTiepTheo()
        {
            try
            {
                if (NgayHienTai.Value.Day != DateTime.Now.Day)
                {
                    NgayHienTai = DateTime.Now;
                    txtSoHienTai.Text = "0";
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            try
            {
                long DanhMucDichVuID = long.Parse(cbbDanhMucDichVu.SelectedValue.ToString());
                long DanhMucQuayDichVuID = long.Parse(cbbDanhMucQuayDichVu.SelectedValue.ToString());
                int SoHienTai = int.Parse(txtSoHienTai.Text.Trim());

                string url = APICapSoSite + "/api/v1/GoiSo/GetGoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTaiAsync?DanhMucDichVuID=" + DanhMucDichVuID + "&DanhMucQuayDichVuID=" + DanhMucQuayDichVuID + "&SoHienTai=" + SoHienTai;
                HttpClient client = new HttpClient();
                string response = client.GetStringAsync(url).Result;
                GoiSo GoiSo = JsonConvert.DeserializeObject<GoiSo>(response);
                if (GoiSo != null)
                {
                    txtSoHienTai.Text = GoiSo.SoHienTai.ToString();
                    string TieuDe = "SỐ TIẾP THEO (F1)";
                    btnSoTiepTheo.Text = TieuDe + " [" + GoiSo.SoHienTai + "/" + GoiSo.TongCong + "]";
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    SoTiepTheo();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void cbbDanhMucDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbDanhMucDichVu.Items.Count > 0)
                {
                    long DanhMucDichVuID = (long)cbbDanhMucDichVu.SelectedValue;
                    SetCBBDanhMucQuayDichVu(DanhMucDichVuID);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (cbbDanhMucDichVu.Items.Count > 0)
                {
                    if (cbbDanhMucQuayDichVu.Items.Count > 0)
                    {
                        long DanhMucDichVuID = long.Parse(cbbDanhMucDichVu.SelectedValue.ToString());
                        long DanhMucQuayDichVuID = long.Parse(cbbDanhMucQuayDichVu.SelectedValue.ToString());

                        string url = APICapSoSite + "/api/v1/GoiSo/GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuIDAsync?DanhMucDichVuID=" + DanhMucDichVuID + "&DanhMucQuayDichVuID=" + DanhMucQuayDichVuID;
                        HttpClient client = new HttpClient();
                        string response = client.GetStringAsync(url).Result;
                        GoiSo GoiSo = JsonConvert.DeserializeObject<GoiSo>(response);
                        if (GoiSo != null)
                        {
                            txtSoHienTai.Text = GoiSo.SoHienTai.ToString();
                            string TieuDe = "SỐ TIẾP THEO (F1)";
                            btnSoTiepTheo.Text = TieuDe + " [" + GoiSo.SoHienTai + "/" + GoiSo.TongCong + "]";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }

        private void GetListDanhMucDichVu()
        {
            string url = APICapSoSite + "/api/v1/DanhMucDichVu/GetAllowAnonymousByThanhVienID_ActiveToListAsync?ThanhVienID=" + ThanhVien.ID + "&Active=true";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;
            ListDanhMucDichVu = JsonConvert.DeserializeObject<List<DanhMucDichVu>>(response);
            if (ListDanhMucDichVu != null)
            {
                if (ListDanhMucDichVu.Count > 0)
                {
                    cbbDanhMucDichVu.DataSource = ListDanhMucDichVu;
                    cbbDanhMucDichVu.ValueMember = "ID";
                    cbbDanhMucDichVu.DisplayMember = "Name";

                    long DanhMucDichVuID = ListDanhMucDichVu[0].ID;
                    SetCBBDanhMucQuayDichVu(DanhMucDichVuID);
                }
            }
        }
        private void SetGroupBox()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox2.Location = new Point(groupBox1.Location.X, groupBox1.Location.Y);
        }
        private void SetCBBDanhMucQuayDichVu(long DanhMucDichVuID)
        {
            ListDanhMucQuayDichVuSub = ListDanhMucQuayDichVu.Where(item => item.DanhMucDichVuID == DanhMucDichVuID).ToList();
            if (ListDanhMucQuayDichVuSub != null)
            {
                if (ListDanhMucQuayDichVuSub.Count > 0)
                {
                    cbbDanhMucQuayDichVu.DataSource = ListDanhMucQuayDichVuSub;
                    cbbDanhMucQuayDichVu.ValueMember = "ID";
                    cbbDanhMucQuayDichVu.DisplayMember = "Name";
                }
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtTaiKhoan.Text.Trim();
            string MatKhau = txtMatKhau.Text.Trim();
            string url = APICapSoSite + "/api/v1/ThanhVien/GetAuthenticationAsync?TaiKhoan=" + TaiKhoan + "&MatKhau=" + MatKhau;
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;
            ThanhVien = JsonConvert.DeserializeObject<ThanhVien>(response);
            if (ThanhVien != null)
            {
                if (ThanhVien.ID > 0)
                {
                    File.Create(FileName).Close();
                    using (StreamWriter sw = File.AppendText(FileName))
                    {
                        sw.WriteLine(@"" + ThanhVien.ID);
                    }
                    GetListDanhMucDichVu();
                    SetGroupBox();
                }
            }
        }
    }
}
