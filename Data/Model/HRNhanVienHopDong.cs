namespace Data.Model
{
    public partial class HRNhanVienHopDong : BaseModel
    {
        public long? DanhMucHopDongID { get; set; }
        public string? DanhMucHopDongName { get; set; }
        public long? DanhMucBacLuongID { get; set; }
        public string? DanhMucBacLuongName { get; set; }
        public long? DanhMucChucDanhID { get; set; }
        public string? DanhMucChucDanhName { get; set; }
        public long? DanhMucChucVuID { get; set; }
        public string? DanhMucChucVuName { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public decimal? HeSo { get; set; }

        public HRNhanVienHopDong()
        {
        }
    }
}

