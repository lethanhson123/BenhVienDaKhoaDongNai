namespace Data.Model
{
    public partial class ThanhVienDichVu : BaseModel
    {
        public long? DanhMucDichVuID { get; set; }
        public string? DanhMucDichVuName { get; set; }

        public ThanhVienDichVu()
        {
        }
    }
}

