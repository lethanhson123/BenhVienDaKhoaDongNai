namespace Data.Model
{
    public partial class HRNhanVienNganHang : BaseModel
    {
        public string? TaiKhoanNganHang { get; set; }
        public long? DanhMucNganHangID { get; set; }
        public string? DanhMucNganHangName { get; set; }

        public HRNhanVienNganHang()
        {
        }
    }
}

