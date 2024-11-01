namespace Data.Model
{
    public partial class DuAnQuyetToanPhanKy : BaseModel
    {
        public long? DuAnQuyetDinhID { get; set; }
        public string? DuAnQuyetDinhSoQuyetDinh { get; set; }
        public int? Nam { get; set; }
        public int? Quy { get; set; }
        public int? Thang { get; set; }
        public int? Ngay { get; set; }
        public decimal? GhiCo { get; set; }
        public decimal? GhiNo { get; set; }
        public decimal? ConLai { get; set; }

        public DuAnQuyetToanPhanKy()
        {
        }
    }
}

