namespace Data.Model
{
    public partial class DanhMucQuayDichVu : BaseModel
    {
        public bool? IsThuNgan { get; set; }
        public bool? IsTiepNhan { get; set; }
        public bool? IsNhaThuoc { get; set; }
        public long? DanhMucDichVuID { get; set; }
        public string? DanhMucDichVuName { get; set; }
        public DanhMucQuayDichVu()
        {
        }
    }
}

