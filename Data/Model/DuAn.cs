namespace Data.Model
{
    public partial class DuAn : BaseModel
    {

        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string? SoHoSo { get; set; }
        public string? SoQuyetDinh { get; set; }
        public long? BenDauTuID { get; set; }
        public string? BenDauTuName { get; set; }
        public string? BenDauTuMaSoThue { get; set; }
        public string? BenDauTuDienThoai { get; set; }
        public string? BenDauTuDiaChi { get; set; }
        public string? BenDauTuEmail { get; set; }
        public long? BenDauTuTaiKhoanID { get; set; }
        public string? BenDauTuSoTaiKhoan { get; set; }
        public string? BenDauTuNganHang { get; set; }
        public long? BenThucHienID { get; set; }
        public string? BenThucHienName { get; set; }
        public string? BenThucHienMaSoThue { get; set; }
        public string? BenThucHienDienThoai { get; set; }
        public string? BenThucHienDiaChi { get; set; }
        public string? BenThucHienEmail { get; set; }
        public long? BenThucHienTaiKhoanID { get; set; }
        public string? BenThucHienSoTaiKhoan { get; set; }
        public string? BenThucHienNganHang { get; set; }
        public long? NguoiDauTuID { get; set; }
        public string? NguoiDauTuName { get; set; }
        public string? NguoiDauTuChucDanh { get; set; }
        public long? NguoiThucHienID { get; set; }
        public string? NguoiThucHienName { get; set; }
        public string? NguoiThucHienChucDanh { get; set; }       
        public long? DanhMucTinhTrangID { get; set; }
        public string? DanhMucTinhTrangName { get; set; }
        public decimal? TongTien { get; set; }
        public decimal? DaChi { get; set; }
        public decimal? ConLai { get; set; }
        public string? FileNameQRCode { get; set; }

        public DuAn()
        {
            NgayBatDau = GlobalHelper.InitializationDateTime;
        }
    }
}

