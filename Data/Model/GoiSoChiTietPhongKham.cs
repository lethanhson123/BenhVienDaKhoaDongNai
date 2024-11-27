namespace Data.Model
{
    public partial class GoiSoChiTietPhongKham : BaseModel
    {
        public long? DanhMucPhongKhamID { get; set; }
        public string? DanhMucPhongKhamName { get; set; }
        public string? DanhMucPhongKhamCode { get; set; }
        public DateTime? NgayCapSo { get; set; }
        public int? NgayCapSoSoThuTu { get; set; }
        public string? NgayCapSoSoThuTuString { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public int? NgayDangKySoThuTu { get; set; }
        public string? NgayDangKySoThuTuString { get; set; }
        public string? Barcode { get; set; }
        public string? BarcodeFileName { get; set; }

        public GoiSoChiTietPhongKham()
        {
        }
    }
}

