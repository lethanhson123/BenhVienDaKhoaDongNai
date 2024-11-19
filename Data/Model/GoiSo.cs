namespace Data.Model
{
    public partial class GoiSo : BaseModel
    {
        public long? DanhMucKhuVucID { get; set; }
        public string? DanhMucKhuVucName { get; set; }
        public string? DanhMucKhuVucCode { get; set; }
        public long? DanhMucDichVuID { get; set; }
        public string? DanhMucDichVuName { get; set; }
        public string? DanhMucDichVuCode { get; set; }
        public DateTime? NgayGhiNhan { get; set; }
        public int? TongCong { get; set; }
        public int? SoHienTai { get; set; }
        public string? SoThuTu { get; set; }

        public GoiSo()
        {
        }
    }
}

