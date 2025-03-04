namespace Data.Model
{
    public partial class HRNhanVienPhuCap : BaseModel
    {
        public long? DanhMucPhuCapID { get; set; }
        public string? DanhMucPhuCapName { get; set; }
        public decimal? HeSo { get; set; }

        public HRNhanVienPhuCap()
        {
        }
    }
}

