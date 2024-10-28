namespace Data.Model
{
    public partial class ThanhVienChucNang : BaseModel
    {
        public long? DanhMucChucNangID { get; set; }
        public string? DanhMucChucNangName { get; set; }

        public ThanhVienChucNang()
        {
        }
    }
}

