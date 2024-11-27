namespace Data.Model
{
    public partial class DanhMucPhongKham : BaseModel
    {
        public long? DanhMucKhoaChuyenMonID { get; set; }
        public string? DanhMucKhoaChuyenMonName { get; set; }
        public DanhMucPhongKham()
        {
        }
    }
}

