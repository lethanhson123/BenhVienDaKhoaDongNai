namespace Data.Model
{
    public partial class DuAnQuyetToan : BaseModel
    {
        public int? Nam { get; set; }
        public int? Quy { get; set; }
        public int? Thang { get; set; }
        public int? Ngay { get; set; }
        public decimal? GhiCo { get; set; }
        public decimal? GhiNo { get; set; }
        public decimal? ConLai { get; set; }

        public DuAnQuyetToan()
        {
        }
    }
}

