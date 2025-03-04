namespace Data.Model
{
    public partial class HRChamCongChiTiet : BaseModel
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public DateTime? BatDau { get; set; }
        public DateTime? KetThuc { get; set; }
        public decimal? ChamCong { get; set; }
        public long? DanhMucChamCongID { get; set; }
        public string? DanhMucChamCongName { get; set; }
        public long? DanhMucPhuCapID { get; set; }
        public string? DanhMucPhuCapName { get; set; }

        public HRChamCongChiTiet()
        {
        }
    }
}

