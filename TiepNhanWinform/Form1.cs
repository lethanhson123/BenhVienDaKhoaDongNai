namespace TiepNhanWinform
{
    public class DanhMucDichVu
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public DanhMucDichVu()
        {
        }
    }
    public class DanhMucQuayDichVu
    {
        public long ID { get; set; }       
        public string? Name { get; set; }       
        public DanhMucQuayDichVu()
        {
        }
    }
    public class GoiSo
    {
        public int? SoHienTai { get; set; }
        public int? TongCong { get; set; }
        public GoiSo()
        {
        }
    }

    public partial class Form1 : Form
    {
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
        }

        private void btnSoTiepTheo_Click(object sender, EventArgs e)
        {
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
                    btnSoTiepTheo.Text = "SỐ TIẾP THEO [" + GoiSo.SoHienTai + "/" + GoiSo.TongCong + "]";
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
    }
}
