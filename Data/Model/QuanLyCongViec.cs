namespace Data.Model
{
    public partial class QuanLyCongViec : BaseModel
    {
        public long? ThanhVienID { get; set; }
        public DateTime? NgayGhiNhan { get; set; }
        public DateTime? NgayDuyet { get; set; }
        public DateTime? NgayTrienKhai { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string? PhanLoai { get; set; }
        public string? ThucTrang { get; set; }
        public string? XuLy { get; set; }
        public string? TienDo { get; set; }
        public string? DanhGia { get; set; }
        public QuanLyCongViec()
        {
            NgayGhiNhan = GlobalHelper.InitializationDateTime;
        }
    }
}

