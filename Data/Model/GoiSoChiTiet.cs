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
        public string? SoThuTu { get; set; }
        public DateTime? NgayCapSo { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayKham { get; set; }
        public string? NguoiKhamHoTen { get; set; }
        public string? NguoiKhamNamSinh { get; set; }
        public string? NguoiKhamDienThoai { get; set; }
        public string? NguoiKhamCCCD { get; set; }
        public string? NguoiKhamBHYT { get; set; }
        public string? NguoiKhamDiaChi { get; set; }

        public GoiSoChiTiet()
        {
        }
    }
}

