namespace Data.Model
{
    public partial class ThanhVienPhongKham : BaseModel
    {
        public long? DanhMucPhongKhamID { get; set; }
        public string? DanhMucPhongKhamName { get; set; }

        public ThanhVienPhongKham()
        {
        }
    }
}

