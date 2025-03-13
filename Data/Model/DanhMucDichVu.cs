namespace Data.Model
{
    public partial class DanhMucDichVu : BaseModel
    {
        public bool? IsBHYT { get; set; }
        public bool? IsHangDoiPhanNhanh { get; set; }
        public int? BuocNhay { get; set; }
        public int? GroupOrder { get; set; }
        public DanhMucDichVu()
        {
        }
    }
}

