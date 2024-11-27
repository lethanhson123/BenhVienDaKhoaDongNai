namespace Data.Model
{
    public partial class GoiSoChiTiet : BaseModel
    {

        public long? DanhMucKhuVucID { get; set; }
        public string? DanhMucKhuVucName { get; set; }
        public string? DanhMucKhuVucCode { get; set; }
        public long? DanhMucDichVuID { get; set; }
        public string? DanhMucDichVuName { get; set; }
        public string? DanhMucDichVuCode { get; set; }
        public long? DanhMucQuayDichVuID { get; set; }
        public string? DanhMucQuayDichVuName { get; set; }
        public string? DanhMucQuayDichVuCode { get; set; }
        public long? DanhMucPhongKhamID { get; set; }
        public string? DanhMucPhongKhamName { get; set; }
        public string? DanhMucPhongKhamCode { get; set; }
        public long? KhachHangID { get; set; }
        public string? HoTen { get; set; }
        public int? NamSinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DienThoai { get; set; }
        public string? CCCD { get; set; }
        public string? BHYT { get; set; }
        public string? DiaChi { get; set; }
        public bool? GioiTinh { get; set; }
        public long? DanhMucTinhThanhID { get; set; }
        public string? DanhMucTinhThanhName { get; set; }
        public long? DanhMucQuanHuyenID { get; set; }
        public string? DanhMucQuanHuyenName { get; set; }
        public long? DanhMucXaPhuongID { get; set; }
        public string? DanhMucXaPhuongName { get; set; }
        public DateTime? NgayCapSo { get; set; }
        public int? NgayCapSoSoThuTu { get; set; }
        public string? NgayCapSoSoThuTuString { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public int? NgayDangKySoThuTu { get; set; }
        public string? NgayDangKySoThuTuString { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public int? NgayThanhToanSoThuTu { get; set; }
        public string? NgayThanhToanSoThuTuString { get; set; }
        public DateTime? NgayLinhThuoc { get; set; }
        public int? NgayLinhThuocSoThuTu { get; set; }
        public string? NgayLinhThuocSoThuTuString { get; set; }

        public GoiSoChiTiet()
        {
        }
    }
}

