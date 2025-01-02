namespace Data.Model
{
    public partial class TrucBanNhatKy : BaseModel
    {
        public DateTime? NgayGhiNhan { get; set; }
        public string? Khu { get; set; }
        public string? Tang { get; set; }
        public string? Khoa { get; set; }
        public string? Phong { get; set; }
        public string? TaiKhoan { get; set; }
        public string? ThucTrang { get; set; }
        public string? XuLy { get; set; }        
        public TrucBanNhatKy()
        {
            NgayGhiNhan = GlobalHelper.InitializationDateTime;
        }
    }
}

