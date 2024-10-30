namespace Data.Model
{
    public partial class DuAnThuChi : BaseModel
    {
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string? SoHoSo { get; set; }
        public string? SoButToan { get; set; }
        public string? BenDauTuID { get; set; }
        public string? BenDauTuName { get; set; }
        public string? BenDauTuSoTaiKhoan { get; set; }
        public string? BenDauTuNganHang { get; set; }
        public string? BenThucHienID { get; set; }
        public string? BenThucHienName { get; set; }
        public string? BenThucHienSoTaiKhoan { get; set; }
        public string? BenThucHienNganHang { get; set; }
        public decimal? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }
        public int? HeSo { get; set; }
        public decimal? GhiCo { get; set; }
        public decimal? GhiNo { get; set; }
        public long? NguoiDauTuID { get; set; }
        public string? NguoiDauTuName { get; set; }
        public long? NguoiThucHienID { get; set; }
        public string? NguoiThucHienName { get; set; }
        public long? DanhMucBieuMauID { get; set; }
        public string? DanhMucBieuMauName { get; set; }
        public long? DanhMucHinhThucThanhToanID { get; set; }
        public string? DanhMucHinhThucThanhToanName { get; set; }
        public long? DanhMucTinhTrangID { get; set; }
        public string? DanhMucTinhTrangName { get; set; }

        public DuAnThuChi()
        {
            NgayBatDau = GlobalHelper.InitializationDateTime;
        }
    }
}

