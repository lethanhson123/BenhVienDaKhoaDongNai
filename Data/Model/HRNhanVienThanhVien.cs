namespace Data.Model
{
    public partial class HRNhanVienThanhVien : BaseModel
    {
        public long? ThanhVienID { get; set; }
        public string? TaiKhoan { get; set; }

        public HRNhanVienThanhVien()
        {
        }
    }
}

