namespace Data.Model
{
    public partial class ThanhVien : BaseModel
    {
        public long? DanhMucBenhVienID { get; set; }
        public string? DanhMucBenhVienName { get; set; }
        public long? DanhMucPhongBanID { get; set; }
        public string? DanhMucPhongBanName { get; set; }
        public long? DanhMucChucDanhID { get; set; }
        public string? DanhMucChucDanhName { get; set; }
        public string? Email { get; set; }
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? CCCD { get; set; }
        public string? TaiKhoan { get; set; }
        public string? MatKhau { get; set; }
        public string? GUIDCode { get; set; }        
        public long? HRNhanVIenID { get; set; }

        public ThanhVien()
        {
        }
    }
}

