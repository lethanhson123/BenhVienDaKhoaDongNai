namespace Data.Model
{
    public partial class Report : BaseModel
    {
        public string? SoHoSo { get; set; }
        public string? SoQuyetDinh { get; set; }
        public decimal? GhiCo { get; set; }
        public decimal? GhiNo { get; set; }
        public decimal? ConLai { get; set; }
        public decimal? MucDauTu { get; set; }
        public decimal? GhiCoTongCong { get; set; }
        public decimal? GhiNoTongCong { get; set; }
        public decimal? ConLaiTongCong { get; set; }
        public decimal? MucDauTuTongCong { get; set; }
        public decimal? GhiCoTyLe { get; set; }
        public decimal? GhiNoTyLe { get; set; }
        public decimal? ConLaiTyLe { get; set; }
        public decimal? MucDauTuTyLe { get; set; }
        public Report()
        {
        }
    }
}

