namespace Data.Model
{
    public partial class HRBangLuongChiTiet : BaseModel
    {
        public DateTime? NgayGhiNhan { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public decimal? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? HeSo { get; set; }
        public decimal? TongCong { get; set; }
        public long? DanhMucBacLuongID { get; set; }
        public string? DanhMucBacLuongName { get; set; }
        public long? DanhMucLuongCoBanID { get; set; }
        public string? DanhMucLuongCoBanName { get; set; }
        public long? DanhMucThueID { get; set; }
        public string? DanhMucThueName { get; set; }
        public long? DanhMucPhuCapID { get; set; }
        public string? DanhMucPhuCapName { get; set; }
        public long? DanhMucGiamTruID { get; set; }
        public string? DanhMucGiamTruName { get; set; }

        public HRBangLuongChiTiet()
        {
        }
    }
}

