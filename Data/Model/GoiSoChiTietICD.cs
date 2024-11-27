namespace Data.Model
{
    public partial class GoiSoChiTietICD : BaseModel
    {
        public long? DanhMucICDID { get; set; }
        public string? DanhMucICDName { get; set; }
        public string? DanhMucICDCode { get; set; }
        public DateTime? NgayCapSo { get; set; }
        public int? NgayCapSoSoThuTu { get; set; }
        public string? NgayCapSoSoThuTuString { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public int? NgayDangKySoThuTu { get; set; }
        public string? NgayDangKySoThuTuString { get; set; }
        public GoiSoChiTietICD()
        {
        }
    }
}

