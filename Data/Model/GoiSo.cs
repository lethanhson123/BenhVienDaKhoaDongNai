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
        public long? DanhMucPhongKhamID { get; set; }
        public string? DanhMucPhongKhamName { get; set; }
        public string? DanhMucPhongKhamCode { get; set; }
        public DateTime? NgayGhiNhan { get; set; }
        public int? TongCong { get; set; }
        public string? TongCongString { get; set; }
        public int? SoHienTai { get; set; }
        public string? SoHienTaiString { get; set; }

        public GoiSo()
        {
            SoHienTai = GlobalHelper.InitializationNumber;
        }
    }
}

