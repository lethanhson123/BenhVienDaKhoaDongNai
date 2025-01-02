namespace TiepNhanWinform
{
    public partial class Form1 : Form
    {
        public DateTime? NgayHienTai { get; set; }
        public Form1()
        {
            InitializeComponent();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            StartPosition = FormStartPosition.Manual;
            Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string APICapSoSite = "http://10.84.3.124:901";
            string url = APICapSoSite + "/api/v1/DanhMucDichVu/GetByActive001ToListAsync?Active=true";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;
            List<DanhMucDichVu> ListDanhMucDichVu = JsonConvert.DeserializeObject<List<DanhMucDichVu>>(response);
            if (ListDanhMucDichVu != null)
            {
                if (ListDanhMucDichVu.Count > 0)
                {
                    cbbDanhMucDichVu.DataSource = ListDanhMucDichVu;
                    cbbDanhMucDichVu.ValueMember = "ID";
                    cbbDanhMucDichVu.DisplayMember = "Name";
                }
            }

            url = APICapSoSite + "/api/v1/DanhMucQuayDichVu/GetByParentIDAndActive001ToListAsync?ParentID=1&Active=true";
            client = new HttpClient();
            response = client.GetStringAsync(url).Result;
            List<DanhMucQuayDichVu> ListDanhMucQuayDichVu = JsonConvert.DeserializeObject<List<DanhMucQuayDichVu>>(response);
            if (ListDanhMucQuayDichVu != null)
            {
                if (ListDanhMucQuayDichVu.Count > 0)
                {
                    cbbDanhMucQuayDichVu.DataSource = ListDanhMucQuayDichVu;
                    cbbDanhMucQuayDichVu.ValueMember = "ID";
                    cbbDanhMucQuayDichVu.DisplayMember = "Name";
                }
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
                string APICapSoSite = "http://10.84.3.124:901";
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
    }
}
