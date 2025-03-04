namespace Data.Model
{
    public partial class HRNhanVienBangCap : BaseModel
    {
        public long? DanhMucBangCapID { get; set; }
        public string? DanhMucBangCapName { get; set; }
        public long? DanhMucChuyenNganhID { get; set; }
        public string? DanhMucChuyenNganhName { get; set; }
        public long? DanhMucToChucDaoTaoID { get; set; }
        public string? DanhMucToChucDaoTaoName { get; set; }

        public HRNhanVienBangCap()
        {
        }
    }
}

