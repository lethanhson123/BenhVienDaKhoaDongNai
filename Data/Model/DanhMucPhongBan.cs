namespace Data.Model
{
    public partial class DanhMucPhongBan : BaseModel
    {
        public string? MaTheoQuyDinh { get; set; }
        public bool? IsCanLamSang { get; set; }
        public bool? IsDocHai { get; set; }
        public bool? IsChuyenKhoa { get; set; }
        public bool? IsKhoaDieuTri { get; set; }
        public bool? QuanLyNhanSu { get; set; }
        public int? UuDaiNghe { get; set; }
        public int? GroupOrder { get; set; }
        public int? Cap { get; set; }
        public long? LoaiPhongBanID { get; set; }
           
        public DanhMucPhongBan()
        {
        }
    }
}

